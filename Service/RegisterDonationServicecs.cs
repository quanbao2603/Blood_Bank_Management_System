using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Data;

namespace Blood_Bank.Service
{
    internal class RegisterDonationServicecs
    {
        private readonly RegisterDonationRepository _registerDonationRepository;

        public RegisterDonationServicecs()
        {
            _registerDonationRepository = new RegisterDonationRepository();
        }

        public void RegisterDonation(string donorIdText, string donationDateText, string bloodVolumeText, string location, string note)
        {
            if (string.IsNullOrWhiteSpace(donorIdText) ||
                string.IsNullOrWhiteSpace(donationDateText) ||
                string.IsNullOrWhiteSpace(bloodVolumeText) ||
                string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Missing information");
            }

            if (!int.TryParse(donorIdText, out int donorId))
            {
                throw new ArgumentException("Donor ID must be a valid number");
            }

            if (!DateTime.TryParse(donationDateText, out DateTime donationDate))
            {
                throw new ArgumentException("Donation date must be a valid date");
            }

            if (donationDate > DateTime.Now)
            {
                throw new ArgumentException("Donation date cannot be in the future");
            }

            if (!decimal.TryParse(bloodVolumeText, out decimal bloodVolume))
            {
                throw new ArgumentException("Blood volume must be a valid number");
            }

            if (bloodVolume <= 0)
            {
                throw new ArgumentException("Blood volume must be greater than 0");
            }

            _registerDonationRepository.InsertDonation(donorId, donationDate, bloodVolume, location, note);
        }
    }
}
