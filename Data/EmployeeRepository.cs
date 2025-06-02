using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultiSubnetFailover=False";
        public DataTable GetAllEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EmployeeTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        public void InsertEmployee(string empId, string empPass, string Email)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EmployeeTbl (EmpId, EmpPass, Email) VALUES (@EmpId, @EmpPass, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpPass", empPass);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public bool DeleteEmployee(int empNum)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM EmployeeTbl WHERE EmpNum = @EmpNum";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpNum", empNum);
                    con.Open(); // Thêm dòng này để mở kết nối
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close(); // Đóng kết nối
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateEmployee(int empNum, string empId, string empPass, string email)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE EmployeeTbl SET EmpId = @EmpId, EmpPass = @EmpPass, Email = @Email WHERE EmpNum = @EmpNum";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpNum", empNum); // Thêm tham số EmpNum vào câu lệnh
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpPass", empPass);
                    cmd.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
