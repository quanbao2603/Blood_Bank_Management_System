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

namespace Blood_Bank
{
    public partial class Login : Form
    {
        private readonly LoginService _service;

        public Login()
        {
            InitializeComponent();
            _service = new LoginService();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login button clicked");
            try
            {
                bool isValid = _service.AuthenticateEmployee(EmpIdTb.Text, EmpPassTb.Text);
                if (isValid)
                {
                    Mainform main = new Mainform();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    EmpIdTb.Clear();
                    EmpPassTb.Clear();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát không?",
               "Xác nhận thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // create account
        private void label7_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }
        // Fogot pass
        private void label6_Click(object sender, EventArgs e)
        {
            ResetPass fogorAccount = new ResetPass();
            fogorAccount.Show();
            this.Hide();

        }
    }
}
