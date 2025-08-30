namespace scanSN
{
    partial class printzuzhuang
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
            this.btnUser = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.spec = new System.Windows.Forms.TextBox();
            this.lag = new System.Windows.Forms.TextBox();
            this.nw = new System.Windows.Forms.TextBox();
            this.gw = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(838, 94);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(160, 30);
            this.btnUser.TabIndex = 56;
            this.btnUser.Text = "Làm Mới(刷新）";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(290, 96);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(521, 30);
            this.txtUser.TabIndex = 55;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "User_ID(工号):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "Print Thùng Nhỏ（打印小外箱）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "spec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "lag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "NW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "GW";
            // 
            // color
            // 
            this.color.Enabled = false;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(158, 172);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(192, 30);
            this.color.TabIndex = 63;
            // 
            // spec
            // 
            this.spec.Enabled = false;
            this.spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.Location = new System.Drawing.Point(158, 237);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(192, 30);
            this.spec.TabIndex = 64;
            // 
            // lag
            // 
            this.lag.Enabled = false;
            this.lag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lag.Location = new System.Drawing.Point(158, 300);
            this.lag.Name = "lag";
            this.lag.Size = new System.Drawing.Size(192, 30);
            this.lag.TabIndex = 65;
            // 
            // nw
            // 
            this.nw.Enabled = false;
            this.nw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nw.Location = new System.Drawing.Point(619, 172);
            this.nw.Name = "nw";
            this.nw.Size = new System.Drawing.Size(192, 30);
            this.nw.TabIndex = 66;
            // 
            // gw
            // 
            this.gw.Enabled = false;
            this.gw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gw.Location = new System.Drawing.Point(619, 234);
            this.gw.Name = "gw";
            this.gw.Size = new System.Drawing.Size(192, 30);
            this.gw.TabIndex = 67;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(290, 394);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(521, 30);
            this.textBox7.TabIndex = 69;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quét mã vào đây";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Đang in tem! Mời in mã tiếp theo";
            // 
            // printzuzhuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 555);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.gw);
            this.Controls.Add(this.nw);
            this.Controls.Add(this.lag);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.color);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Name = "printzuzhuang";
            this.Text = "Print Tem Thùng Nhỏ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.TextBox lag;
        private System.Windows.Forms.TextBox nw;
        private System.Windows.Forms.TextBox gw;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}