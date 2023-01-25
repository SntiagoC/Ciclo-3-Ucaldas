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
    public class ListaClientesModel : PageModel
    {
        private readonly IRepositorioCliente _repo;

        public IEnumerable<Cliente> Clientes {get;set;}
    
        
        public ListaClientesModel(IRepositorioCliente repo)
        {
            _repo=repo;
        }


        public void OnGet()
        {
            Clientes = _repo.GetAll();
      
        }
    }
}

