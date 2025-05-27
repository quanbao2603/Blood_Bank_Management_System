using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Blood_Bank.UI
{
    public partial class BloodBag : Form
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultiSubnetFailover=False";

        public BloodBag()
        {
            InitializeComponent();
            CustomizeDataGridView();
            LoadBloodBagData();
        }

        private void LoadBloodBagData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            BagID,
                            DonationID,
                            DonationDate,
                            ExpireDate,
                            DATEDIFF(DAY, GETDATE(), ExpireDate) AS DaysUntilExpire,
                            CASE 
                                WHEN DATEDIFF(DAY, GETDATE(), ExpireDate) < 0 THEN N'🔴 Đã hết hạn'
                                WHEN DATEDIFF(DAY, GETDATE(), ExpireDate) BETWEEN 0 AND 27 THEN N'⚪ Sắp hết hạn (khẩn cấp)'
                                WHEN DATEDIFF(DAY, GETDATE(), ExpireDate) BETWEEN 28 AND 42 THEN N'🟡 Sắp hết hạn (cảnh báo)'
                                ELSE N'🟢 Còn xa ngày hết hạn'
                            END AS Status
                        FROM BloodBags
                        ORDER BY ExpireDate ASC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewBloodBags.DataSource = table;

                    dataGridViewBloodBags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewBloodBags.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridViewBloodBags.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            this.BackColor = Color.FromArgb(255, 204, 204);

            dataGridViewBloodBags.BackgroundColor = Color.White;
            dataGridViewBloodBags.BorderStyle = BorderStyle.Fixed3D;

            dataGridViewBloodBags.EnableHeadersVisualStyles = false;

            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 51, 51);
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewBloodBags.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 245);
            dataGridViewBloodBags.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBloodBags.RowsDefaultCellStyle.Font = new Font("Arial", 9);

            dataGridViewBloodBags.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);

            dataGridViewBloodBags.GridColor = Color.FromArgb(255, 102, 102);
            dataGridViewBloodBags.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void dataGridViewBloodBags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBloodBags.Rows[e.RowIndex];
                Color originalColor = row.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
                dataGridViewBloodBags.Refresh();

                string bagDetails = $"Mã túi máu: {row.Cells["BagID"].Value}\n" +
                                    $"Mã hiến máu: {row.Cells["DonationID"].Value}\n" +
                                    $"Ngày hiến: {row.Cells["DonationDate"].Value}\n" +
                                    $"Ngày hết hạn: {row.Cells["ExpireDate"].Value}\n" +
                                    $"Số ngày còn lại: {row.Cells["DaysUntilExpire"].Value}\n" +
                                    $"Trạng thái: {row.Cells["Status"].Value}";

                MessageBox.Show(bagDetails, "Thông tin túi máu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Threading.Tasks.Task.Delay(500).ContinueWith(_ =>
                {
                    row.DefaultCellStyle.BackColor = originalColor;
                    this.Invoke((MethodInvoker)delegate { dataGridViewBloodBags.Refresh(); });
                });
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}