using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.Clientes
{
    public class DetalleVehiculo : PageModel
    {
    private readonly IRepositorioVehiculo _repo;
    private readonly IRepositorioCliente _duenho;
        
        
        [BindProperty]
        public Cliente clientes {get;set;}

        public Vehiculo vehiculos {get;set;}

        public DetalleVehiculo(IRepositorioVehiculo repo,IRepositorioCliente duenho)
        {
            _repo=repo;
            _duenho=duenho;
        }

        public void OnGet(int id)
        {
            vehiculos= _repo.Get(id);
            clientes = _duenho.Get(vehiculos.ClienteId);   
           
        }
    }
}