﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ClinicalManagement.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string AppointmentDescription { get; set; } = string.Empty;
        [Column(TypeName = "money")] // column type annotation
        public decimal Price { get; set; }
        public int Vat { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsPaid { get; set; }
        public Appointment? Appointment { get; set; }

        // Constructor
        public Invoice(
            int invoiceId,
            string appointmentDescription,
            decimal price,
            int vat,
            string name,
            bool isPaid)
        {
            InvoiceId = invoiceId;
            AppointmentDescription = appointmentDescription;
            Price = price;
            Vat = vat;
            Name = name;
            IsPaid = isPaid;            
        }
    }
}
