using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class NivelServico
    {
        private readonly NivertlRepositorio nivelRepositorio;

        public NivelServico()
        {
            nivelRepositorio = new NivertlRepositorio();
        }

        public void InserirNivel(Nivel nivel)
        {
            nivelRepositorio.Adicionar(nivel);
        }

        public List<Nivel> ListaNiveis()
        {
            return nivelRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            nivelRepositorio.Deletar(id);
        }

        public void Alterar(Nivel nivel)
        {
            nivelRepositorio.Atualizar(nivel);
        }

        public Nivel Buscar(int id)
        {
           return nivelRepositorio.Buscar(id, id);
        }
    }
}
