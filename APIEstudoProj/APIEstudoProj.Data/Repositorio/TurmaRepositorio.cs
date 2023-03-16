using APIEstudoProj.Data.Repositorio.Interface;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Repositorio
{
    public class TurmaRepositorio : GenericRepositorio<Turma>, ITurmaRepositorio
    {
        public IEnumerable<Sala> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
