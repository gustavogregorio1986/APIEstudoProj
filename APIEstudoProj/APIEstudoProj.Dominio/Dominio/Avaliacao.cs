using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Avaliacao")]
    public class Avaliacao
    {
        public int Id { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double NotaRecuperacao { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_Aluno { get; set; }
    }
}
