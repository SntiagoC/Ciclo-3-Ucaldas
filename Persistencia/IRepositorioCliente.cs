using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioCliente
    {
       Cliente Add(Cliente cliente);
       IEnumerable<Cliente> GetAll();
       IEnumerable<Vehiculo> ObtenerVehiculos(int IdCliente);
       Cliente Get(int IdCliente);
       bool Delete(int IdCliente);
       Cliente Update(Cliente cliente);
       Factura ObtenerFactura(int IdCliente);

    }
}