using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
namespace Persistencia
{
    public interface IRepositorioVehiculo
    {
       Vehiculo Add(Vehiculo vehiculo);
       IEnumerable<Vehiculo> GetAll();
       Vehiculo Get(int IdVehiculo);
       bool Delete(int IdVehiculo);
       Vehiculo Update(Vehiculo vehiculo);

    }
}