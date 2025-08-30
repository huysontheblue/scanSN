namespace scanSN
{
    partial class snSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snSearch));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.btnSearchSN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 43;
            this.label4.Text = "Dữ Liệu SN（SN号）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày Kết Thúc：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày Bắt Đầu：";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(1148, 139);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 32);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(899, 80);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(152, 32);
            this.btnAll.TabIndex = 37;
            this.btnAll.Text = "Tìm Kiếm Tất Cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtSn
            // 
            this.txtSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSn.Location = new System.Drawing.Point(175, 82);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(660, 30);
            this.txtSn.TabIndex = 36;
            this.txtSn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSn_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "SN 号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 388);
            this.dataGridView1.TabIndex = 44;
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(152, 604);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(73, 17);
            this.labelcount.TabIndex = 46;
            this.labelcount.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Số Lượng Sản Phẩm:";
            // 
            // date1
            // 
            this.date1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Checked = false;
            this.date1.CustomFormat = "yyyy/MM/dd HH：mm:ss";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(175, 149);
            this.date1.Margin = new System.Windows.Forms.Padding(4);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(308, 22);
            this.date1.TabIndex = 48;
            // 
            // date2
            // 
            this.date2.Checked = false;
            this.date2.CustomFormat = "yyyy/MM/dd HH：mm:ss";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(743, 149);
            this.date2.Margin = new System.Windows.Forms.Padding(4);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(308, 22);
            this.date2.TabIndex = 49;
            // 
            // btnSearchSN
            // 
            this.btnSearchSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSN.Location = new System.Drawing.Point(1148, 80);
            this.btnSearchSN.Name = "btnSearchSN";
            this.btnSearchSN.Size = new System.Drawing.Size(152, 32);
            this.btnSearchSN.TabIndex = 50;
            this.btnSearchSN.Text = "Tìm Theo SN";
            this.btnSearchSN.UseVisualStyleBackColor = true;
            this.btnSearchSN.Click += new System.EventHandler(this.btnSearchSN_Click);
            // 
            // snSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 635);
            this.Controls.Add(this.btnSearchSN);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "snSearch";
            this.Text = "Tìm Kiếm SN(SN查询）";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker date1;
        internal System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button btnSearchSN;
    }
}