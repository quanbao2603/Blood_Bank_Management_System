using System.Data;

namespace Blood_Bank.Data
{
    public interface IEmployeeRepository
    {
        DataTable GetAllEmployees();
        void InsertEmployee(string empId, string empPass, string Email);
        bool DeleteEmployee(int empNum);
        bool UpdateEmployee(int empNum, string empId, string empPass, string email);
    }
} 