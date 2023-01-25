using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace
{
    public class DetallesEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado _repoEmpleado;
        
        public Empleado Empleados {get; set; }

        public DetallesEmpleadosModel(IRepositorioEmpleado repoEmpleados)
        {
            _repoEmpleado=repoEmpleados;
        }
        public void OnGet(int Id)
        {
            Empleados = _repoEmpleado.GetEmpleado(Id);
        }
    }
}
