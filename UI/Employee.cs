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
using Blood_Bank.UI_Helper;

namespace Blood_Bank.UI
{
    public partial class Employee : Form
    {
        private readonly EmployeeService _service;
        public Employee()
        {
            InitializeComponent();
            _service = new EmployeeService();
            populate();
            ConfigureDataGridView();
            panel1.Paint += (sender, e) => GradientBackgroundHelper.DrawGradientOnControl(panel2, e);
            panel2.Paint += (s, e) => GradientBackgroundHelper.DrawRightPanelGradient(panel1, e);
        }
        private void ConfigureDataGridView()
        {
            EmpDGV.ReadOnly = false; 
            EmpDGV.EditMode = DataGridViewEditMode.EditOnEnter; 
           
        }
        private void reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            EmpEmailTb.Text = "";
        }

        private void populate()
        {
            try
            {
                DataTable dt = _service.GetEmployees();
                EmpDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }
        
        // Login
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

        private void Employee_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;

            label4.BackColor = Color.Transparent;
            label4.Parent = panel2;
            label4.ForeColor = Color.Red;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel2;
            label5.BackColor = Color.Transparent;
            label5.Parent = panel2;
            label5.ForeColor = Color.Red;
            label6.BackColor = Color.Transparent;
            label6.Parent = panel2;
            label6.ForeColor = Color.Red;
            label7.BackColor = Color.Transparent;
            label7.Parent = panel2;
            label7.ForeColor = Color.Red;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.Parent = panel2;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.Parent = panel2;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.Parent = panel2;
        }

        private void EmpPassTb_TextChanged(object sender, EventArgs e)
        {

        }
        // Save
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                _service.AddEmployee(EmpNameTb.Text, EmpPassTb.Text, EmpEmailTb.Text);
                MessageBox.Show("Employee Successfully Saved");
                reset();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Edit
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpDGV.SelectedRows.Count > 0)
                {
                    int empNum = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells["EmpNum"].Value);
                    string empId = EmpNameTb.Text;
                    string empPass = EmpPassTb.Text;
                    string email = EmpEmailTb.Text;

                    bool success = _service.UpdateEmployee(empNum, empId, empPass, email);
                    if (success)
                    {
                        MessageBox.Show("Employee updated successfully!");
                        reset();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update employee.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }
        // Delete
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpDGV.SelectedRows.Count > 0)
                {
                    int empNum = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells["EmpNum"].Value);

                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        bool success = _service.DeleteEmployee(empNum);
                        if (success)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
