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
    public partial class View_Donors : Form
    {
        private readonly ViewDonorsService _service;
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;
        public View_Donors()
        {
            InitializeComponent();
            _service = new ViewDonorsService();
            PopulateDonors();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);
        }

        private void PopulateDonors()
        {
            var dt = _service.GetDonors();
            DonorDGV.DataSource = dt;
        }

        private void View_Donors_Load(object sender, EventArgs e)
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

            DonorDGV.ReadOnly = true;
            DonorDGV.AllowUserToAddRows = false;
            AdjustDataGridViewHeight();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int donorId = Convert.ToInt32(DonorDGV.Rows[e.RowIndex].Cells["DNum"].Value);
                DonorHistory historyForm = new DonorHistory(donorId);
                historyForm.ShowDialog();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Donor());
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Patient());
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new View_Patient());
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Blood_Stockcs());
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Blood_Transfer());
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Dashboard());
        }

        private void label1_Click(object sender, EventArgs e)
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
        private void AdjustDataGridViewHeight()
        {
            int totalRowHeight = DonorDGV.ColumnHeadersHeight; // chiều cao header

            foreach (DataGridViewRow row in DonorDGV.Rows)
            {
                totalRowHeight += row.Height;
            }

            DonorDGV.Height = totalRowHeight + 2; // +2 cho viền tí tẹo
        }

    }
}
