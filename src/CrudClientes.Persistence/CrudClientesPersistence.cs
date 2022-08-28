using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudClientes.Persistence.Data;
using CrudClientes.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudClientes.Persistence
{
    public class CrudClientesPersistence : ICrudClientesPersistence
    {
        private readonly CrudClientesContext context;

        public CrudClientesPersistence(CrudClientesContext _context)
        {
            context = _context;
        }

        public void Add<T>(T entity) where T : class{
            context.Add(entity);
        }

        public void Update<T>(T entity) where T : class{
            context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class{
            context.Remove(entity);
        }

        public void DeleteRange<T>(T entityArray) where T : class{
            context.RemoveRange(entityArray);
        }        

        public async Task<bool> SaveChangesAsync(){
            return (await context.SaveChangesAsync()) > 0;
        }

        public async Task<Cliente[]> GetAllClientesAsync(){
            IQueryable<Cliente> query = context.Clientes;
            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int id){
            IQueryable<Cliente> query = context.Clientes;
            return await query.Where(x => x.ClienteId == id).FirstOrDefaultAsync();
        }
    }
}