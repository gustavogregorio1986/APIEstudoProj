using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_Aluno { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, string bairro, string cidade, string cep)
        {
            this.Id = id;
            this.Logradouro = logradouro;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
        }

        public override string ToString()
        {
            return Id + "," + Logradouro + "," + Bairro + "," + Cidade + "," + Cep;
        }
    }
}
