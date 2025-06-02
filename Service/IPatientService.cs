namespace Blood_Bank.Service
{
    public interface IPatientService
    {
        void AddPatient(string name, string ageText, string gender, string phone, string address, string bloodGroup);
    }
} 