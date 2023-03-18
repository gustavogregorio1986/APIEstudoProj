using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEstudoProj.Data.Migrations
{
    public partial class CriaraTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Aluno_tb_Login_Id_Login",
                        column: x => x.Id_Login,
                        principalTable: "tb_Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProfessor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailProfessor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Professor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Professor_tb_Login_Id_login",
                        column: x => x.Id_login,
                        principalTable: "tb_Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota1 = table.Column<double>(type: "float", nullable: false),
                    Nota2 = table.Column<double>(type: "float", nullable: false),
                    NotaRecuperacao = table.Column<double>(type: "float", nullable: false),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Avaliacao_tb_Aluno_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Aluno_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Nivel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Nivel_tb_Aluno_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Responsavel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailReponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_ALuno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Responsavel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Responsavel_tb_Aluno_Id_ALuno",
                        column: x => x.Id_ALuno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Turma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomreTurma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_ALuno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Turma_tb_Aluno_Id_ALuno",
                        column: x => x.Id_ALuno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Sala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroSala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Turma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Sala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Sala_tb_Turma_Id_Turma",
                        column: x => x.Id_Turma,
                        principalTable: "tb_Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aluno_Id_Login",
                table: "tb_Aluno",
                column: "Id_Login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Avaliacao_Id_Aluno",
                table: "tb_Avaliacao",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Aluno",
                table: "tb_Endereco",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Nivel_Id_Aluno",
                table: "tb_Nivel",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Professor_Id_login",
                table: "tb_Professor",
                column: "Id_login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Responsavel_Id_ALuno",
                table: "tb_Responsavel",
                column: "Id_ALuno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Sala_Id_Turma",
                table: "tb_Sala",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Turma_Id_ALuno",
                table: "tb_Turma",
                column: "Id_ALuno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Avaliacao");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Nivel");

            migrationBuilder.DropTable(
                name: "tb_Professor");

            migrationBuilder.DropTable(
                name: "tb_Responsavel");

            migrationBuilder.DropTable(
                name: "tb_Sala");

            migrationBuilder.DropTable(
                name: "tb_Turma");

            migrationBuilder.DropTable(
                name: "tb_Aluno");

            migrationBuilder.DropTable(
                name: "tb_Login");
        }
    }
}
