using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioServicios:IRepositorioServicios
    {
        private readonly ApplicationContext _appContext;

        public RepositorioServicios(ApplicationContext appContext){
            _appContext=appContext;
        }

        public Servicios AddServicios(Servicios servicios)
        {
            var servicioAdicionado=_appContext.servicios.Add(servicios);
            _appContext.SaveChanges();
            return servicioAdicionado.Entity;
        }

        public bool DeleteServicios(Servicios servicios)
        {
            var servicioEncontrado = _appContext.servicios.FirstOrDefault(s=>s.Id==servicios.Id);
            if (servicioEncontrado==null)
            {
                return false;
            }else{
                _appContext.Remove(servicios);
                _appContext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<Servicios> GetAllServicios()
        {
            return _appContext.servicios;
        }

        public Servicios GetServicios(int idServicios)
        {
            return _appContext.servicios.FirstOrDefault(s=>s.Id==idServicios);
        }

        public Servicios UpdateServicios(Servicios servicios)
        {
            var servicioEncontrado = _appContext.servicios.FirstOrDefault(s=>s.Id==servicios.Id);
            if (servicioEncontrado==null){
            return null;
            }else{
                servicioEncontrado=servicios;
                _appContext.SaveChanges();
                return servicioEncontrado;
            }
        }
    }
}