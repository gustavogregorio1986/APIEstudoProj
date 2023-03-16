using APIEstudoProj.Data.Repositorio.Interface;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Repositorio
{
    public class SalaRepositorio : GenericRepositorio<Sala>, ISalaRepositorio
    {
        public IEnumerable<Sala> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
