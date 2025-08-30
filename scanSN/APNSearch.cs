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

namespace scanSN
{
    public partial class APNSearch : Form
    {
        private string machineId;
        public APNSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            machineId = GetMachineId();
        }

        private string GetMachineId()
        {
            return Environment.MachineName;
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMDB"].ConnectionString))
                {
                    conn.Open();
                    string query = @"WITH ParsedSN AS (
                                    SELECT RIGHT(SUBSTRING(sn, CHARINDEX(';', sn) + 1, LEN(sn)), 7) AS eeee
                                    FROM sn
                                    WHERE CHARINDEX(';', sn) > 0
                                    AND machine_id = @machine_id
                                )
                                SELECT 
                                    eeee,
                                    CASE eeee
                                        WHEN '0000R3G' THEN 'WS-L'
                                        WHEN '0000R3F' THEN 'WS-M'
                                        WHEN '0000R30' THEN 'NS-L'
                                        WHEN '0000R2Z' THEN 'NS-M'
                                        WHEN '0000TB7' THEN 'NS-M'
                                        WHEN '0000TB8' THEN 'NS-M'
                                        ELSE 'Unknown'
                                    END AS Mapping,
                                    COUNT(*) AS TotalScanned
                                FROM ParsedSN
                                GROUP BY eeee";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@machine_id", machineId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lblTotalR30.Text = "0";
                            lblTotalR3G.Text = "0";
                            lblTotalR2Z.Text = "0";
                            lblTotalR3F.Text = "0";
                            lblTotalTB7.Text = "0";
                            lblTotalTB8.Text = "0";

                            while (reader.Read())
                            {
                                string eeee = reader["eeee"].ToString();
                                int totalScanned = Convert.ToInt32(reader["TotalScanned"]);

                                switch (eeee)
                                {
                                    case "0000R30":
                                        lblTotalR30.Text = totalScanned.ToString();
                                        break;
                                    case "0000R3G":
                                        lblTotalR3G.Text = totalScanned.ToString();
                                        break;
                                    case "0000R2Z":
                                        lblTotalR2Z.Text = totalScanned.ToString();
                                        break;
                                    case "0000R3F":
                                        lblTotalR3F.Text = totalScanned.ToString();
                                        break;
                                    case "0000TB7":
                                        lblTotalTB7.Text = totalScanned.ToString();
                                        break;
                                    case "0000TB8":
                                        lblTotalTB8.Text = totalScanned.ToString();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (date1.Value >= date2.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMDB"].ConnectionString))
                {
                    conn.Open();
                    string query = @"WITH ParsedSN AS (
                                    SELECT RIGHT(SUBSTRING(sn, CHARINDEX(';', sn) + 1, LEN(sn)), 7) AS sn_suffix
                                    FROM sn 
                                    WHERE CHARINDEX(';', sn) > 0 
                                    AND create_time >= @date1 AND create_time < @date2
                                    AND machine_id = @machine_id
                                )
                                SELECT 
                                    sn_suffix AS eeee,
                                    CASE sn_suffix
                                        WHEN '0000R3G' THEN 'WS-L'
                                        WHEN '0000R3F' THEN 'WS-M'
                                        WHEN '0000R30' THEN 'NS-L'
                                        WHEN '0000R2Z' THEN 'NS-M'
                                        WHEN '0000TB7' THEN 'NS-M'
                                        WHEN '0000TB8' THEN 'NS-M'
                                        ELSE 'Unknown'
                                    END AS Mapping,
                                    COUNT(*) AS TotalScanned
                                FROM ParsedSN
                                GROUP BY sn_suffix";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date1", date1.Value);
                        cmd.Parameters.AddWithValue("@date2", date2.Value);
                        cmd.Parameters.AddWithValue("@machine_id", machineId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lblTotalR30.Text = "0";
                            lblTotalR3G.Text = "0";
                            lblTotalR2Z.Text = "0";
                            lblTotalR3F.Text = "0";
                            lblTotalTB7.Text = "0";
                            lblTotalTB8.Text = "0";

                            while (reader.Read())
                            {
                                string eeee = reader["eeee"].ToString();
                                int totalScanned = Convert.ToInt32(reader["TotalScanned"]);
                                switch (eeee)
                                {
                                    case "0000R30":
                                        lblTotalR30.Text = totalScanned.ToString();
                                        break;
                                    case "0000R3G":
                                        lblTotalR3G.Text = totalScanned.ToString();
                                        break;
                                    case "0000R2Z":
                                        lblTotalR2Z.Text = totalScanned.ToString();
                                        break;
                                    case "0000R3F":
                                        lblTotalR3F.Text = totalScanned.ToString();
                                        break;
                                    case "0000TB7":
                                        lblTotalTB7.Text = totalScanned.ToString();
                                        break;
                                    case "0000TB8":
                                        lblTotalTB8.Text = totalScanned.ToString();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
