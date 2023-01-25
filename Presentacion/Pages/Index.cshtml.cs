using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio;
using Persistencia;

namespace Presentacion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEmpresa _repoEmp;
        [BindProperty]

        public Empresa empresa {get;set;}
       
        public IndexModel(IRepositorioEmpresa repoEmp)
        {
            _repoEmp = repoEmp;
        }

        public void OnGet()
        {
            
          empresa = _repoEmp.GetEmpresa(1);

        }


    }
}
