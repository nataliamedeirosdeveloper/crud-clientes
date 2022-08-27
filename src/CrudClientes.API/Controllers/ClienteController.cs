using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudClientes.API.Models;

namespace CrudClientes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public ClienteController()
        {
        }
 
        [HttpGet]
        public Cliente Get()
        {
            return new Cliente(){
                 ClienteId = 1,
                 Nome = "Douglas",
                 DtNascimento = "20/03/1991",
                 CPF = "11.625.027-83",
                 EstadoCivil = "Solteiro",
                 Email = "lima.mdouglas@gmail.com",
                 TelefoneEmergencia = "(21)98765-4321",
                 ResponsavelEmergencia = "Mãe",
                 Instagram = "teste"
            };
        }
    }
}
