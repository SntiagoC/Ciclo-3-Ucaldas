using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Namespace
{
    public class EditarEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado _repoEmpleado;

        [BindProperty]
        public Empleado Empleados {get; set; }

        public EditarEmpleadosModel(IRepositorioEmpleado repoEmpleados)
        {
            _repoEmpleado=repoEmpleados;
        }
        public void OnGet(int Id)
        {
            Empleados = _repoEmpleado.GetEmpleado(Id);
        }

        
    }
}
