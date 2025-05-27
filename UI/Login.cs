using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank.Service;   
using Blood_Bank.UI;
using Blood_Bank.UI_Helper;
using Guna.UI2.WinForms;

namespace Blood_Bank
{
    public partial class Login : Form
    {
        private readonly LoginService _service;

        public Login()
        {
            InitializeComponent();
            _service = new LoginService();
            //this.Paint += (s, e) => GradientBackgroundHelper.DrawDefaultGradient(s, e);

            panel1.Paint += new PaintEventHandler((s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                    Color.FromArgb(100, Color.White), ButtonBorderStyle.Solid);
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            guna2Button1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;  

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0); 
            panel1.BorderStyle = BorderStyle.None;
            RoundPannel.Apply(panel1, 30); 

            label4.MouseEnter += Label_MouseEnter;
            label4.MouseLeave += Label_MouseLeave;
            label5.MouseEnter += Label_MouseEnter;
            label5.MouseLeave += Label_MouseLeave;
            label6.MouseEnter += Label_MouseEnter;
            label6.MouseLeave += Label_MouseLeave;
            label7.MouseEnter += Label_MouseEnter;
            label7.MouseLeave += Label_MouseLeave;

            guna2Button1.FillColor = Color.Red;
            guna2Button1.HoverState.FillColor = Color.DarkRed;
            guna2Button1.PressedColor = Color.Maroon;

            RoundLabelHelper.Apply(label9, 10);

            this.BackgroundImage = Properties.Resources.icoc;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            EmpPassTb.UseSystemPasswordChar = !EmpPassTb.UseSystemPasswordChar;
        }

        private void EmpIdTb_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
