using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioFactura
    {
       
       Factura Add(Factura factura);
       IEnumerable<Factura> GetAll();
       Factura Get(int IdFactura);
       bool Delete(int IdFactura);
       Factura Update(Factura factura);
    }
}