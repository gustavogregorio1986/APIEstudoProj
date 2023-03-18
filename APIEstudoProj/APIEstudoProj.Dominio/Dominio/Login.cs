using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }

        public Login()
        {

        }

        public Login(int id, string usuario, string senha, string perfil)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Perfil = perfil;
        }
    }
}
