using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Servicios
    {

  
        public int Id {get; set;}

        public ICollection<Vehiculo> ListaVehiculos {get; set;}

        [Required(ErrorMessage="Es necesario especificar el valor del servicio")]
        public float ValorServicio {get; set;}
        
        public DateTime FechaIngreso {get; set;}

        public DateTime FechaEntrega {get; set;}
    }

}