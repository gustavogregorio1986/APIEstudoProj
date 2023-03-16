using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class TurmaServico
    {
        private readonly TurmaRepositorio turmaRepositorio;

        public TurmaServico()
        {
            turmaRepositorio = new TurmaRepositorio();
        }

        public void InserirTurma(Turma turma)
        {
            turmaRepositorio.Adicionar(turma);
        }

        public List<Turma> ListarTurmas()
        {
            return turmaRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            turmaRepositorio.Deletar(id);
        }

        public void Alterar(Turma turma)
        {
            turmaRepositorio.Atualizar(turma);
        }

        public Turma Buscar(int id)
        {
            return turmaRepositorio.Buscar(id, id);
        }
    }
}
