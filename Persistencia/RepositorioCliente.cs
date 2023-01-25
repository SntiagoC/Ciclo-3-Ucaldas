using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly ApplicationContext _appContext;

        public RepositorioCliente(ApplicationContext appliContext){
            _appContext=appliContext;
        }
        
        public Cliente Add(Cliente cliente){
            var new_Cliente = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_Cliente.Entity;
        }
        public IEnumerable<Cliente> GetAll(){
            return _appContext.Clientes;

        }
        public bool Delete(int IdCliente){
            var Clienteemcontrada = _appContext.Clientes.FirstOrDefault(p=> p.ClienteId==IdCliente);
            if (Clienteemcontrada==null)
            return false;
            _appContext.Remove(Clienteemcontrada);
            _appContext.SaveChanges();
            return true;

        }
        public Cliente Get(int IdCliente){
            return _appContext.Clientes.FirstOrDefault(p=>p.ClienteId==IdCliente);
        }
        
        public IEnumerable<Vehiculo> ObtenerVehiculos(int IdCliente){
            return _appContext.Vehiculos.Where(p=>p.ClienteId==IdCliente);
        }
        
        public Cliente Update(Cliente cliente){
            var Clienteemcontrada = _appContext.Clientes.FirstOrDefault(p=>p.ClienteId == cliente.ClienteId);
            if(Clienteemcontrada!=null){
                Clienteemcontrada.Nombres=cliente.Nombres;
                Clienteemcontrada.Apellidos=cliente.Apellidos;
                Clienteemcontrada.TipoDocumento=cliente.TipoDocumento;
                Clienteemcontrada.NumeroDocumento=cliente.NumeroDocumento;
                Clienteemcontrada.FechaNacimiento=cliente.FechaNacimiento;
                Clienteemcontrada.Telefono=cliente.Telefono;
                Clienteemcontrada.Direccion=cliente.Direccion;
                Clienteemcontrada.Email=cliente.Email;
                
            }
            _appContext.SaveChanges();
            return Clienteemcontrada;
        }

        public Factura ObtenerFactura(int IdCliente){
            return _appContext.Facturas.FirstOrDefault(p=>p.ClienteId==IdCliente);
        }

    }
}