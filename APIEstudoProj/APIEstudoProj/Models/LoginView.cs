namespace APIEstudoProj.Models
{
    public class LoginView
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }

        public LoginView()
        {

        }

        public LoginView(int Id, string usuario, string senha, string perfil)
        {
            this.Id = Id;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Perfil = perfil;
        }
    }
}
