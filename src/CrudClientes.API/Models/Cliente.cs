using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudClientes.API.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        
        public string Nome { get; set; }
        
        public string DtNascimento { get; set; }
        
        public string CPF { get; set; }

        public string EstadoCivil { get; set; }
        
        public string Email { get; set; }
        
        public string TelefoneEmergencia { get; set; }
        
        public string ResponsavelEmergencia { get; set; }

        public string Instagram { get; set; }
        
        
    }
}