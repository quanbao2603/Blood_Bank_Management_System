using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.UI
{
    public partial class BloodBag : Form
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultiSubnetFailover=False";

        public BloodBag()
        {
            InitializeComponent();
            CustomizeFormHeader();
            CustomizeDataGridView();
            LoadBloodBagData();
            dataGridViewBloodBags.CellFormatting += dataGridViewBloodBags_CellFormatting;
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

        private void CustomizeFormHeader()
        {
            Label title = new Label
            {
                Text = "BloodBag",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(220, 53, 69),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60
            };

            this.Controls.Add(title);
            title.BringToFront();
        }

        private void CustomizeDataGridView()
        {
            this.BackColor = Color.WhiteSmoke;

            dataGridViewBloodBags.BackgroundColor = Color.White;
            dataGridViewBloodBags.BorderStyle = BorderStyle.None;
            dataGridViewBloodBags.GridColor = Color.LightGray;

            dataGridViewBloodBags.EnableHeadersVisualStyles = false;
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewBloodBags.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewBloodBags.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewBloodBags.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBloodBags.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewBloodBags.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            dataGridViewBloodBags.DefaultCellStyle.Padding = new Padding(5);
            dataGridViewBloodBags.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridViewBloodBags.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void dataGridViewBloodBags_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBloodBags.Columns[e.ColumnIndex].Name == "Status")
            {
                var status = e.Value?.ToString();
                var row = dataGridViewBloodBags.Rows[e.RowIndex];

                if (status != null)
                {
                    if (status.Contains("Đã hết hạn"))
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    else if (status.Contains("khẩn cấp"))
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                    else if (status.Contains("cảnh báo"))
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204); 
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dataGridViewBloodBags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBloodBags.Rows[e.RowIndex];
                Color originalColor = row.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193); // Màu hồng highlight
                dataGridViewBloodBags.Refresh();

                string bagDetails = $"Mã túi máu: {row.Cells["BagID"].Value}\n" +
                                    $"Mã hiến máu: {row.Cells["DonationID"].Value}\n" +
                                    $"Ngày hiến: {row.Cells["DonationDate"].Value}\n" +
                                    $"Ngày hết hạn: {row.Cells["ExpireDate"].Value}\n" +
                                    $"Số ngày còn lại: {row.Cells["DaysUntilExpire"].Value}\n" +
                                    $"Trạng thái: {row.Cells["Status"].Value}";

                MessageBox.Show(bagDetails, "Thông tin túi máu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Task.Delay(500).ContinueWith(_ =>
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
