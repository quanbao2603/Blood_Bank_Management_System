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
        }

        private void PopulateDonors()
        {
            var dt = _service.GetDonors();
            DonorDGV.DataSource = dt;
        }

        private void View_Donors_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormChangeRequested?.Invoke(new Donor());
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
            FormChangeRequested?.Invoke(new Dashboard());
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
