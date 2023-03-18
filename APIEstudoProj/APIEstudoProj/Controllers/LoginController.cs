using APIEstudoProj.Dominio.Dominio;
using APIEstudoProj.Models;
using APIEstudoProj.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace APIEstudoProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginServico loginServico;

        public LoginController()
        {
            loginServico = new LoginServico();
        }

        [HttpPost]
        public JsonResult CadatsrLogin(LoginView loginView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loginView = new LoginView();
                    Login login = new Login();
                    loginView.Id = login.Id;
                    loginView.Usuario = login.Usuario;
                    loginView.Senha = login.Senha;
                    loginView.Perfil = login.Perfil;
                    loginServico.InserirLogin(login);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
   
            return new JsonResult(loginView); 
        }
    }
}
