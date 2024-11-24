using Microsoft.EntityFrameworkCore;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Database
{

    public class AppDBContext : DbContext
    {
        public string portPG = Environment.GetEnvironmentVariable("DATABASE_PORT");
        public string nameDbDatalog = Environment.GetEnvironmentVariable("DATABASE_NAME");
        public DbSet<MasterData> masterData { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                 "Server=localhost;" +
                 $"Port={portPG};" +
                 $"Database={nameDbDatalog};" +
                 "User Id=postgres;" +
                 "Password=123456789;"
                 );
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("unaccent");
            modelBuilder.ConfigureDateTimeProperties("timestamp without time zone");
        }
    }
    public static class Extxtensions
    {
        public static void ConfigureDateTimeProperties(this ModelBuilder modelBuilder, string columnType)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.ClrType.GetProperties())
                {
                    if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasColumnType(columnType);
                    }
                }
            }
        }
    }   
    
}
