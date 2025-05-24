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


namespace Blood_Bank.UI
{
    public partial class CreateAccount : Form
    {
        private readonly EmployeeService _service;
        public CreateAccount()
        {
            InitializeComponent();
            _service = new EmployeeService();
            
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


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
