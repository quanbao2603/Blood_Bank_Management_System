using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Patient : Form
    {
        private readonly PatientService _patientService;
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;
        public Patient()
        {
            InitializeComponent();
            _patientService = new PatientService();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);
        }

        private void reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                _patientService.AddPatient(
                    PNameTb.Text,
                    PAgeTb.Text,
                    PGenCb.SelectedItem?.ToString(),
                    PPhoneTb.Text,
                    PAddressTb.Text,
                    PBGroupCb.SelectedItem?.ToString()
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

        private void Patient_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
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
            label14.BackColor = Color.Transparent;
            label14.Parent = panel2;
            label14.ForeColor = Color.Red;
            label15.BackColor = Color.Transparent;
            label15.Parent = panel2;
            label15.ForeColor = Color.Red;
            label16.BackColor = Color.Transparent;
            label16.Parent = panel2;
            label16.ForeColor = Color.Red;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.Parent = panel2;
            guna2Button1.ForeColor = Color.White;
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
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new View_Patient());
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
