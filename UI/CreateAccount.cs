using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Service;
using Blood_Bank.UI_Helper;


namespace Blood_Bank.UI
{
    public partial class CreateAccount : Form
    {
        private readonly EmployeeService _service;
        public CreateAccount()
        {
            InitializeComponent();
            _service = new EmployeeService();
            this.Paint += (s, e) => GradientBackgroundHelper.DrawDefaultGradient(s, e);

        }
        private void reset()
        {
            EmailTb.Text = "";
            PasswordTb.Text = "";
            AccountTb.Text = "";
        }


        // Create Button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = EmailTb.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ, vui lòng nhập đúng định dạng email.", "Lỗi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTb.Focus();
                return; 
            }

            try
            {
                _service.AddEmployee(AccountTb.Text, PasswordTb.Text, EmailTb.Text);
                MessageBox.Show("Your account has been created successfully.");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;   
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;  
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            guna2Button1.BackColor = Color.Transparent;

            label5.MouseEnter += Label_MouseEnter;
            label5.MouseLeave += Label_MouseLeave;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
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

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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

        private void AccountTb_TextChanged(object sender, EventArgs e)
        {
            string currentText = AccountTb.Text;

            if (!Regex.IsMatch(currentText, @"^[a-zA-Z0-9@#]*$"))
            {
                MessageBox.Show("Chỉ được nhập chữ cái, số, @ và #", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reset();
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            string currentText = PasswordTb.Text;
            PasswordTb.UseSystemPasswordChar = false;

            if (!Regex.IsMatch(currentText, @"^[a-zA-Z0-9@#]*$"))
            {
                MessageBox.Show("Mật khẩu chỉ được chứa chữ cái, số, @ và #", "Lỗi nhập mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordTb.UseSystemPasswordChar = !PasswordTb.UseSystemPasswordChar;
        }
    }
}
