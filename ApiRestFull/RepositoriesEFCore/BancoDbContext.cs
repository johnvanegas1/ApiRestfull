using Entities;
using Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesEFCore
{
    public class BancoDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public BancoDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(configuration.GetConnectionString("DataData Source=localhost;Initial Catalog=bancodb;User ID=jpvg;Password=Gmv4Gmv5Gmv*;"));
            options.UseSqlServer("Data Source=localhost;Initial Catalog=bancodb;User ID=jpvg;Password=Gmv4Gmv5Gmv*;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }

        public DbSet<Cliente>  Clientes { get; set; }
        public DbSet<Cuenta>  Cuentas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasOne(c => c.Cliente).WithMany(h => h.Cuentas).HasForeignKey(c => c.ClienteId);
            modelBuilder.Entity<Movimiento>().HasOne(c => c.Cuenta).WithMany(h => h.Movimientos).HasForeignKey(c => c.CuentaId);

            //modelBuilder.Entity<Movimiento>().Property(m => m.TipoMovimiento).HasConversion<TipoMovimiento>();
            //modelBuilder.Entity<Cuenta>().Property(m => m.TipoCuenta).HasConversion<TipoCuenta>();
            
            modelBuilder.HasDefaultSchema("datos");
        }
    }
}
