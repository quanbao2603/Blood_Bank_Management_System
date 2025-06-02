namespace Blood_Bank.Data
{
    public interface IPatientRepository
    {
        void InsertPatient(string name, int age, string gender, string phone, string address, string bloodGroup);
    }
} 