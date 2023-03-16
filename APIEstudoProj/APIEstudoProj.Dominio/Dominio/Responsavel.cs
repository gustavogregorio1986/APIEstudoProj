using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Responsavel")]
    public class Responsavel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeResponsavel { get; set; }

        public string EmailReponsavel { get; set; }

        public string Telefone { get; set; }

        public string Cpf { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_ALuno { get; set; }
    }
}
