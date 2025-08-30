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
using Microsoft.Office.Interop.Excel;
using WinForms = System.Windows.Forms;

namespace scanSN
{
    public partial class snSearch : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CMDB"].ConnectionString;

        public snSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DateTime fromDate = date1.Value;
            DateTime toDate = date2.Value;
            if (fromDate >= toDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            txtSn.Text = "";
            LoadAllData(fromDate, toDate);
        }

        private void LoadAllData(DateTime? fromDate = null, DateTime? toDate = null)
        {
            try
            {
                string query = @"SELECT sn.sn AS 'SN(序号)', m.msah04 AS 'Tên(名字)', 
                        sn.user_id AS 'Mã Nhân Viên(工号）', sn.create_time AS 'Thời Gian(时间)',sn.machine_id AS 'Computer Name(Máy Tính)'
                        FROM sn sn JOIN msah m ON sn.user_id = m.msah03 WHERE 1=1";

                if (fromDate != null)
                {
                    query += " AND sn.create_time >= @fromDate";
                }
                if (toDate != null)
                {
                    query += " AND sn.create_time <= @toDate";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (fromDate != null)
                    {
                        command.Parameters.AddWithValue("@fromDate", fromDate.Value);
                    }
                    if (toDate != null)
                    {
                        command.Parameters.AddWithValue("@toDate", toDate.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    //DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    ConfigureDataGridView();
                    UpdateRowCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRowCount()
        {
            int rowCount = 0;
            if (dataGridView1 != null && dataGridView1.Rows != null)
            {
                if (dataGridView1.DataSource is System.Data.DataTable)
                {
                    rowCount = dataGridView1.Rows.Count;
                }
            }
            if (labelcount != null)
            {
                labelcount.Text = rowCount.ToString();
            }
        }

        private void ConfigureDataGridView()
        {
            if (dataGridView1.Columns.Count == 0) return;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn(); sttColumn.Name = "STT"; sttColumn.HeaderText = "STT"; sttColumn.Width = 50; sttColumn.ReadOnly = true; dataGridView1.Columns.Insert(0, sttColumn);
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "SN", DataPropertyName = "SN(序号)", HeaderText = "SN(序号)", Width = 240, ReadOnly = true });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "CartonId", DataPropertyName = "Thùng(外箱）", HeaderText = "Thùng (外箱)", Width = 170, ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "msah04", DataPropertyName = "Tên(名字)", HeaderText = "Tên (名字)", Width = 200, ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "user_id", DataPropertyName = "Mã Nhân Viên(工号）", HeaderText = "Mã NV (工号)", Width = 150, ReadOnly = true });           
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "create_time", DataPropertyName = "Thời Gian(时间)",HeaderText = "Thời Gian (时间)",Width = 150,ReadOnly = true,DefaultCellStyle = new DataGridViewCellStyle(){Format = "yyyy-MM-dd HH:mm:ss.fff",Alignment = DataGridViewContentAlignment.MiddleCenter}});
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "machine_id", DataPropertyName = "Computer Name(Máy Tính)", HeaderText = "Computer Name(Máy Tính)", Width = 200, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle() {Alignment = DataGridViewContentAlignment.MiddleCenter } });
            UpdateRowNumbers();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            //dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Refresh();
        }

        private void UpdateRowNumbers()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["STT"].Value = row.Index + 1;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Workbook workbook = null;
            Worksheet worksheet = null;
    
            try
            {
                // Kiểm tra dữ liệu
                if (dataGridView1.Rows.Count <= 1)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                    return;
                }
                // Khởi tạo Excel
                excel = new Microsoft.Office.Interop.Excel.Application();
                workbook = excel.Workbooks.Add();
                worksheet = (Worksheet)workbook.Sheets[1];
                excel.Visible = true;
                // Xuất tiêu đề cột
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Range headerCell = (Range)worksheet.Cells[1, i + 1];
                    headerCell.NumberFormat = "@";
                    headerCell.Value2 = dataGridView1.Columns[i].HeaderText;
                    headerCell.Font.Bold = true;
                    headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                // Xuất dữ liệu
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range dataCell = (Range)worksheet.Cells[i + 2, j + 1];
                        dataCell.NumberFormat = "@";
                        object cellValue = dataGridView1[j, i].Value;
                        dataCell.Value2 = cellValue != null ? cellValue.ToString() : "";
                    }
                }
                // Tự động điều chỉnh độ rộng cột
                worksheet.Columns.AutoFit();
                // Lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "Export_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);           
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: {ex.Message}\n\nChi tiết: {ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng tài nguyên
                if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                }
                if (excel != null)
                {
                    excel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                }
        
                // Dọn dẹp các đối tượng COM
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void txtSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string sn = txtSn.Text.Trim();
                if (string.IsNullOrEmpty(sn))
                {
                    MessageBox.Show("Vui lòng nhập mã SN", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string checkQuery;
                    bool isShortCode = sn.Length == 7 && sn.StartsWith("0000");
                    bool isPrefixCode = sn.Contains("-") && !sn.Contains(";");
                    if (isShortCode)
                    {
                        // Tìm kiếm mã ngắn (7 ký tự cuối sau dấu ;)
                        checkQuery = @"SELECT sn.sn AS 'SN(序号)', m.msah04 AS 'Tên(名字)', 
                                      sn.user_id AS 'Mã Nhân Viên(工号）', sn.create_time AS 'Thời Gian(时间)',sn.machine_id AS 'Computer Name(Máy Tính)'
                                      FROM sn sn INNER JOIN msah m ON sn.user_id = m.msah03 
                                      WHERE RIGHT(SUBSTRING(sn.sn, CHARINDEX(';', sn.sn) + 1, LEN(sn.sn)), 7) = @sn";
                    }
                    else if (isPrefixCode)
                    {
                        // Tìm kiếm chuỗi đầu trước dấu ;
                        checkQuery = @"SELECT sn.sn AS 'SN(序号)', m.msah04 AS 'Tên(名字)', 
                                      sn.user_id AS 'Mã Nhân Viên(工号）', sn.create_time AS 'Thời Gian(时间)',sn.machine_id AS 'Computer Name(Máy Tính)'
                                      FROM sn sn INNER JOIN msah m ON sn.user_id = m.msah03 
                                      WHERE SUBSTRING(sn.sn, 1, CHARINDEX(';', sn.sn) - 1) = @sn";
                    }
                    else
                    {
                        // Tìm kiếm chuỗi đầy đủ
                        checkQuery = @"SELECT sn.sn AS 'SN(序号)', m.msah04 AS 'Tên(名字)', 
                                      sn.user_id AS 'Mã Nhân Viên(工号）', sn.create_time AS 'Thời Gian(时间)',sn.machine_id AS 'Computer Name(Máy Tính)'
                                      FROM sn sn INNER JOIN msah m ON sn.user_id = m.msah03 
                                      WHERE sn.sn =@sn";
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(checkQuery, connection);
                        command.Parameters.AddWithValue("@sn", sn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                            ConfigureDataGridView();
                            UpdateRowNumbers();
                            UpdateRowCount();
                        }
                        else
                        {
                            labelcount.Text = "0";
                            MessageBox.Show("Không tìm thấy SN "+sn+" trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtSn.SelectAll();
                }
            }
        }

        private void btnSearchSN_Click(object sender, EventArgs e)
        {
            DateTime fromDate = date1.Value;
            DateTime toDate = date2.Value;
            if (fromDate >= toDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            //txtSn.Text = "";
            LoadAllSN(fromDate, toDate);
        }

        private void LoadAllSN(DateTime? fromDate = null, DateTime? toDate = null)
        {
            string sn = txtSn.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(sn))
                {
                    MessageBox.Show("Vui lòng nhập mã SN", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string baseQuery = @"SELECT sn.sn AS 'SN(序号)', m.msah04 AS 'Tên(名字)', 
                    sn.user_id AS 'Mã Nhân Viên(工号）', sn.create_time AS 'Thời Gian(时间)',sn.machine_id AS 'Computer Name(Máy Tính)'
                    FROM sn sn INNER JOIN msah m ON sn.user_id = m.msah03 WHERE ";

                string searchCondition;
                // Kiểm tra định dạng chuỗi sn
                bool isShortCode = sn.Length == 7 && sn.StartsWith("0000");
                bool isPrefixCode = sn.Contains("-") && !sn.Contains(";");

                if (isShortCode)
                {
                    // Tìm kiếm mã ngắn (7 ký tự cuối sau dấu ;)
                    searchCondition = "RIGHT(SUBSTRING(sn.sn, CHARINDEX(';', sn.sn) + 1, LEN(sn.sn)), 7) = @sn";
                }
                else if (isPrefixCode)
                {
                    // Tìm kiếm chuỗi đầu trước dấu ;
                    searchCondition = "SUBSTRING(sn.sn, 1, CHARINDEX(';', sn.sn) - 1) = @sn";
                }
                else
                {
                    // Tìm kiếm chuỗi đầy đủ
                    searchCondition = "sn.sn LIKE '%' + @sn + '%'";
                }

                string query = baseQuery + searchCondition;

                // Thêm điều kiện thời gian
                if (fromDate != null)
                {
                    query += " AND sn.create_time >= @fromDate";
                }
                if (toDate != null)
                {
                    query += " AND sn.create_time <= @toDate";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@sn", sn);

                    if (fromDate != null)
                    {
                        command.Parameters.AddWithValue("@fromDate", fromDate.Value);
                    }
                    if (toDate != null)
                    {
                        command.Parameters.AddWithValue("@toDate", toDate.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                        ConfigureDataGridView();
                        UpdateRowNumbers();
                        UpdateRowCount();
                    }
                    else
                    {
                        labelcount.Text = "0";
                        MessageBox.Show("Không tìm thấy SN " + sn + " trong cơ sở dữ liệu từ " +(fromDate.HasValue ? fromDate.Value.ToShortDateString() : "bất kỳ") +" đến " + (toDate.HasValue ? toDate.Value.ToShortDateString() : "bất kỳ") + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
