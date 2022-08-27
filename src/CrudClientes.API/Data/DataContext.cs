using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudClientes.API.Models;

namespace CrudClientes.API.Data
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}