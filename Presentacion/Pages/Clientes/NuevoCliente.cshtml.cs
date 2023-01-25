using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using System.ComponentModel.DataAnnotations;

namespace Presentacion.Pages.Clientes
{


    public class NuevoClienteModel : PageModel
    {
        private readonly IRepositorioCliente repo;
        
        [BindProperty]
        public Cliente cliente {get;set;}

        public string Titulo {get;set;}

        public NuevoClienteModel(IRepositorioCliente repollo)
        {
            repo =repollo;
        }


        public void OnGet(int? id)
        {
            if (id.HasValue)
            {              
            cliente=repo.Get(id.Value);
            Titulo=cliente.Nombres;
            }else
           
            {
            cliente=new Cliente();
            Titulo="Nuevo Cliente";
            }
        }

        public IActionResult OnPost(){
            
            if(cliente.ClienteId==0){
                cliente=repo.Add(cliente);
                
            }else{
                cliente=repo.Update(cliente);
            }
        return new RedirectToPageResult("ListaClientes");
        }
    }
}
