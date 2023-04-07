namespace WebApp_ClinicalManagement.Models
{
    public class ProfessionalTeam
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int Vat { get; set; }
        public string JobId { get; set; } = string.Empty;
        public string JobRole { get; set; } = string.Empty;

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
