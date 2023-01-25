using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<Empresa> GetAllEmpresa( );

        Empresa AddEmpresa(Empresa empresa);

        Empresa UpdateEmpresa(Empresa empresa);

        bool DeleteEmpresa(Empresa empresa);

        Empresa GetEmpresa(int idEmpresa);
    }
}