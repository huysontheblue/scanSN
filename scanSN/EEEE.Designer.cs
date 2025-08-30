namespace scanSN
{
    partial class EEEE
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
            this.btnSearchSN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchSN
            // 
            this.btnSearchSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSN.Location = new System.Drawing.Point(1124, 88);
            this.btnSearchSN.Name = "btnSearchSN";
            this.btnSearchSN.Size = new System.Drawing.Size(152, 32);
            this.btnSearchSN.TabIndex = 55;
            this.btnSearchSN.Text = "Tìm Theo SN";
            this.btnSearchSN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 54;
            this.label4.Text = "Dữ Liệu SN（SN号）";
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(875, 88);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(152, 32);
            this.btnAll.TabIndex = 53;
            this.btnAll.Text = "Tìm Kiếm Tất Cả";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // txtSn
            // 
            this.txtSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSn.Location = new System.Drawing.Point(151, 90);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(660, 30);
            this.txtSn.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "SN 号:";
            // 
            // EEEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 450);
            this.Controls.Add(this.btnSearchSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.label5);
            this.Name = "EEEE";
            this.Text = "EEEE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label5;
    }
}