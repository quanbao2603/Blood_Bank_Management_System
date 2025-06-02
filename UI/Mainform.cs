using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.UI;
using Blood_Bank.UI_Helper;

namespace Blood_Bank
{
    public partial class Mainform : Form
    {
        private Form currentForm = null;
        public Mainform()
        {
            InitializeComponent();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel1, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel2, e);

        }

        private void OpenFormAndHideMain(Form form)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Opening form: {form.GetType().Name}");
                if (currentForm != null && !currentForm.IsDisposed)
                {
                    currentForm.Close();
                    currentForm = null;
                }

                if (form is Donor donorForm)
                {
                    donorForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is View_Donors viewDonorsForm)
                {
                    viewDonorsForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is Patient patientForm)
                {
                    patientForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is View_Patient viewPatientForm)
                {
                    viewPatientForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is Blood_Stockcs bloodStockForm)
                {
                    bloodStockForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is Blood_Transfer bloodTransferForm)
                {
                    bloodTransferForm.FormChangeRequested += OnFormChangeRequested;
                }
                else if (form is Dashboard dashboardForm)
                {
                    dashboardForm.FormChangeRequested += OnFormChangeRequested;
                }
                
                    // Đăng ký sự kiện FormClosed để hiện lại Mainform khi form con đóng
                    form.FormClosed += (s, args) =>
                    {
                        this.Show(); // Hiện lại Mainform khi form con đóng
                        currentForm = null; // Đặt lại form hiện tại
                    };

                // Ẩn Mainform và hiển thị form con
                this.Hide();

                form.Show();
                currentForm = form; // Cập nhật form hiện tại
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in OpenFormAndHideMain: {ex.Message}");
                MessageBox.Show($"Lỗi khi hiển thị form: {ex.Message}");
            }
        }

        // Xử lý khi form con yêu cầu chuyển form
        private void OnFormChangeRequested(Form newForm)
        {
            OpenFormAndHideMain(newForm);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label2_Click called");
            Donor donorForm = new Donor();
            OpenFormAndHideMain(donorForm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label3_Click called");
            View_Donors donorForm = new View_Donors();
            OpenFormAndHideMain(donorForm);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label4_Click called");
            Patient pt = new Patient();
            OpenFormAndHideMain(pt);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label5_Click called");
            View_Patient vpt = new View_Patient();
            OpenFormAndHideMain(vpt);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label6_Click called");
            Blood_Stockcs bloodStockcs = new Blood_Stockcs();
            OpenFormAndHideMain(bloodStockcs);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label7_Click called");
            Blood_Transfer bloodTransfer = new Blood_Transfer();
            OpenFormAndHideMain(bloodTransfer);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label8_Click called");
            Dashboard dashboard = new Dashboard();
            OpenFormAndHideMain(dashboard);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label11_Click called");
            BloodBag bloodTransfer = new BloodBag();
            OpenFormAndHideMain(bloodTransfer);
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

        private void Mainform_Load(object sender, EventArgs e)
        {
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
            label10.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            label1.Parent = panel2;
            label1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel2;
            pictureBox1.ForeColor = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }   
    }
}