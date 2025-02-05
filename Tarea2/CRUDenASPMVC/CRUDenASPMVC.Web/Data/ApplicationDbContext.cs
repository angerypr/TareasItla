using CRUDenASPMVC.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDenASPMVC.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
