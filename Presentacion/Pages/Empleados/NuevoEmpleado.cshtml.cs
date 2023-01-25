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
    public class NuevoEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repo;
        
        [BindProperty]
        public Empleado empleado {get;set;}

        public string Titulo {get;set;}

        public NuevoEmpleadoModel(IRepositorioEmpleado repollo)
        {
            repo =repollo;
        }


        public void OnGet(int? id)
        {
            if (id.HasValue)
            {              
            empleado=repo.GetEmpleado(id.Value);
            Titulo=empleado.Nombres;
            }else
           
            {
            empleado=new Empleado();
            Titulo="Nuevo Empleado";
            }
        }

        public void OnPost()
        {
            
            if(empleado.Id==0){
                empleado=repo.AddEmpleado(empleado);
                
            }else{
                empleado=repo.UpdateEmpleado(empleado);
              
            }
        }
    }
}
