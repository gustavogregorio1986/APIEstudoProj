using APIEstudoProj.Data.Repositorio.Interface;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Repositorio
{
    public class LoginRepositorio : GenericRepositorio<Login>, ILoginRepositorio
    {
        public IEnumerable<Login> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
