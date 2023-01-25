using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Cliente
    {
        [Key]
        public int ClienteId  {get; set;}

        [Required(ErrorMessage = "Debes rellenar el campo nombres"),StringLength(60)]
        public string Nombres  {get; set;}
       
        [Required(ErrorMessage = "Debes rellenar el campo apellidos"),StringLength(60)]
        public string Apellidos  {get; set;}
        
        [Required(ErrorMessage = "Es necesario rellenar el campo tipo de documento"),StringLength(2)]
        public string TipoDocumento {get;set;}
       
        [Required(ErrorMessage = "Es necesario rellenar el campo tipo de documento"),StringLength(16)]
        public string NumeroDocumento  {get; set;}  
        

        public DateTime FechaNacimiento  {get; set;}

        public ICollection<Vehiculo> MisVehiculos {get; set;}
            
        [StringLength(100)]
        public string Direccion {get; set;}

        [Required(ErrorMessage="El campo telefo debe ser completado")]
        public int Telefono {get; set;}
        
        [Required(ErrorMessage = "El Email es necesario, es al manera como no pondremos en contaco contigo"),StringLength(100)]
        public string Email {get; set;}


    }
}