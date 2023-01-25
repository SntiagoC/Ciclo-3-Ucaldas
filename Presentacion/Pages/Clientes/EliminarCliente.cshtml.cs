using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.Clientes
{
    public class EliminarClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        [BindProperty]
       
       public Cliente cliente {get;set;}
       
        public bool caso {get;set;}

        public string cual {get;set;}

        public EliminarClienteModel(IRepositorioCliente repometers)
        {
            _repo =repometers;
        }
        public void OnGet(int id)
        {   
           cliente=_repo.Get(id);
           cual="?";
    
        }

        public IActionResult OnPost(){
            
            try
            {
                _repo.Delete(cliente.ClienteId);               
                cual="Usuario Borrado";
                return new RedirectToPageResult("ListaClientes");
            }
            catch (Exception e)
            {
                if(_repo.ObtenerFactura(cliente.ClienteId)!=null)
                {
                     cual="No se ha podido borrar el usuario porque está asociado a facturas";
                }
                else
                {
                     cual="No se ha podido borrar el usuario consulte al administrador";
                }

               
                return Page();
            }
   

            
        }
    }
}
