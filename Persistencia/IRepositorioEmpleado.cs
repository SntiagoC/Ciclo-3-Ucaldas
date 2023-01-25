using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {

        IEnumerable<Empleado> GetAllEmpleado( );

        Empleado AddEmpleado(Empleado empleado);

        Empleado UpdateEmpleado(Empleado empleado);

        bool DeleteEmpleado(int empleado);

        Empleado GetEmpleado(int idEmpleado);
        
    }
}