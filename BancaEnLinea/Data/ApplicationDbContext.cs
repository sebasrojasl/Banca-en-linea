using Microsoft.EntityFrameworkCore;
using BancaEnLinea.Models;

namespace BancaEnLinea.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cuenta> Cuentas { get; set; }

    }
}
