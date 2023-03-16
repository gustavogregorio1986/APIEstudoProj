﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Nivel")]
    public class Nivel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Serie { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_Aluno { get; set; }
    }
}