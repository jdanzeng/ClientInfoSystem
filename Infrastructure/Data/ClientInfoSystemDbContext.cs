using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class ClientInfoSystemDbContext : DbContext
    {
        public ClientInfoSystemDbContext(DbContextOptions<ClientInfoSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Interaction> Interactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(ConfigureEmployee);
            modelBuilder.Entity<Client>(ConfigureClient);
            modelBuilder.Entity<Interaction>(ConfigureInteraction);
        }

        private void ConfigureInteraction(EntityTypeBuilder<Interaction> builder)
        {
            builder.ToTable("Interactions");
            builder.HasKey(i => i.Id);            
            builder.Property(i => i.IntType).HasMaxLength(1);
            builder.Property(i => i.IntDate).HasDefaultValueSql("getdate()");
        }

        private void ConfigureClient(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Phone).HasMaxLength(30);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.EmployeeId).HasColumnName("AddedBy");
            builder.Property(c => c.AddedOn).HasDefaultValueSql("getdate()");
        }

        private void ConfigureEmployee(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Password).HasMaxLength(10);
            builder.Property(e => e.Designation).HasMaxLength(50);
        }
    }
}
