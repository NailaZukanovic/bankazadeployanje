using BankSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Banka.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Expo> Expos { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}