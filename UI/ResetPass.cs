using Blood_Bank.Service;
using Blood_Bank.UI_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.UI
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
            this.Paint += (s, e) => GradientBackgroundHelper.DrawDefaultGradient(s, e);
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

        private void ResetPass_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            guna2Button1.BackColor = Color.Transparent;
            label2.MouseEnter += Label_MouseEnter;
            label2.MouseLeave += Label_MouseLeave;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.Red;
            label.Cursor = Cursors.Hand;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(192, 255, 192);
        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {
            string email = EmailTb.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                EmailTb.ForeColor = Color.Red;
            }
            else
            {
                EmailTb.ForeColor = Color.Black;
            }
        }
    }
}
