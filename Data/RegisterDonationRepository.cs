using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blood_Bank.Data
{
    internal class RegisterDonationRepository
    {
        private readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultiSubnetFailover=False";

        public void InsertDonation(int donorId, DateTime donationDate, decimal bloodVolume, string location, string note)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    INSERT INTO BloodDonationTbl (DonorID, DonationDate, BloodVolume, Location, Note)
                    VALUES (@DonorID, @DonationDate, @BloodVolume, @Location, @Note)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorID", donorId);
                    cmd.Parameters.AddWithValue("@DonationDate", donationDate);
                    cmd.Parameters.AddWithValue("@BloodVolume", bloodVolume);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@Note", note ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
