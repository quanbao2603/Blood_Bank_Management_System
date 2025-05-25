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
using Blood_Bank.UI_Helper;

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
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);

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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel2;
            label11.BackColor = Color.Transparent;
            label11.Parent = panel2;
            label11.ForeColor = Color.Red;
            Label12.BackColor = Color.Transparent;
            Label12.Parent = panel2;
            Label12.ForeColor = Color.Red;
            label13.BackColor = Color.Transparent;
            label13.Parent = panel2;
            label13.ForeColor = Color.Red;
            label14.BackColor = Color.Transparent;
            label14.Parent = panel2;
            label14.ForeColor = Color.Red;
            TotalLbl.BackColor = Color.Transparent;
            TotalLbl.Parent = panel2;
            TotalLbl.ForeColor = Color.Red;

            OPlusProgress.BackColor = Color.Transparent;
            OPlusProgress.Parent = panel2;

            ABPlusProgress.BackColor = Color.Transparent;
            ABPlusProgress.Parent = panel2;

            OMinusProgress.BackColor = Color.Transparent;
            OMinusProgress.Parent = panel2;

            ABMinusProgress.BackColor = Color.Transparent;
            ABMinusProgress.Parent = panel2;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
