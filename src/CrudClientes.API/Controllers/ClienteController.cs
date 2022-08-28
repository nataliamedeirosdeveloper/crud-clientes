using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudClientes.Domain.Models;
using CrudClientes.Persistence.Data;

namespace CrudClientes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly CrudClientesContext context;
        public ClienteController(CrudClientesContext _context)
        {
            context = _context;
        }
 
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return context.Clientes;
        }
    }
}
