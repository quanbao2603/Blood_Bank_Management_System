namespace Blood_Bank.Data
{
    public interface IDonorRepository
    {
        void InsertDonor(string name, int age, string gender, string phone, string address, string bloodGroup);
    }
} 