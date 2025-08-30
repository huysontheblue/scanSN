using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarTender;
using BtApp = BarTender.Application;
using System.IO;

namespace scanSN
{
    public partial class printCarton : Form
    {
        private Format btFormat;
        private BtApp btApp;
        public printCarton()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\MES\\zuzhuang.txt";
            string header = "dc,id";
            string data = string.Join(",", new string[] { dc.Text, id.Text });

            try
            {
                if (string.IsNullOrWhiteSpace(txtSL.Text))
                {
                    MessageBox.Show("数量不能为空 - Số lượng không được để trống");
                    return;
                }

                File.WriteAllText(filePath, header + Environment.NewLine + data + Environment.NewLine, Encoding.UTF8);
                //File.WriteAllText(filePath, header + Environment.NewLine + data + Environment.NewLine, Encoding.UTF8);
                string bartenderFilePath = "D:\\MES\\" + ComboBox1.Text.Split('-')[0] + ".btw";
                FileToBarCodePrint(bartenderFilePath, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file 联系IT - Liên hệ IT: " + ex.Message);
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
                btFormat.PrintSetup.IdenticalCopiesOfLabel = Convert.ToInt32(txtSL.Text);
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
