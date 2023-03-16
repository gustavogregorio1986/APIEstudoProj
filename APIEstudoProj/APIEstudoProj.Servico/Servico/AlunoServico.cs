using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class AlunoServico
    {
        private readonly AlunoRepositorio alunoRepositorio;

        public AlunoServico()
        {
            alunoRepositorio = new AlunoRepositorio();
        }

        public void InserirAluno(Aluno aluno)
        {
            alunoRepositorio.Adicionar(aluno);
        }

        public List<Aluno> ListarAlunos()
        {
            return alunoRepositorio.ObterTodos();
        }

        public void Alterar(Aluno aluno)
        {
            alunoRepositorio.Atualizar(aluno);
        }

        public void Deletar(int id)
        {
            alunoRepositorio.Deletar(id);
        }

        public Aluno Buscar(int id)
        {
            return alunoRepositorio.Buscar(id, id);
        }
    }
}
