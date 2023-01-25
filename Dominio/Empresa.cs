using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {   

        public ICollection<Empleado> ListaEmpleados {get; set;}
        public ICollection<Cliente> ListaClientes {get; set;}
        public int Id {get; set;} 
        public string direccion {get; set;}
        public string telefono {get; set;}
        
    }
}