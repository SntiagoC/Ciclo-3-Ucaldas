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
    public class NuevaFacturaModel : PageModel
    {
       private readonly IRepositorioFactura _repo;

        [BindProperty]
        public Factura facturas {get;set;}
        public string Titulo {get;set;}

        public NuevaFacturaModel(IRepositorioFactura repo)
        {
            _repo=repo;
        }


        public void OnGet()
        {
            facturas = new Factura();
            Titulo="Nueva Factura";
        }

        public void OnPost()
        {
            facturas = _repo.Add(facturas);
        }

    }
}
