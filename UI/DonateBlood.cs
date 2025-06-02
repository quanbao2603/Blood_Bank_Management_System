using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Service;
using Blood_Bank.UI_Helper;

namespace Blood_Bank.UI
{
    public partial class DonateBlood : Form
    {
        private readonly DonateBloodService _service;
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;
        public DonateBlood()
        {
            InitializeComponent();
            _service = new DonateBloodService();
            LoadDonors();
            LoadBloodStock();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel2, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel1, e);
        }
        
        private void DonateBlood_Load(object sender, EventArgs e)
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
        }

        private void LoadDonors()
        {
            try
            {
                DonorsDGV.DataSource = _service.GetDonors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading donors: " + ex.Message);
            }
        }
        private void LoadBloodStock()
        {
            try
            {
                BloodStockDGV.DataSource = _service.GetBloodStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading blood stock: " + ex.Message);
            }
        }

        private void DonorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DonorsDGV.SelectedRows.Count > 0)
            {
                var row = DonorsDGV.SelectedRows[0];
                DNameTb.Text = row.Cells["DName"].Value?.ToString() ?? "";
                DBGroupTb.Text = row.Cells["DGroup"].Value?.ToString() ?? "";
            }
        }
        private void ResetInputs()
        {
            DNameTb.Text = "";
            DBGroupTb.Text = "";
        }

        int oldstock = 0;
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(DNameTb.Text) || string.IsNullOrWhiteSpace(DBGroupTb.Text))
                {
                    MessageBox.Show("Select a donor before donating.");
                    return;
                }

                _service.AddDonation(DBGroupTb.Text);
                MessageBox.Show("Donation successful.");

                ResetInputs();
                LoadBloodStock();
                LoadDonors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during donation: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new Donor());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new View_Donors());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new Patient());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new View_Patient());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new Blood_Stockcs());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new Blood_Transfer());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
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
            FormNavigator.Navigate(this, new View_Donors());
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Blood_Stockcs());
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Blood_Transfer());
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new Dashboard());
        }
    }
}
