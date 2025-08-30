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
using BarTender;
using BtApp = BarTender.Application;

namespace scanSN
{
    public partial class printzuzhuang : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CMDB"].ConnectionString;
        private string PMPMES = ConfigurationManager.ConnectionStrings["PMPMES"].ConnectionString;
        private Format btFormat;
        private BtApp btApp;
        public printzuzhuang()
        {
            InitializeComponent();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtUser.Text.Trim();
                if (!string.IsNullOrEmpty(username))
                {
                    textBox7.Enabled = true;
                    textBox7.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản trước khi quét SN!");
                    textBox7.Focus();
                }
                e.Handled = true;
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
                                textBox7.Focus();
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = textBox7.Text.Trim();
                if (string.IsNullOrWhiteSpace(input) || !input.Contains(";"))
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox7.SelectAll();
                    textBox7.Focus();
                    return;
                }

                string apn = input.Split(';')[0];
                string filePath = @"F:\\MES\\PrintFile\\packing_info.txt";
                string header = "color,spec,lag,nw,gw";
                string data = "";

                try
                {
                    using (SqlConnection connection = new SqlConnection(PMPMES))
                    {
                        connection.Open();
                        string query = "SELECT color, spec, lag, nw, gw FROM packing_info WHERE apn = @apn";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@apn", apn);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    color.Text = reader["color"].ToString();
                                    spec.Text = reader["spec"].ToString();
                                    lag.Text = reader["lag"].ToString();
                                    nw.Text = reader["nw"].ToString();
                                    gw.Text = reader["gw"].ToString();
                                    data = string.Join(",", new string[] { color.Text, spec.Text, lag.Text, nw.Text, gw.Text });
                                }
                                else
                                {
                                    label9.Text = "Không tìm thấy dữ liệu cho APN: " + apn;
                                    color.Text = "N/A";
                                    spec.Text = "N/A";
                                    lag.Text = "N/A";
                                    nw.Text = "N/A";
                                    gw.Text = "N/A";
                                    data = "N/A,N/A,N/A,N/A,N/A";
                                }
                            }
                        }
                    }

                    try
                    {
                        string logDirectory = Path.GetDirectoryName(filePath);
                        if (!Directory.Exists(logDirectory))
                        {
                            Directory.CreateDirectory(logDirectory);
                        }
                        File.WriteAllText(filePath, header + Environment.NewLine + data + Environment.NewLine, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    data = "N/A,N/A,N/A,N/A,N/A";
                    try
                    {
                        string logDirectory = Path.GetDirectoryName(filePath);
                        if (!Directory.Exists(logDirectory))
                        {
                            Directory.CreateDirectory(logDirectory);
                        }
                        File.WriteAllText(filePath, header + Environment.NewLine + data + Environment.NewLine, Encoding.UTF8);
                    }
                    catch (Exception fileEx)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + fileEx.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                File.WriteAllText(filePath, header + Environment.NewLine + data + Environment.NewLine, Encoding.UTF8);
                string bartenderFilePath = "F:\\MES\\PrintFile\\packing_info.btw";
                FileToBarCodePrint(bartenderFilePath, "");
                e.Handled = true;
                textBox7.SelectAll();
                textBox7.Focus();
            }
        }

        private void FileToBarCodePrint(string pFilePath, string printName)
        {
            if (btApp == null)
            {
                btApp = new BtApp();
            }

            try
            {
                btFormat = btApp.Formats.Open(pFilePath, false, "");
                //btFormat.PrintSetup.IdenticalCopiesOfLabel = Convert.ToInt32(TextBox1.Text);
                btFormat.PrintOut(false, false);
                btFormat.Close(BtSaveOptions.btDoNotSaveChanges);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in tem - Liên hệ IT: " + ex.Message);
            }
        }
    }
}
