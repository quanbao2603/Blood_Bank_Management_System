using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Service;
using Blood_Bank.UI;
using Blood_Bank.UI_Helper;

namespace Blood_Bank
{
    public partial class Blood_Stockcs : Form
    {
        private readonly BloodStockService _service;

        public Action<Form> FormChangeRequested { get; internal set; }

        public Blood_Stockcs()
        {
            InitializeComponent();
            _service = new BloodStockService();
            LoadBloodStock();

            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);
            DBGroupCb.SelectedIndexChanged += DBGroupCb_SelectedIndexChanged;

        }

        private void LoadBloodStock()
        {
            try
            {
                DataTable dt = _service.GetBloodStock();
                BloodStockDGV.DataSource = dt;

                var distinctBGroups = dt.AsEnumerable()
                        .Select(row => row.Field<string>("BGroup").Trim())
                        .Distinct()
                        .ToList();

                DBGroupCb.DataSource = distinctBGroups;
                DBGroupCb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading blood stock: " + ex.Message);
            }
        }
        private void Blood_Stockcs_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;


            label10.BackColor = Color.Transparent;
            label10.Parent = panel2;
            label10.ForeColor = Color.Red;
            label11.BackColor = Color.Transparent;
            label11.Parent = panel2;
            label11.ForeColor = Color.Red;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel2;

            BloodStockDGV.ReadOnly = true;
            BloodStockDGV.AllowUserToAddRows = false;
            AdjustDataGridViewHeight();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Donor());
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new View_Donors());
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Patient());
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new View_Patient());
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Blood_Transfer());
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Dashboard());
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new DonateBlood());
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdjustDataGridViewHeight()
        {
            int totalRowHeight = BloodStockDGV.ColumnHeadersHeight; 

            foreach (DataGridViewRow row in BloodStockDGV.Rows)
            {
                totalRowHeight += row.Height;
            }

            BloodStockDGV.Height = totalRowHeight + 2; 
        }

        private void DBGroupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBGroupCb.SelectedIndex == -1)
                return;

            string selectedGroup = DBGroupCb.SelectedItem.ToString();

            BloodStockDGV.ClearSelection();

            foreach (DataGridViewRow r in BloodStockDGV.Rows)
            {
                r.DefaultCellStyle.BackColor = BloodStockDGV.DefaultCellStyle.BackColor;
            }

            foreach (DataGridViewRow row in BloodStockDGV.Rows)
            {
                if (row.Cells["BGroup"].Value != null)
                {
                    string cellValue = row.Cells["BGroup"].Value.ToString().Trim();
                    string selGroup = selectedGroup.Trim();

                    string cellValueClean = cellValue.Replace("-", "");
                    string selGroupClean = selGroup.Replace("-", "");

                    if (string.Equals(cellValueClean, selGroupClean, StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        BloodStockDGV.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

            }
        }
    }
}
