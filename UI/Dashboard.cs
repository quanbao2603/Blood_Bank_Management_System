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
using Guna.UI2.WinForms;
using Blood_Bank.Service;

namespace Blood_Bank
{
    public partial class Dashboard : Form
    {
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;

        private readonly DashboardService _service;
        public Dashboard()
        {
            InitializeComponent();
            _service = new DashboardService();
            GetData();

        }
        
        private void GetData()
        {
            // Lấy thông tin từ service và cập nhật lên UI
            try
            {
                int totalDonors = _service.GetDonorCount();
                DonorsLbl.Text = totalDonors.ToString();

                int totalTransfers = _service.GetTransferCount();
                TransferLbl.Text = totalTransfers.ToString();

                int totalEmployees = _service.GetEmployeeCount();
                UserLbl.Text = totalEmployees.ToString();

                int totalBloodStock = _service.GetBloodStock();
                TotalLbl.Text = totalBloodStock.ToString();

                // Tính phần trăm và hiển thị cho các nhóm máu
                UpdateBloodGroupData("O+", totalBloodStock, OPlusNum, OPlusProgress);
                UpdateBloodGroupData("AB+", totalBloodStock, ABPlusNum, ABPlusProgress);
                UpdateBloodGroupData("O-", totalBloodStock, OMinusNum, OMinusProgress);
                UpdateBloodGroupData("AB-", totalBloodStock, ABMinusNum, ABMinusProgress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void UpdateBloodGroupData(string bloodGroup, int totalStock, Label groupLabel, object groupProgress)
        {
            int groupCount = _service.GetBloodGroupCount(bloodGroup);
            groupLabel.Text = groupCount.ToString();

            int percentage = _service.GetBloodGroupPercentage(bloodGroup, totalStock);

            if (groupProgress is Guna2ProgressBar progressBar)
            {
                progressBar.Value = percentage;
            }
            else if (groupProgress is Guna2CircleProgressBar circleProgressBar)
            {
                circleProgressBar.Value = percentage;
            }
            else
            {
                MessageBox.Show("Invalid progress bar type.");
            }

            MessageBox.Show($"{bloodGroup} Percentage: {percentage}%");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
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
    }
}
