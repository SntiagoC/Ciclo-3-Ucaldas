using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioFactura:IRepositorioFactura
    {
                private readonly ApplicationContext _appContext;

        public RepositorioFactura(ApplicationContext appliContext){
            _appContext=appliContext;
        }
        
        public Factura Add(Factura Factura){
            var new_Factura = _appContext.Facturas.Add(Factura);
            _appContext.SaveChanges();
            return new_Factura.Entity;
        }
        public IEnumerable<Factura> GetAll(){
            return _appContext.Facturas;

        }
        public bool Delete(int IdFactura){
            var Facturaemcontrada = _appContext.Facturas.FirstOrDefault(p=> p.FacturaId==IdFactura);
            if (Facturaemcontrada!=null)
            return false;
            _appContext.Remove(Facturaemcontrada);
            _appContext.SaveChanges();
            return true;

        }
        public Factura Get(int IdFactura){
            return _appContext.Facturas.FirstOrDefault(p=>p.FacturaId==IdFactura);
        }
        public Factura Update(Factura Factura){
            var Facturaemcontrada = _appContext.Facturas.FirstOrDefault(p=>p.FacturaId ==Factura.FacturaId);
            if(Facturaemcontrada!=null){
                Facturaemcontrada.Servicios=Factura.Servicios;
                Facturaemcontrada.Cliente=Factura.Cliente;
                Facturaemcontrada.FechaFactura=Factura.FechaFactura;
                Facturaemcontrada.ValorTotal=Factura.ValorTotal;
                Facturaemcontrada.MetodoPago=Factura.MetodoPago;
                
            }
            _appContext.SaveChanges();
            return Facturaemcontrada;
        }


    }
}