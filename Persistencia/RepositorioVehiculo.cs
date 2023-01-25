using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
         private readonly ApplicationContext _appContext;

        public RepositorioVehiculo(ApplicationContext appliContext){
            _appContext=appliContext;
        }
        
        public Vehiculo Add(Vehiculo vehiculo){
            var new_Vehiculo = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return new_Vehiculo.Entity;
        }
        public IEnumerable<Vehiculo> GetAll(){
            return _appContext.Vehiculos;

        }
        public bool Delete(int IdVehiculo){
            var Vehiculoemcontrada = _appContext.Vehiculos.FirstOrDefault(p=> p.VehiculoId==IdVehiculo);
            if (Vehiculoemcontrada!=null)
            return false;
            _appContext.Remove(Vehiculoemcontrada);
            _appContext.SaveChanges();
            return true;

        }
        public Vehiculo Get(int IdVehiculo){
            return _appContext.Vehiculos.FirstOrDefault(p=>p.VehiculoId==IdVehiculo);
        }
        public Vehiculo Update(Vehiculo Vehiculo){
            var Vehiculoemcontrada = _appContext.Vehiculos.FirstOrDefault(p=>p.VehiculoId ==Vehiculo.VehiculoId);
            if(Vehiculoemcontrada!=null){
                Vehiculoemcontrada.Placa=Vehiculo.Placa;
                Vehiculoemcontrada.Marca=Vehiculo.Marca;
                Vehiculoemcontrada.Color=Vehiculo.Color;
                Vehiculoemcontrada.Modelo=Vehiculo.Modelo;
                Vehiculoemcontrada.TipoVehiculo=Vehiculo.TipoVehiculo;
                Vehiculoemcontrada.TipoCombustible=Vehiculo.TipoCombustible;
                Vehiculoemcontrada.Cilindraje=Vehiculo.Cilindraje;
                Vehiculoemcontrada.Kilometraje=Vehiculo.Kilometraje;
                Vehiculoemcontrada.Estado=Vehiculo.Estado;
                Vehiculoemcontrada.ClienteId=Vehiculo.ClienteId;
                
            }
            _appContext.SaveChanges();
            return Vehiculoemcontrada;
        }

    }
}