using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFModelCreatingApp
{
    public class EmployeeAppContext : DbContext
    {
        public DbSet<Employee> Employees { set; get; } = null!;
        //public DbSet<Position> Positions { set; get; } = null!;
        //public DbSet<Country> Countries { set; get; } = null!;
        //public DbSet<Company> Companies { set; get; } = null!;

        public EmployeeAppContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ISC66B9\\MSSQLSERVER2022;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Database=hr_db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // add entity to model:
            //modelBuilder.Entity<Country>();

            // ignore entity in model:
            //modelBuilder.Ignore<Company>();

            // ignore property entity's
            //modelBuilder.Entity<Employee>().Ignore(e => e.Position);

            // binding private field to EF entity
            //modelBuilder.Entity<Employee>().Property("code");

            modelBuilder.Entity<Employee>()
                        .ToTable("Employees_Table");

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Name)
                        .HasColumnName("FullName");

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Age)
                        .HasColumnName("AgeInt");

            //modelBuilder.Entity<Employee>()
            //            .Property(e => e.Passport)
            //            .HasColumnName("Id");

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Name)
                        .IsRequired();

            modelBuilder.Entity<Employee>()
                        .HasKey(e => new { e.PassportSeries, e.PassportNumber })
                        .HasName("PK_PassportFull");

            //modelBuilder.Entity<Employee>()
            //            .HasAlternateKey(e => e.Phone)
            //            .HasName("UQ_Phone");

            modelBuilder.Entity<Employee>()
                        .HasIndex(e => e.Phone)
                        .HasFilter("[Phone] IS NOT NULL")
                        .IsUnique()
                        .HasDatabaseName("IX_Phone");
        }
    }
}
