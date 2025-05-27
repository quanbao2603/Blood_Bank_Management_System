using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Blood_Bank.UI
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến SQL Server
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
            LoadBloodBagData(); // Gọi hàm khi khởi động form
        }

        /// <summary>
        /// Load dữ liệu từ bảng BloodBags và hiển thị lên DataGridView
        /// </summary>
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

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewBloodBags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
