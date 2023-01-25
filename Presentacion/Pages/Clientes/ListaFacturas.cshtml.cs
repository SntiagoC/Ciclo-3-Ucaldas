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
    public class ListaFacturasModel : PageModel
    {
        private readonly IRepositorioFactura _repo;

        public IEnumerable<Factura> ListFact {get;set;}

        public ListaFacturasModel(IRepositorioFactura repo)
        {
            _repo=repo;
        }


        public void OnGet()
        {
            ListFact = _repo.GetAll();
        }
    }
}
