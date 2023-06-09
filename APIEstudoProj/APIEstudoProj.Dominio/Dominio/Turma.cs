﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIEstudoProj.Dominio.Dominio
{
    [Table("tb_Turma")]
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeTurma { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_ALuno { get; set; }

        public Turma()
        {

        }

        public Turma(int id, string nomeTurma)
        {
            this.Id = id;
            this.NomeTurma = nomeTurma;
        }

        public override string ToString()
        {
            return Id + "," + NomeTurma;
        }
    }
}
