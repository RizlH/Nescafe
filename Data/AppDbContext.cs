using System.Security.Cryptography.X509Certificates;
using Nescafe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Nescafe.Data
{ 
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members => Set<Member>();
        public DbSet<Access> Accesses => Set<Access>();
        public DbSet<Configuration> Configurations => Set<Configuration>();
        public DbSet<LoanMaster> LoanMasters => Set<LoanMaster>();
        public DbSet<SavingMaster> SavingMasters => Set<SavingMaster>();
        public DbSet<Loan> Loans => Set<Loan>();
        public DbSet<Installment> Installments => Set<Installment>();
        public DbSet<Saving> Savings => Set<Saving>();
        public DbSet<Inhouse> Inhouses => Set<Inhouse>();
        public DbSet<Exchange> Exchanges => Set<Exchange>();
        public DbSet<Balance> Balances => Set<Balance>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(AppContext.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //optionsBuilder.UseNpgsql(config.GetConnectionString("Default"));
            optionsBuilder.UseNpgsql("Host=103.82.242.90;Port=5434;Database=vb2_nescafe;Username=postgres;Password=12Qpalzmxn");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberId);

            modelBuilder.Entity<Installment>()
                .HasOne(i => i.Loan)
                .WithMany(l => l.Installments)
                .HasForeignKey(i => i.LoanId);

            modelBuilder.Entity<Access>()
                .HasOne(a => a.Member)
                .WithMany(m => m.Accesses)
                .HasForeignKey(a => a.MemberId);

            modelBuilder.Entity<Saving>()
                .HasOne(s => s.Member)
                .WithMany(m => m.Savings)
                .HasForeignKey(s => s.MemberId);

            modelBuilder.Entity<Inhouse>()
                .HasOne(x => x.Origin)
                .WithMany(m => m.OriginTransactions)
                .HasForeignKey(x => x.OriginId);

            modelBuilder.Entity<Inhouse>()
                .HasOne(x => x.Destination)
                .WithMany(m => m.DestinationTransactions)
                .HasForeignKey(x => x.DestinationId);

            modelBuilder.Entity<Exchange>()
                .HasOne(x => x.Member)
                .WithMany(m => m.Exchanges)
                .HasForeignKey(x => x.MemberId);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var idProp = entity.FindProperty("Id");
                if (idProp != null)
                {
                    idProp.SetValueGenerationStrategy(
                        NpgsqlValueGenerationStrategy.SerialColumn
                    );
                }
            }

            modelBuilder.UseSerialColumns();
            base.OnModelCreating(modelBuilder);
        }
    }
}
