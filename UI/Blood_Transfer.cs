using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Service;
using Blood_Bank.UI;
using Blood_Bank.UI_Helper;

namespace Blood_Bank
{
    public partial class Blood_Transfer : Form
    {
        private  BloodTransferService _service;

        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;

        public Blood_Transfer()
        {
            InitializeComponent();
            FillPatientCb();
            _service = new BloodTransferService();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);

        }
       
        private void Blood_Transfer_Load(object sender, EventArgs e)
        {
            TransferBtn.Visible = true;
            TransferBtn.Enabled = false;

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
            label12.BackColor = Color.Transparent;
            label12.Parent = panel2;
            label12.ForeColor = Color.Red;
            label13.BackColor = Color.Transparent;
            label13.Parent = panel2;
            label13.ForeColor = Color.Red;
            TransferBtn.BackColor = Color.Transparent;
            TransferBtn.Parent = panel2;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel2;
            AvailableLbl.BackColor = Color.Transparent;
            AvailableLbl.Parent = panel2;
        }

        private void FillPatientCb()
        {
            _service = new BloodTransferService();
            try
            {
                DataTable dt = _service.GetAllPatients();
                PatientIdCb.DataSource = dt;
                PatientIdCb.DisplayMember = "PNum";
                PatientIdCb.ValueMember = "PNum";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }
        
        private void GetData()
        {
            try
            {
                string selectedPatientId = PatientIdCb.SelectedValue.ToString();
                DataTable dt = _service.GetPatientDetails(selectedPatientId);
                if (dt.Rows.Count > 0)
                {
                    PatNameTb.Text = dt.Rows[0]["PName"].ToString();
                    BloodGroup.Text = dt.Rows[0]["PBGroup"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving patient data: " + ex.Message);
            }
        }

        private void GetStock(string BGroup)
        {
            try
            {
                bool isAvailable = _service.CheckStockAvailability(BGroup);
                if (isAvailable)
                {
                    TransferBtn.Enabled = true;
                    AvailableLbl.Text = "Available Stock";
                    AvailableLbl.ForeColor = Color.Green;
                }
                else
                {
                    TransferBtn.Enabled = false;
                    AvailableLbl.Text = "Stock Not Available";
                    AvailableLbl.ForeColor = Color.Red;
                }

                AvailableLbl.Visible = true;
                TransferBtn.Visible = true; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking stock: " + ex.Message);
            }
        }
        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            string bloodGroup = BloodGroup.Text;
            if (!string.IsNullOrEmpty(bloodGroup))
            {
                GetStock(bloodGroup);
            }
            else
            {
                AvailableLbl.Visible = false;
            }
        }

        

        private void reset()
        {
            PatNameTb.Text = "";
            BloodGroup.Text = "";
            PatientIdCb.SelectedIndex = -1;
            AvailableLbl.Visible = false;
            TransferBtn.Enabled = false;
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PatNameTb.Text) || string.IsNullOrEmpty(BloodGroup.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    _service.RecordBloodTransfer(PatNameTb.Text, BloodGroup.Text);
                    _service.ProcessBloodTransfer(BloodGroup.Text);
                    MessageBox.Show("Blood Transfer Successful");
                    reset();
                    FillPatientCb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during transfer: " + ex.Message);
            }
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
            FormNavigator.Navigate(this, new Blood_Stockcs());
        }

        private void label7_Click(object sender, EventArgs e)
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
    }
}
