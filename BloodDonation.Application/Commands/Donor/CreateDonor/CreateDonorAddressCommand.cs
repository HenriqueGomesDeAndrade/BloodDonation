namespace BloodDonation.Application.Commands.Donor.CreateDonor
{
    public class CreateDonorAddressCommand
    {
        public int Id { get; set; }
        public string PublicArea { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int DonorId { get; set; }
    }
}
