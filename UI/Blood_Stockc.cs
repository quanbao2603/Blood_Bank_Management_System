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
    public partial class Blood_Stockcs : Form
    {
        private readonly BloodStockService _service;

        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;

        public Blood_Stockcs()
        {
            InitializeComponent();
            _service = new BloodStockService();
            LoadBloodStock();


        }
        
        private void LoadBloodStock()
        {
            try
            {
                DataTable dt = _service.GetBloodStock();
                BloodStockDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading blood stock: " + ex.Message);
            }
        }
        private void Blood_Stockcs_Load(object sender, EventArgs e)
        {
            
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
                this.Hide(); // Ẩn form hiện tại
                Login loginForm = new Login(); // Tạo form đăng nhập mới
                loginForm.Show(); // Hiển thị form đăng nhập
            }
        }


    }
}
