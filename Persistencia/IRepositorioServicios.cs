using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioServicios
    {
        IEnumerable<Servicios> GetAllServicios( );

        Servicios AddServicios(Servicios servicios);

        Servicios UpdateServicios(Servicios servicios);

        bool DeleteServicios(Servicios servicios);

        Servicios GetServicios(int idServicios);
    }
}