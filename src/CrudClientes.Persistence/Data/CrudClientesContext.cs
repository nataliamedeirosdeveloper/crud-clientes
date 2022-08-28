using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudClientes.Domain.Models;

namespace CrudClientes.Persistence.Data
{
    

    public class CrudClientesContext : DbContext
    {
        public CrudClientesContext(DbContextOptions<CrudClientesContext> options) : base(options)
        {
        }
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}