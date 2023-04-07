using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp_ClinicalManagement.Models;

namespace WebApp_ClinicalManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Items { get; set; } = default!;
        public DbSet<Appointment> StockMovements { get; set; } = default!;
        public DbSet<WebApp_ClinicalManagement.Models.ProfessionalTeam> ProfessionalTeam { get; set; } = default!;
        public DbSet<WebApp_ClinicalManagement.Models.Invoice> Invoice { get; set; } = default!;
    }
}