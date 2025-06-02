using System.Data;

namespace Blood_Bank.Service
{
    public interface IEmployeeService
    {
        DataTable GetEmployees();
        void AddEmployee(string empId, string empPass, string empEmail);
        bool DeleteEmployee(int empNum);
        bool UpdateEmployee(int empNum, string empId, string empPass, string email);
    }
} 