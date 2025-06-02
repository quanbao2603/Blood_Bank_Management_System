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
    public partial class View_Patient : Form
    {
        private readonly ViewPatientsService _service;
        public delegate void FormChangeRequestedHandler(Form newForm);
        public event FormChangeRequestedHandler FormChangeRequested;
        private int key = 0;
        public View_Patient()
        {
            InitializeComponent();
            _service = new ViewPatientsService();
            populate();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);
        }

        

        private void populate()
        {
            DataTable dt = _service.GetAllPatients();
            PatientDGV.DataSource = dt;
        }

        private void View_Patient_Load(object sender, EventArgs e)
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
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.Parent = panel2;

            PatientDGV.ReadOnly = true;
            PatientDGV.AllowUserToAddRows = false;
            AdjustDataGridViewHeight();

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

        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (int.TryParse(PatientDGV.SelectedRows[0].Cells[0].Value.ToString(), out int result))
            {
                key = result;
            }
            else
            {
                key = 0;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                _service.DeletePatientData(key);
                MessageBox.Show("Patient Deleted Successfully");
                reset();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                _service.UpdatePatient(key, PNameTb.Text, Convert.ToInt32(PAgeTb.Text), PPhoneTb.Text, PGenCb.SelectedItem.ToString(), PBGroupCb.SelectedItem.ToString(), PAddressTb.Text);
                MessageBox.Show("Patient Updated Successfully");
                reset();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        }

        private void label5_Click(object sender, EventArgs e)
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
        private void AdjustDataGridViewHeight()
        {
            int totalRowHeight = PatientDGV.ColumnHeadersHeight; // chiều cao header

            foreach (DataGridViewRow row in PatientDGV.Rows)
            {
                totalRowHeight += row.Height;
            }

            PatientDGV.Height = totalRowHeight + 2; // +2 cho viền tí tẹo
        }
    }
}
