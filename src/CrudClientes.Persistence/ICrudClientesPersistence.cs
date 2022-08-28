using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudClientes.Domain.Models;

namespace CrudClientes.Persistence
{
    public interface ICrudClientesPersistence
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();
        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int id);
    }
}