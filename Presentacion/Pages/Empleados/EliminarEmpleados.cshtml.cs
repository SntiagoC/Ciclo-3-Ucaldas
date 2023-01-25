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
    public class EliminarEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado _repoEmpleado;
        
        public Empleado Empleados {get; set; }

        public bool caso {get;set;}

        public string cual {get;set;}

        public EliminarEmpleadosModel(IRepositorioEmpleado repoEmpleados)
        {
            _repoEmpleado=repoEmpleados;
        }
        public void OnGet(int Id)
        {
            Empleados=_repoEmpleado.GetEmpleado(Id);
            cual="Seguro de eliminar empleado?";
        }
        public void OnPost()
        {
            
               caso = _repoEmpleado.DeleteEmpleado(Empleados.Id);
                if(caso)
                {
                    cual="Empleado Borrado";
                }

        }
    }
}
