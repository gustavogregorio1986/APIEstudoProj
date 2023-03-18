using APIEstudoProj.Dominio.Dominio;
using APIEstudoProj.Models;
using APIEstudoProj.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public JsonResult CadatsrLogin(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LoginView loginView = new LoginView();
                    loginView.Usuario = login.Usuario;
                    loginView.Senha = login.Senha;
                    loginView.Perfil = login.Perfil;
                    loginServico.InserirLogin(login);
                }
            }
            catch(DataException)
            {

            }
   
            return new JsonResult(login); 
        }
    }
}
