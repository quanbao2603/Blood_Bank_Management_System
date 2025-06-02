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

namespace Blood_Bank.UI
{
    public partial class RegisterDonation : Form
    {
        public RegisterDonation()
        {
            InitializeComponent();
        }

        private void RegisterDonation_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reset()
        {
            bunifuTextBox1.Text = "";
            DateDt.Value = DateTime.Now;
            VolumeTb.Text = "";
            LocationTb.Text = "";
            NoteTb.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new RegisterDonationServicecs();
                var donorService = new DonorService();
                string donorId = bunifuTextBox1.Text;
                string donationDate = DateDt.Value.ToString("yyyy-MM-dd");
                string bloodVolume = VolumeTb.Text;
                string location = LocationTb.Text;
                string note = NoteTb.Text;

                if (!int.TryParse(donorId, out int donorIdInt) || !donorService.ExistsById(donorIdInt))
                {
                    var result = MessageBox.Show("Donor ID chưa tồn tại. Bạn có muốn đăng ký thông tin người hiến máu trước không?", "Donor chưa tồn tại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var donorForm = new Blood_Bank.Donor();
                        donorForm.ShowDialog();
                    }
                    return;
                }

                service.RegisterDonation(donorId, donationDate, bloodVolume, location, note);
                MessageBox.Show("Đăng ký hiến máu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
