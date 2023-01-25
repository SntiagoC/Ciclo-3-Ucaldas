using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId {get; set;}

        [Required(ErrorMessage="Debes agragar una placa para el vehiculo"),StringLength(16)]
        public string Placa {get; set;}

        [Required(ErrorMessage="Debes agragar una marca para el vehiculo"),StringLength(16)]
        public string Marca {get; set;}

        [Required(ErrorMessage="Debes agragar un color de vehiculo"),StringLength(16)]
        public string Color{get; set;} 

        [Required(ErrorMessage="Debes agragar un modelo de vehiculo"),StringLength(16)]
        public string Modelo {get; set;}

        [Required(ErrorMessage="Debes agragar un tipo de vehiculo"),StringLength(16),Display(Name="Tipo de vehiculo")]
        public string TipoVehiculo {get;set;}

        [Required(ErrorMessage="Debes agragar un tipo de combustible para el vehiculo"),StringLength(16),Display(Name="Combustible")]
        public string TipoCombustible {get; set;}
       
        [Required(ErrorMessage="Debes agragar una marca para el vehiculo")]
        public float Cilindraje {get; set;} 

        [Required(ErrorMessage="El kilometraje debe ser ingresado")]
        public int Kilometraje {get; set;} 

        
        [Display(Name="Ultimo Mantenimiento")]
        public DateTime UltimoMantenimiento {get; set;}
        
        [Required(ErrorMessage="Debes agragar el estado del vehiculo"),StringLength(16)]
        public string Estado {get; set;}
                
        [Display(Name="Cliente")]
        public virtual int ClienteId  {get; set;}
    }
}