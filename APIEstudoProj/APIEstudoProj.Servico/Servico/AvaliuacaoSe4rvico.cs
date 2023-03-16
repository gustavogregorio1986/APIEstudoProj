using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class AvaliuacaoSe4rvico
    {
        private readonly AlvaliacaoRepositorio avaliacaoRepositorio;

        public AvaliuacaoSe4rvico()
        {
            avaliacaoRepositorio = new AlvaliacaoRepositorio();
        }

        public void InserirAvaliacao(Avaliacao avaliacao)
        {
            avaliacaoRepositorio.Adicionar(avaliacao);
        }

        public List<Avaliacao> ListaAvaliacao()
        {
            return avaliacaoRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            avaliacaoRepositorio.Deletar(id);
        }

        public void Alterar(Avaliacao avaliacao)
        {
            avaliacaoRepositorio.Atualizar(avaliacao);
        }

        public Avaliacao Buscar(int id)
        {
           return avaliacaoRepositorio.Buscar(id, id);
        }
    }
}
