using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public int Vat { get; set; }
        public bool HasHealthInsurance { get; set; }

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
