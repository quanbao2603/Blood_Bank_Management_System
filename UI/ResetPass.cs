using Blood_Bank.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.UI
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = EmailTb.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            string password = new LoginService().GetPasswordByEmail(email);
            if (password == null)
            {
                MessageBox.Show("Email not found.");
                return;
            }

            try
            {
                string subject = "Password Recovery";
                string body = $"Your password is: {password}";
                MailService.SendEmail(email, subject, body);
                MessageBox.Show("Password has been sent to your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}
