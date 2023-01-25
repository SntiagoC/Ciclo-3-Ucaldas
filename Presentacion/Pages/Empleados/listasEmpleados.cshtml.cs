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
    
    public class listasEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado _repoEmpleados;
        public IEnumerable<Empleado> listasEmpleados {get; set;}

        public listasEmpleadosModel(IRepositorioEmpleado repoEmpleados)
        {
            _repoEmpleados = repoEmpleados;
        }

        public void OnGet()
        {
            listasEmpleados = _repoEmpleados.GetAllEmpleado();
        }
    }
}
