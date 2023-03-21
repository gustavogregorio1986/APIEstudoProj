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

        public Avaliacao()
        {

        }

        public Avaliacao(int id, double nota1, double nota2, double notaRecuperacao)
        {
            this.Id = id;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaRecuperacao = notaRecuperacao;
        }

        public override string ToString()
        {
            return Id + "," + Nota1 + "," + Nota2 + "," + NotaRecuperacao;
        }
    }
}
