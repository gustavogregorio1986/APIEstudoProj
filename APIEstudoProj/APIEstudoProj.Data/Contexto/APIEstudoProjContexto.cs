using APIEstudoProj.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Contexto
{
    public class APIEstudoProjContexto : DbContext 
    {
        public APIEstudoProjContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Aluno> alunos { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Nivel> Nivels { get; set; }

        public DbSet<Professor> Processores { get; set; }

        public DbSet<Responsavel> Responsaveis { get; set; }

        public DbSet<Sala> Salas { get; set; }

        public DbSet<Turma> Turmas { get; set; }
    }
}
