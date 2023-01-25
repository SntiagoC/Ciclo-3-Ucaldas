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
    public class DetalleClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        [BindProperty]

        public Cliente clientes {get;set;}

        public IEnumerable<Vehiculo> vehiculos {get;set;}

        public DetalleClienteModel(IRepositorioCliente repo)
        {
            _repo=repo;
        }

        public void OnGet(int id)
        {
            clientes = _repo.Get(id);    
            vehiculos= _repo.ObtenerVehiculos(id);
        }
    }
}
