namespace scanSN
{
    partial class printCarton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printCarton));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "选标签： Chọn Tem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "年月日： Nhập Ngày Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "流水码： Mã Tự Tăng(6 số):";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "出货外箱_豆灰NL-NL",
            "出货外箱_豆灰NM-NM",
            "出货外箱_豆灰WL-WL",
            "出货外箱_豆灰WM-WM"});
            this.ComboBox1.Location = new System.Drawing.Point(432, 132);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(318, 33);
            this.ComboBox1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "Print Carton(打印外箱）";
            // 
            // dc
            // 
            this.dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dc.Location = new System.Drawing.Point(432, 206);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(318, 30);
            this.dc.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "打印数量 : Số Lượng In";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(432, 282);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(318, 30);
            this.id.TabIndex = 50;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(432, 362);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(318, 30);
            this.txtSL.TabIndex = 51;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(432, 443);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(156, 49);
            this.btnIn.TabIndex = 52;
            this.btnIn.Text = "打印(In tem)";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // printCarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 553);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "printCarton";
            this.Text = "printCarton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dc;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox txtSL;
        internal System.Windows.Forms.Button btnIn;
    }
}