using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace scanSN
{
    public partial class PasswordForm : Form
    {
        public string Password { get; private set; }
        public bool IsPasswordCorrect { get; private set; }
        private const string CorrectPassword = "2410";
        private bool isDragging = false;
        private Point lastCursorPosition;
        public PasswordForm(string errorMessage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            lblMessage.Text = errorMessage;
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string username = txtPassword.Text.Trim();
                if (txtPassword.Text == CorrectPassword)
                {
                    IsPasswordCorrect = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng - 密码不对 ", "Lỗi - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }
        }

        private void PasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void PasswordForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void PasswordForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - lastCursorPosition.X;
                this.Top += e.Y - lastCursorPosition.Y;
            }
        }
    }
}