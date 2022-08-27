using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudClientes.API.Models;
using CrudClientes.API.Data;

namespace CrudClientes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext context;
        public ClienteController(DataContext _context)
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
