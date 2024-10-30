using EpiApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace EpiApi.Data
{
    public class EpiContext:DbContext
    {
        public DbSet<Epi> epis { get; set; }
        public DbSet<Lista> listas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder.UseNpgsql(
                "Server=localhost;Port=5432;DataBase=30102024controle_epi;User Id=postgres;Password=123"));
        }
    }
}
