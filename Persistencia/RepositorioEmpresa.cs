using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpresa:IRepositorioEmpresa
    {
        private readonly ApplicationContext _appContext;

        public RepositorioEmpresa(ApplicationContext appContext){
            _appContext=appContext;
        }

        public Empresa AddEmpresa(Empresa empresa)
        {
            var empresaAdicionado=_appContext.empresa.Add(empresa);
            _appContext.SaveChanges();
            return empresaAdicionado.Entity;
        }

        public bool DeleteEmpresa(Empresa empresa)
        {
            var empresaEncontrado = _appContext.empresa.FirstOrDefault(m=>m.Id==empresa.Id);
            if (empresaEncontrado==null)
            {
                return false;
            }else{
                _appContext.Remove(empresa);
                _appContext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<Empresa> GetAllEmpresa()
        {
            return _appContext.empresa;
        }

        public Empresa GetEmpresa(int idEmpresa)
        {
            return _appContext.empresa.FirstOrDefault(m=>m.Id==idEmpresa);
        }

        public Empresa UpdateEmpresa(Empresa empresa)
        {
            var empresaEncontrado = _appContext.empresa.FirstOrDefault(m=>m.Id==empresa.Id);
            if (empresaEncontrado==null){
            return null;
            }else{
                empresaEncontrado=empresa;
                _appContext.SaveChanges();
                return empresaEncontrado;
            }
        }
    }
}