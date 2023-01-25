using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio

{
    public class Factura
    {

      [Key]
      public int FacturaId {get; set;}


      [Required(ErrorMessage="La factura debe contar con por lo menos un servicio")]
      public ICollection<Servicios> Servicios {get; set;}
  
      [Required(ErrorMessage="La factura debe tener un cliente relacionado")]
      public Cliente Cliente {get; set;}


      public DateTime FechaFactura {get; set;}


      public float ValorTotal {get; set;}

     [Required(ErrorMessage="El Campo Meto de pago debe ser completado")]
      public string MetodoPago {get; set;}

      public virtual int ClienteId {get;set;}

    }
}