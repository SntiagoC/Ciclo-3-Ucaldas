using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {   
        public int Id  {get; set;}
        public string Nombres  {get; set;}
        public string Apellidos  {get; set;}
        public string TipoDocumento {get;set;}
        public string NumeroDocumento  {get; set;}
        public string Cargo {get; set;} 
        public float Salario {get; set;}
        public DateTime FechaIngreso {get; set;}

    }
}