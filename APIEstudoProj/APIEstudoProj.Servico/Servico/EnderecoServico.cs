using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class EnderecoServico
    {
        private readonly EnderecoRepositorio enderecoRepositorio;

        public EnderecoServico()
        {
            enderecoRepositorio = new EnderecoRepositorio();
        }

        public void InserirEndereco(Endereco endereco)
        {
            enderecoRepositorio.Adicionar(endereco);
        }

        public List<Endereco> LstaEndereco()
        {
           return enderecoRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            enderecoRepositorio.Deletar(id);
        }

        public Endereco Buscar(int id)
        {
            return enderecoRepositorio.Buscar(id, id);
        }

        public void Alterar(Endereco endereco)
        {
            enderecoRepositorio.Atualizar(endereco);
        }
    }
}
