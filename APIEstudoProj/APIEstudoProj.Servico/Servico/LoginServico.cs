using APIEstudoProj.Data.Repositorio;
using APIEstudoProj.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Servico.Servico
{
    public class LoginServico
    {
        private readonly LoginRepositorio loginRepositorio;

        public LoginServico()
        {
            loginRepositorio = new LoginRepositorio();
        }

        public void InserirLogin(Login login)
        {
            loginRepositorio.Adicionar(login);
            
        }

        public List<Login> ListarLogin()
        {
            return loginRepositorio.ObterTodos();
        }

        public void Deletar(int id)
        {
            loginRepositorio.Deletar(id);
        }

        public void Alterar(Login login)
        {
            loginRepositorio.Atualizar(login);
        }

        public Login Buscar(int id)
        {
            return loginRepositorio.Buscar(id, id);
        }
    }
}
