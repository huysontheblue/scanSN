namespace scanSN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchSn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.APNsearch = new System.Windows.Forms.ToolStripMenuItem();
            this.APNall = new System.Windows.Forms.ToolStripMenuItem();
            this.print_zuzhuang = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApn = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApn = new System.Windows.Forms.Button();
            this.labelKhay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtEEEE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEEEE = new System.Windows.Forms.Button();
            this.eEEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchSn,
            this.btnPrint,
            this.APNsearch,
            this.APNall,
            this.print_zuzhuang,
            this.eEEEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchSn
            // 
            this.searchSn.Name = "searchSn";
            this.searchSn.Size = new System.Drawing.Size(174, 24);
            this.searchSn.Text = "Tìm Kiếm SN（SN查询）";
            this.searchSn.Click += new System.EventHandler(this.searchSn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(172, 24);
            this.btnPrint.Text = "Print Carton(打印外箱）";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // APNsearch
            // 
            this.APNsearch.Name = "APNsearch";
            this.APNsearch.Size = new System.Drawing.Size(218, 24);
            this.APNsearch.Text = "Tìm APN Theo Từng Máy Tính";
            this.APNsearch.Click += new System.EventHandler(this.APNsearch_Click);
            // 
            // APNall
            // 
            this.APNall.Name = "APNall";
            this.APNall.Size = new System.Drawing.Size(144, 24);
            this.APNall.Text = "Tìm ALL Theo APN";
            this.APNall.Click += new System.EventHandler(this.APNall_Click);
            // 
            // print_zuzhuang
            // 
            this.print_zuzhuang.Name = "print_zuzhuang";
            this.print_zuzhuang.Size = new System.Drawing.Size(160, 24);
            this.print_zuzhuang.Text = "Print Tem Thùng Nhỏ";
            this.print_zuzhuang.Click += new System.EventHandler(this.print_zuzhuang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "Quét SN（扫描SN号）";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(325, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(521, 30);
            this.txtUser.TabIndex = 43;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "User_ID(工号):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(152, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 48);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tổng Số Lượng Đã Quét :";
            // 
            // txtSn
            // 
            this.txtSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSn.Location = new System.Drawing.Point(325, 367);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(521, 30);
            this.txtSn.TabIndex = 38;
            this.txtSn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "SN（序号):";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelCount.Location = new System.Drawing.Point(756, 620);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(86, 48);
            this.labelCount.TabIndex = 45;
            this.labelCount.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "APN:";
            // 
            // txtApn
            // 
            this.txtApn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApn.Location = new System.Drawing.Point(325, 212);
            this.txtApn.Name = "txtApn";
            this.txtApn.Size = new System.Drawing.Size(521, 30);
            this.txtApn.TabIndex = 47;
            this.txtApn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApn_KeyDown);
            this.txtApn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApn_KeyPress);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDay.Location = new System.Drawing.Point(760, 474);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(86, 48);
            this.labelDay.TabIndex = 49;
            this.labelDay.Text = "200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(156, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 48);
            this.label7.TabIndex = 48;
            this.label7.Text = "Số Lượng Mã Quét / Ngày :";
            // 
            // btnApn
            // 
            this.btnApn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApn.Location = new System.Drawing.Point(908, 212);
            this.btnApn.Name = "btnApn";
            this.btnApn.Size = new System.Drawing.Size(160, 30);
            this.btnApn.TabIndex = 50;
            this.btnApn.Text = "Làm Mới(刷新）";
            this.btnApn.UseVisualStyleBackColor = true;
            this.btnApn.Click += new System.EventHandler(this.btnApn_Click);
            // 
            // labelKhay
            // 
            this.labelKhay.AutoSize = true;
            this.labelKhay.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhay.ForeColor = System.Drawing.Color.Green;
            this.labelKhay.Location = new System.Drawing.Point(759, 546);
            this.labelKhay.Name = "labelKhay";
            this.labelKhay.Size = new System.Drawing.Size(86, 48);
            this.labelKhay.TabIndex = 52;
            this.labelKhay.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(155, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(470, 48);
            this.label8.TabIndex = 51;
            this.label8.Text = "Số Lượng Thùng / Ngày :";
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(908, 129);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(160, 30);
            this.btnUser.TabIndex = 53;
            this.btnUser.Text = "Làm Mới(刷新）";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtEEEE
            // 
            this.txtEEEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEEEE.Location = new System.Drawing.Point(325, 287);
            this.txtEEEE.Name = "txtEEEE";
            this.txtEEEE.Size = new System.Drawing.Size(521, 30);
            this.txtEEEE.TabIndex = 55;
            this.txtEEEE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEEEE_KeyDown);
            this.txtEEEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEEEE_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "EEEE:";
            // 
            // btnEEEE
            // 
            this.btnEEEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEEEE.Location = new System.Drawing.Point(908, 285);
            this.btnEEEE.Name = "btnEEEE";
            this.btnEEEE.Size = new System.Drawing.Size(160, 30);
            this.btnEEEE.TabIndex = 56;
            this.btnEEEE.Text = "Làm Mới(刷新）";
            this.btnEEEE.UseVisualStyleBackColor = true;
            this.btnEEEE.Click += new System.EventHandler(this.btnEEEE_Click);
            // 
            // eEEEToolStripMenuItem
            // 
            this.eEEEToolStripMenuItem.Name = "eEEEToolStripMenuItem";
            this.eEEEToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.eEEEToolStripMenuItem.Text = "EEEE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 738);
            this.Controls.Add(this.btnEEEE);
            this.Controls.Add(this.txtEEEE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.labelKhay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnApn);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ScanSn(扫描SN号）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchSn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApn;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApn;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem APNsearch;
        private System.Windows.Forms.Label labelKhay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ToolStripMenuItem APNall;
        private System.Windows.Forms.ToolStripMenuItem print_zuzhuang;
        private System.Windows.Forms.TextBox txtEEEE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEEEE;
        private System.Windows.Forms.ToolStripMenuItem eEEEToolStripMenuItem;
    }
}

