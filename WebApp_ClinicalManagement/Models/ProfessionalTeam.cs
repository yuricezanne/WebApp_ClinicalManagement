namespace WebApp_ClinicalManagement.Models
{
    public class ProfessionalTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Vat { get; set; }
        public string JobId { get; set; }
        public string JobRole { get; set; }

        // Constructor
        public ProfessionalTeam(
            int id,
            string name,
            DateTime dateOfBirth,
            string address,
            int zipCode,
            string city,
            string country,
            int vat,
            string jobId,
            string jobRole)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Vat = vat;
            JobId = jobId;
            JobRole = jobRole;
        }
    }
}
