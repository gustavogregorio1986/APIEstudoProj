using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class SalaServico
    {
        private readonly SalaRepositorio salaRepositorio;

        public SalaServico()
        {
            salaRepositorio = new SalaRepositorio();
        }

        public void InserirSala(Sala sala)
        {
            salaRepositorio.Adicionar(sala);
        }

        public List<Sala> ListaSalas()
        {
            return salaRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            salaRepositorio.Deletar(id);
        }

        public void Alterar(Sala sala)
        {
            salaRepositorio.Atualizar(sala);
        }

        public Sala Buscar(int id)
        {
            return salaRepositorio.Buscar(id, id);
        }
    }
}
