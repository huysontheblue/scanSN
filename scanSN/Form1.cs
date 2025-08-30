using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace scanSN
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CMDB"].ConnectionString;
        private string PMPMES = ConfigurationManager.ConnectionStrings["PMPMES"].ConnectionString;
        private System.Windows.Forms.Timer autoUpdateTimer;
        private System.Windows.Forms.Timer debounceTimer;
        private DateTime _lastUpdate = DateTime.MinValue;
        private string machineId;

        // counters for total and daily SN counts
        private long totalCount = 0;
        private long dailyCount = 0;
        private long totalCountall = 0;
        private bool countersNeedUpdate = false;

        public Form1()
        {
            InitializeComponent();
            txtSn.Enabled = false;
            txtEEEE.Enabled = false;
            txtApn.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            machineId = GetMachineId();
            // AutoUpdate Timer
            autoUpdateTimer = new System.Windows.Forms.Timer();
            autoUpdateTimer.Interval = 500;
            autoUpdateTimer.Tick += AutoUpdateTimer_Tick;

            // Debounce Timer for UI updates
            debounceTimer = new System.Windows.Forms.Timer();
            debounceTimer.Interval = 100;
            debounceTimer.Tick += DebounceTimer_Tick;
        }

        private string GetMachineId()
        {
            return Environment.MachineName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Select();
            LoadInitialCounts();
            autoUpdateTimer.Start();
            debounceTimer.Start();
        }

        private void LoadInitialCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Đếm tổng số bản ghi cho máy hiện tại
                    //string totalQuery = "SELECT COUNT(*) FROM sn2 WHERE machine_id = @machine_id";
                    //using (SqlCommand command = new SqlCommand(totalQuery, connection))
                    //{
                    //    command.Parameters.AddWithValue("@machine_id", machineId);
                    //    totalCount = Convert.ToInt64(command.ExecuteScalar() ?? 0);
                    //}

                    // Đếm tổng số bản ghi
                    string totalQueryall = "SELECT SUM(p.rows) FROM sys.partitions p WHERE p.object_id = OBJECT_ID('sn') AND p.index_id IN (0, 1)";
                    using (SqlCommand command = new SqlCommand(totalQueryall, connection))
                    {
                        totalCountall = Convert.ToInt64(command.ExecuteScalar() ?? 0);
                    }

                    // Đếm bản ghi hàng ngày cho máy hiện tại
                    DateTime today = DateTime.Today;
                    DateTime tomorrow = today.AddDays(1);
                    string dailyQuery = "SELECT COUNT(*) FROM sn WITH (NOLOCK) WHERE machine_id = @machine_id AND create_time >= @startDate AND create_time < @endDate";
                    using (SqlCommand command = new SqlCommand(dailyQuery, connection))
                    {
                        command.Parameters.AddWithValue("@machine_id", machineId);
                        command.Parameters.AddWithValue("@startDate", today);
                        command.Parameters.AddWithValue("@endDate", tomorrow);
                        dailyCount = Convert.ToInt64(command.ExecuteScalar() ?? 0);
                    }

                    UpdateLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabels()
        {
            labelCount.Text = totalCountall.ToString();
            labelDay.Text = dailyCount.ToString();
            labelKhay.Text = (dailyCount / 200).ToString();
            countersNeedUpdate = false;
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            if (countersNeedUpdate)
            {
                UpdateLabels();
            }
        }

        private void AutoUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > _lastUpdate.Date)
            {
                dailyCount = 0;
                LoadInitialCounts();
                _lastUpdate = DateTime.Now;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string username = txtUser.Text.Trim();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Vui lòng nhập User_ID (请输入账号)", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT TOP 1 msah03 FROM msah WHERE msah03 = @Username";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtUser.Enabled = false;
                                txtApn.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản " + username + " không tồn tại nhập tài khoản khác (账号不存在，请再输入账号)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUser.SelectAll();
                                txtUser.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu 网络没连上: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtApn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string apn = txtApn.Text.Trim();
                string username = txtUser.Text.Trim();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản người dùng trước khi nhập APN(请输入用户账户，然后再输入APN): ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.SelectAll();
                    txtUser.Focus();
                    return;
                }
                string text = apn.Split(';')[0];
                if (text.Length != 9)
                {
                    MessageBox.Show("Mã APN phải có đúng 9 ký tự(APN码必须是9个字符)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApn.SelectAll();
                    txtApn.Focus();
                    return;
                }
                try
                {
                    using (SqlConnection conn = new SqlConnection(PMPMES))
                    {
                        conn.Open();
                        string query = "SELECT TOP 1 short_apn FROM packing_info WHERE short_apn = @apn";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@apn", text);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtApn.Text = text;
                                txtApn.Enabled = false;
                                txtSn.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Mã APN " + text + " không đúng vui lòng nhập lại mã APN (APN码不正确，请重新输入)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtApn.SelectAll();
                                txtApn.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu 网络没连上: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEEEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string eeee = txtEEEE.Text.Trim();
                string username = txtUser.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Vui lòng nhập APN trước khi nhập EEEE(请输入APN，然后再输入EEEE): ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEEEE.SelectAll();
                    txtEEEE.Focus();
                    return;
                }
                string[] parts = eeee.Split(';');
                if (parts.Length < 2 || parts[1].Length < 18)
                {
                    MessageBox.Show("Định dạng chuỗi không hợp lệ hoặc quá ngắn(格式错误或长度不足)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEEEE.SelectAll();
                    txtEEEE.Focus();
                    return;
                }

                string fullCode = parts[1];
                string text = fullCode.Substring(11);

                if (text.Length != 7)
                {
                    MessageBox.Show("Mã EEEE phải có đúng 7 ký tự(APN码必须是7个字符)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEEEE.SelectAll();
                    txtEEEE.Focus();
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(PMPMES))
                    {
                        conn.Open();
                        string query = "SELECT TOP 1 eeee FROM packing_info WHERE eeee = @eeee";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eeee", text);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtEEEE.Text = text;
                                txtEEEE.Enabled = false;
                                txtSn.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Mã APN " + text + " không đúng vui lòng nhập lại mã EEEE (EEEE码不正确，请重新输入)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtApn.SelectAll();
                                txtApn.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu 网络没连上: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string sn = txtSn.Text.Trim().ToUpper();
                string apn = txtApn.Text.Trim();
                string eeee = txtEEEE.Text.Trim();
                string username = txtUser.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản người dùng trước khi quét mã SN (请先输入用户账号, 然后再扫描SN)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(apn))
                {
                    MessageBox.Show("Vui lòng nhập APN trước khi quét SN (请先输入APN，然后再扫描SN)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(eeee))
                {
                    MessageBox.Show("Vui lòng nhập EEEE trước khi quét SN (请先输入APN，然后再扫描SN)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEEEE.Focus();
                    return;
                }
                if (sn.Length != 28)
                {
                    string errorMessage = "Mã SN phải có đúng 28 ký tự, ký tự vừa nhập: "+ sn +"";
                    //MessageBox.Show("Mã SN phải có đúng 28 ký tự (SN码必须正好有28个字符)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowPasswordForm(errorMessage);
                    return;
                }
                try
                {
                    string snPrefix = sn.Split(';')[0];
                    if (snPrefix != apn)
                    {
                        string errorMessage = "Mã " + sn + " : không khớp với APN : " + apn;
                        //MessageBox.Show("Mã " + sn + " : không khớp với APN : " + apn, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowPasswordForm(errorMessage);
                        return;
                    }
                    string snSuffix = sn.Substring(sn.Length - 7);
                    string eeeeSuffix = txtEEEE.Text.Trim();
                    if (snSuffix != eeeeSuffix)
                    {
                        string errorMessage = "Mã SN không khớp với mã EEEE: SN kết thúc bằng " + snSuffix + " vui lòng xem lại tem SN xác nhận có cùng quy cách";
                        ShowPasswordForm(errorMessage);
                        return;
                    }
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        //string checkQuery = "SELECT COUNT(1) FROM sn WHERE sn = @sn";
                        //using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        //{
                        //    checkCmd.Parameters.AddWithValue("@sn", sn);
                        //    int exists = (int)checkCmd.ExecuteScalar();
                        //    if (exists > 0)
                        //    {
                        //        string errorMessage = "Đã Quét Trùng " + sn + " Nhập Mật Khẩu Để Mở Khóa";
                        //        LogDuplicateSn(sn);
                        //        ShowPasswordForm(errorMessage);
                        //        return;
                        //    }
                        //}

                        string checkQuery = "SELECT COUNT(1) AS Count, MAX(create_time) AS LastScanTime FROM sn WHERE sn = @sn";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@sn", sn);
                            using (SqlDataReader reader = checkCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int exists = reader.GetInt32(0);
                                    if (exists > 0)
                                    {
                                        DateTime? lastScanTime = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1);
                                        string scanTimeMessage = lastScanTime.HasValue ? lastScanTime.Value.ToString("HH:mm:ss:fff dd-MM-yyyy") : "";
                                        string errorMessage = "Đã Quét Trùng " + sn + " thời gian đã quét "+ scanTimeMessage + " Nhập Mật Khẩu Để Mở Khóa";
                                        LogDuplicateSn(sn);
                                        ShowPasswordForm(errorMessage);
                                        return;
                                    }
                                }
                            }
                        }

                        string insertQuery = @"INSERT INTO sn (sn, user_id, machine_id, create_time) VALUES (@sn, @user_id, @machine_id, GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@sn", sn);
                            cmd.Parameters.AddWithValue("@user_id", username);
                            cmd.Parameters.AddWithValue("@machine_id", machineId);
                            cmd.ExecuteNonQuery();

                            // Update counters
                            totalCountall++;
                            dailyCount++;
                            countersNeedUpdate = true;

                            txtSn.Clear();
                            txtSn.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xử lý SN(处理SN码时出错): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm ghi log SN trùng
        private void LogDuplicateSn(string sn)
        {
            string username = txtUser.Text.Trim();
            try
            {
                string logDirectory = Path.Combine("D:\\logsn", DateTime.Now.ToString("yyyyMMdd"));
                Directory.CreateDirectory(logDirectory);
                string safeFileName = sn.Replace(";", "_").Replace(":", "_");
                string logFilePath = Path.Combine(logDirectory, safeFileName + ".txt");
                string logContent = string.Format("{0:yyyy-MM-dd HH:mm:ss}, {1}, {2}, {3}", DateTime.Now, sn, username, machineId);
                if (File.Exists(logFilePath) && new FileInfo(logFilePath).Length > 0)
                {
                    logContent = Environment.NewLine + logContent;
                }

                File.AppendAllText(logFilePath, logContent + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi ghi log: " + ex.Message);
            }
        }

        private void ShowPasswordForm(string errorMessage)
        {
            using (PasswordForm passwordForm = new PasswordForm(errorMessage))
            {
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    if (passwordForm.IsPasswordCorrect)
                    {
                        txtSn.Clear();
                        txtSn.Focus();
                    }
                    else
                    {
                        txtSn.SelectAll();
                        txtSn.Focus();
                    }
                }
                else
                {
                    txtSn.SelectAll();
                    txtSn.Focus();
                }
            }
        }

        private void searchSn_Click(object sender, EventArgs e)
        {
            snSearch snForm = new snSearch();
            snForm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printCarton printForm = new printCarton();
            printForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.Enabled = true;
            txtUser.Focus();
            txtApn.Enabled = false;
            txtApn.Text = "";
            txtEEEE.Enabled = false;
            txtEEEE.Text = "";
            txtSn.Enabled = false;
            txtSn.Text = "";
        }

        private void btnApn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Enabled = true;
                txtUser.Focus();
                txtApn.Enabled = false;
                txtApn.Text = "";
                txtEEEE.Enabled = false;
                txtEEEE.Text = "";
                txtSn.Enabled = false;
                txtSn.Text = "";
            }
            else
            {
                txtUser.Enabled = false;
                txtApn.Focus();
                txtApn.Enabled = true;
                txtApn.Text = "";
                txtEEEE.Enabled = false;
                txtEEEE.Text = "";
                txtSn.Enabled = false;
                txtSn.Text = "";
            }
        }

        private void btnEEEE_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Enabled = true;
                txtUser.Focus();
                txtApn.Enabled = false;
                txtApn.Text = "";
                txtSn.Enabled = false;
                txtSn.Text = "";
            }
            if (txtApn.Text == "")
            {
                txtUser.Enabled = true;
                txtUser.Focus();
                txtApn.Enabled = true;
                txtApn.Text = "";
                txtEEEE.Enabled = false;
                txtEEEE.Text = "";
                txtSn.Enabled = false;
                txtSn.Text = "";
            }
            else
            {
                txtUser.Enabled = false;
                txtApn.Enabled = false;
                //txtApn.Text = "";
                txtEEEE.Enabled = true;
                txtEEEE.Text = "";
                txtEEEE.Focus();
                txtSn.Enabled = false;
                txtSn.Text = "";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            autoUpdateTimer.Stop();
            autoUpdateTimer.Dispose();
            debounceTimer.Stop();
            debounceTimer.Dispose();
        }

        private void APNsearch_Click(object sender, EventArgs e)
        {
            APNSearch APNSearch = new APNSearch();
            APNSearch.Show();
        }

        private void APNall_Click(object sender, EventArgs e)
        {
            APNall APNall = new APNall();
            APNall.Show();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtUser.Text.Trim();
                if (!string.IsNullOrEmpty(username))
                {
                    txtApn.Enabled = true;
                    txtApn.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản trước khi quét SN!");
                    txtApn.Focus();
                }
                e.Handled = true;
            }
        }

        private void txtApn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string apn = txtApn.Text.Trim();
                if (!string.IsNullOrEmpty(apn))
                {
                    txtEEEE.Enabled = true;
                    txtEEEE.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã APN khi quét SN!");
                    txtApn.Focus();
                }
                e.Handled = true;
            }
        }

        private void print_zuzhuang_Click(object sender, EventArgs e)
        {
            printzuzhuang printForm = new printzuzhuang();
            printForm.Show();
        }

        private void txtEEEE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string apn = txtApn.Text.Trim();
                if (!string.IsNullOrEmpty(apn))
                {
                    txtSn.Enabled = true;
                    txtSn.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã EEEE khi quét SN!");
                    txtEEEE.Focus();
                }
                e.Handled = true;
            }
        }

    }
}