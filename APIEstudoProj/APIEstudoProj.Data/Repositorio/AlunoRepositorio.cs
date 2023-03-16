using APIEstudoProj.Data.Repositorio.Interface;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Repositorio
{
    public class AlunoRepositorio : GenericRepositorio<Aluno>, IAlunoRepositorio
    {
        public IEnumerable<Aluno> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
