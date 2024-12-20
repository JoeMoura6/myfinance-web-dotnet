using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Infrastructure
{
    public class MyFinanceDbContext : DbContext
    {
        public DbSet<PlanoConta> PlanoConta {get; set;}
        public DbSet<Transacao> Transacao {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}