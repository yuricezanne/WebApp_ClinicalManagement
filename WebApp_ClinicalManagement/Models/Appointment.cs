using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Emit;

namespace WebApp_ClinicalManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Client? Client { get; set; }
        public ProfessionalTeam? Doctor { get; set; }
        public string Observation { get; set; } = string.Empty;
        public bool IsDone { get; set; }

        // Constructor
        public Appointment(
           int id,
           DateTime date,
           string observation,
           bool isDone)
        {
            Id = id;
            Date = date;
            Observation = observation;
            IsDone = isDone;            
        }
    }
}
