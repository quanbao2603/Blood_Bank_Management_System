namespace Blood_Bank.Service
{
    public interface IDonorService
    {
        void AddDonor(string name, string ageText, string gender, string phone, string address, string bloodGroup);
    }
} 