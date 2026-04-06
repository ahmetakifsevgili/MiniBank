using Microsoft.EntityFrameworkCore;
using MiniBank.Entities;
namespace MiniBank.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet'ler: SQL veritabanındaki tablolarımızın karşılığıdır.
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CryptoAccount> CryptoAccounts { get; set; }
    }
}
