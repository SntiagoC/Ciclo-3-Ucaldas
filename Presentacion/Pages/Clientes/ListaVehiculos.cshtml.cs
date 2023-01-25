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
    public class ListaVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repo;

        [BindProperty]
        public IEnumerable<Vehiculo> vehiculos {get;set;}

        public ListaVehiculosModel(IRepositorioVehiculo repo)
        {
            _repo=repo;
        }


        public void OnGet()
        {
            vehiculos = _repo.GetAll();
        }
    }
}
