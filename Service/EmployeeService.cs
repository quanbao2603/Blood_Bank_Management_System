using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Data;

namespace Blood_Bank.Service
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _repository;
        public EmployeeService()
        {
            _repository = new EmployeeRepository();
        }

        public DataTable GetEmployees()
        {
            return _repository.GetAllEmployees();
        }

        public void AddEmployee(string empId, string empPass, string empEmail)
        {
            if (string.IsNullOrWhiteSpace(empId) || string.IsNullOrWhiteSpace(empPass) || string.IsNullOrWhiteSpace(empEmail))
            {
                throw new ArgumentException("Missing Information");
            }
            _repository.InsertEmployee(empId, empPass, empEmail);
        }
        public bool DeleteEmployee(int empNum)
        {
            if (empNum <= 0)
                throw new ArgumentException("Invalid Employee Number.");

            return _repository.DeleteEmployee(empNum);
        }

        public bool UpdateEmployee(int empNum, string empId, string empPass, string email)
        {
            if (empNum <= 0)
                throw new ArgumentException("Invalid Employee Number.");
            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empPass) || string.IsNullOrEmpty(email))
                throw new ArgumentException("All fields must be filled.");

            // Kiểm tra định dạng email đơn giản
            if (!email.Contains("@") || !email.Contains("."))
                throw new ArgumentException("Invalid email format.");

            return _repository.UpdateEmployee(empNum,empId, empPass, email);
        }
    }
}
