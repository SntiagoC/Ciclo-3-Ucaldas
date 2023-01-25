using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApplicationContext: DbContext
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ScrumpSprint;Integrated Security=True;";
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Empleado> empleados {get; set;}
        public DbSet<Factura> Facturas {get; set;}
        public DbSet<Empresa> empresa {get; set;}
        public DbSet<Servicios> servicios {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}
        public ApplicationContext(){}
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}
