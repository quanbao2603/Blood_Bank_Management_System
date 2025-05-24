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
    public partial class Donor : Form
    {
        private readonly DonorService _donorService;
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;
        public Donor()
        {
            InitializeComponent();
            _donorService = new DonorService();
        }


        private void Donor_Load(object sender, EventArgs e)
        {
            
        }
        private void reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;
            DAddressTb.Text = "";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                _donorService.AddDonor(
                    DNameTb.Text,
                    DAgeTb.Text,
                    DGenCb.SelectedItem?.ToString(),
                    DPhoneTb.Text,
                    DAddressTb.Text,
                    DBGroupCb.SelectedItem?.ToString()
                );
                MessageBox.Show("Donor Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
