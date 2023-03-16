using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Professor")]
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeProfessor { get; set; }

        public string EmailProfessor { get; set; }

        public Login Login { get; set; }

        [ForeignKey("Login")]
        public int Id_login { get; set; }
    }
}
