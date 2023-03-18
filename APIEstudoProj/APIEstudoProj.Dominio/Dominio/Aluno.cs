using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{

    [Table("tb_Aluno")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeAluno { get; set; }

        public string EmailAluno { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public Login Login { get; set; }

        [ForeignKey("Login")]
        public int Id_Login { get; set; }

        public Aluno()
        {

        }

        public Aluno(int id, string nomeAluno, string emailAluno, string sexo, string cpf)
        {
            this.Id = id;
            this.NomeAluno = nomeAluno;
            this.EmailAluno = emailAluno;
            this.Sexo = sexo;
            this.Cpf = cpf;
        }
    }
}
