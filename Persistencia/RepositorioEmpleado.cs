using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpleado:IRepositorioEmpleado
    {
        private readonly ApplicationContext _appContext;

        public RepositorioEmpleado(ApplicationContext appContext){
            _appContext=appContext;
        }

        public Empleado AddEmpleado(Empleado empleado)
        {
            var empleadoAdicionado=_appContext.empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        public bool DeleteEmpleado(int empleado)
        {
            var empleadoEncontrado = _appContext.empleados.FirstOrDefault(e=>e.Id==empleado);
            if (empleadoEncontrado==null)
            
            {
                return false;
            }else{
                _appContext.Remove(empleado);
                _appContext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.empleados;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            return _appContext.empleados.FirstOrDefault(e=>e.Id==idEmpleado);
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.empleados.FirstOrDefault(e=>e.Id==empleado.Id);
            if (empleadoEncontrado==null){
            return null;
            }else{
                empleadoEncontrado=empleado;
                _appContext.SaveChanges();
                return empleadoEncontrado;
            }
        }
    }
}