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
    public class NuevoVehiculoModel : PageModel
    {
       private readonly IRepositorioVehiculo _repo;
       private readonly IRepositorioCliente _lista;

        [BindProperty]
        public Vehiculo vehiculos {get;set;}
        [BindProperty]
        public IEnumerable<Cliente> clientes {get;set;}
        public string Titulo {get;set;}

        public NuevoVehiculoModel(IRepositorioVehiculo repo, IRepositorioCliente lista)
        {
            _repo=repo;
            _lista=lista;
        }


        public void OnGet()
        {
            vehiculos = new Vehiculo();
            clientes=_lista.GetAll();
            Titulo="Nuevo Vehiculo";
        }

        public void OnPost()
        {
            vehiculos = _repo.Add(vehiculos);
        }

    }
}
