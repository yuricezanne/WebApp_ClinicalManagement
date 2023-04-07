using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public int Vat { get; set; }
        public bool HasHealthInsurance { get; set; }

        // Constructor
        public Client(
            int id,
            string name,
            DateTime dateOfBirth,
            string address,
            int zipCode,
            string city,
            string country,
            int vat,
            bool hasHealthInsurance)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Vat = vat;
            HasHealthInsurance = hasHealthInsurance;
        }

    }
}
