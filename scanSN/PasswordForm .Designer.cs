namespace scanSN
{
    partial class PasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(299, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(890, 30);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nhập Mật Khẩu(输入密码）：";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(17, 32);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(432, 25);
            this.lblMessage.TabIndex = 50;
            this.lblMessage.Text = "Đã Quét Trùng SN Nhập Mật Khẩu Để Mở Khóa";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 134);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblMessage;
    }
}