using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VestBooks.Migrations
{
    /// <inheritdoc />
    public partial class AddPerguntasEFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Foto = table.Column<string>(type: "longtext", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.AutorId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "faculdade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculdade", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario_login",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_login", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_usuario_login_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario_regra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_regra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_regra_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario_token",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_token", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_usuario_token_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FaculdadeId = table.Column<int>(type: "int", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true),
                    Publicacao = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true),
                    Avaliacao = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.LivroId);
                    table.ForeignKey(
                        name: "FK_livro_autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "autor",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_livro_faculdade_FaculdadeId",
                        column: x => x.FaculdadeId,
                        principalTable: "faculdade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pergunta",
                columns: table => new
                {
                    PerguntaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Enunciado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FaculdadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pergunta", x => x.PerguntaId);
                    table.ForeignKey(
                        name: "FK_pergunta_faculdade_FaculdadeId",
                        column: x => x.FaculdadeId,
                        principalTable: "faculdade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "perfil_regra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil_regra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_perfil_regra_perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario_perfil",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_perfil", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_usuario_perfil_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_perfil_perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "faculdadeLivro",
                columns: table => new
                {
                    FaculdadeLivroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FaculdadeId = table.Column<int>(type: "int", nullable: false),
                    LivroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculdadeLivro", x => x.FaculdadeLivroId);
                    table.ForeignKey(
                        name: "FK_faculdadeLivro_faculdade_FaculdadeId",
                        column: x => x.FaculdadeId,
                        principalTable: "faculdade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_faculdadeLivro_livro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "livro",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "perguntaAlternativa",
                columns: table => new
                {
                    PerguntaAlternativaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PerguntaId = table.Column<int>(type: "int", nullable: false),
                    Correta = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntaAlternativa", x => x.PerguntaAlternativaId);
                    table.ForeignKey(
                        name: "FK_perguntaAlternativa_pergunta_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "pergunta",
                        principalColumn: "PerguntaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "Foto", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "3cfd5842-3994-4f71-9011-87e209137291", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "gallojunior@gmail.com", true, "/img/usuarios/ddf093a6-6cb5-4ff7-9a64-83da34aee005.png", true, null, "José Antonio Gallo Junior", "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAIAAYagAAAAEPgzQAy7+Z3yfD1UOj0NPOqufbimIL2+Q6zCrZVDXnmzfF1hsKZV15AMFXhJMwL9+Q==", null, false, "5c2cb333-355f-41a1-9fa0-e325cefa9011", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "autor",
                columns: new[] { "AutorId", "Foto", "Nome" },
                values: new object[,]
                {
                    { 1, "/img/autores/Jorge Amado.png", "Jorge Amado" },
                    { 2, "/img/autores/Machado de Assis.png", "Machado de Assis" },
                    { 3, "/img/autores/Manuel Bandeira.png", "Manuel Bandeira" },
                    { 4, "/img/autores/João Guimarães Rosa.png", "João Guimarães Rosa" },
                    { 5, "/img/autores/José de Alencar.png", "José de Alencar" },
                    { 6, "/img/autores/Luis de Camões.png", "Luis de Camões" },
                    { 7, "/img/autores/Carolina Maria de Jesus.png", "Carolina Maria de Jesus" },
                    { 8, "/img/autores/Carlos drummond de Andrade.png", "Carlos drummond de Andrade" },
                    { 9, "/img/autores/Darcy Ribeiro.png", "Darcy Ribeiro" },
                    { 10, "/img/autores/Graciliano Ramos.png", "Graciliano Ramos" },
                    { 11, "/img/autores/Aluísio Azevedo.png", "Aluísio Azevedo" },
                    { 12, "/img/autores/José Paulo Paes.png", "José Paulo Paes" },
                    { 13, "/img/autores/Conceição Evaristo.png", "Conceição Evaristo" },
                    { 14, "/img/autores/Ailton Krenak.png", "Ailton Krenak" },
                    { 15, "/img/autores/Lima Barreto.png", "Lima Barreto" },
                    { 16, "/img/autores/Chimamanda Ngozi Adichie.png", "Chimamanda Ngozi Adichie" },
                    { 17, "/img/autores/Caio Fernando Abreu.png", "Caio Fernando Abreu" },
                    { 18, "/img/autores/Cartola.png", "Cartola" },
                    { 19, "/img/autores/Lewis Carroll.png", "Lewis Carroll" },
                    { 20, "/img/autores/Djamilia Pereira de Almdeida.png", "Djamilia Pereira de Almdeida" },
                    { 21, "Lygia Fagundes Telles.png", "Lygia Fagundes Telles" },
                    { 22, "/img/autores/Paulina Chiziane.png", "Paulina Chiziane" },
                    { 23, "/img/autores/Rachel de Queiroz.png", "Rachel de Queiroz" },
                    { 24, "/img/autores/Conceição Evaristo.png", "Conceição Evaristo" },
                    { 25, "/img/autores/Julia Lopes de Almeida.png", "Julia Lopes de Almeida" },
                    { 26, "/img/autores/Narcisa Amália.png", "Narcisa Amália" },
                    { 27, "/img/autores/Sophia de Mello Breyner Andresen.png", "Sophia de Mello Breyner Andresen" },
                    { 28, "/img/autores/Nísia Floresta.png", "Nísia Floresta" }
                });

            migrationBuilder.InsertData(
                table: "faculdade",
                columns: new[] { "Id", "Descricao", "Foto", "Nome" },
                values: new object[,]
                {
                    { 1, "Anualmente, o Exame Nacional do Ensino Médio (Enem) aplica questões com foco em obras\r\n            literárias brasileiras. Entretanto, o órgão que desenvolve a prova (Inep) não fornece uma lista de\r\n            leituras, mas é preciso saber quais livros provavelmente estarão presentes no exame e, assim, adotar\r\n            algumas leituras obrigatórias.\r\n            <br><br>\r\n            Como o Enem exige dos candidatos uma série de conhecimentos literários (tudo o que aprenderam no Ensino\r\n            Médio), espera-se do candidato que ele conheça as principais obras de cada escola literária.\r\n            <br><br>\r\n            A prova de Linguagens, Códigos e suas Tecnologias do Enem , por exemplo, pede que você conheça a\r\n            importância do autor/obra para a sociedade e para a cultura em geral.\r\n            Por isso, é fundamental conhecer as principais obras, autores e como eles influenciaram tudo o que veio\r\n            depois.", "/img/faculdades/ENEM.png", "ENEM" },
                    { 2, "O vestibular para ingressar na Unicamp, uma das maiores e mais conceituadas\r\n              universidades do país, está marcado para 20 de outubro. Além de todas as\r\n              disciplinas cobradas no Ensino Médio, o edital estipula uma lista de 8 livros de\r\n              leitura obrigatória.\r\n              <br><br>\r\n              O objetivo da Comvest (Comissão Permanente para os Vestibulares da Unicamp)\r\n              ao fazer esta lista, é estimular a leitura e o olhar atento dos estudantes para as\r\n              questões do mundo contemporâneo, então livros como “A vida não é útil“ de\r\n              Ailton Krenak e “Niketche – uma História de Poligamia“ de Paulina Chiziane estão\r\n              ao lado de “Casa Velha“ de Machado de Assis, por exemplo.", "/img/faculdades/UNICAMP.png", "UNICAMP" },
                    { 3, "", "/img/faculdades/USP.png", "USP" },
                    { 4, null, "/img/faculdades/UNESP.png", "UNESP" }
                });

            migrationBuilder.InsertData(
                table: "perfil",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrador", "ADMINISTRADOR" },
                    { "2", null, "Funcionário", "FUNCIONÁRIO" },
                    { "3", null, "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "livro",
                columns: new[] { "LivroId", "AutorId", "Avaliacao", "Descricao", "Destaque", "FaculdadeId", "Foto", "Nome", "Publicacao" },
                values: new object[,]
                {
                    { 1, 1, "4", "A narrativa explora a paixão de Dona Flor por seus dois maridos, mostrando como ela lida com as diferenças entre eles e como busca a felicidade em meio a um triângulo amoroso.", true, 1, "/img/livros/Dona Flor e seus dois maridos.png", "Dona flor e seus dois maridos", "1966" },
                    { 2, 2, "4,8", "é um romance de Machado de Assis que conta a história de Bento Santiago, um homem que, já velho, decide escrever um livro para narrar sua versão dos acontecimentos de sua juventude.", true, 1, "/img/livros/Dom Casmurro.png", "Dom Casmurro", "1899" },
                    { 3, 1, "4,8", "A história se passa em Salvador, Bahia, e retrata a vida de um grupo de meninos de rua que vivem em um trapiche abandonado, enfrentam a miséria, a violência e sobrevivem roubando e praticando pequenos crimes, mas também demonstram um forte senso de união e solidariedade.", true, 1, "/img/livros/Capitães De Areia .png", "Capitães da Areia", "1937" },
                    { 4, 3, "4,7", "é um livro de poemas que reúne todos os livros de poesia do autor, desde o seu primeiro, A Cinza das Horas, até os poemas que escreveu ao longo de sua vida.", true, 1, "/img/livros/Estrelas Da Vida Inteira.png", "Estrela da vida inteira", "1965" },
                    { 5, 4, "4,9", "conta a história de amor entre Riobaldo e Diadorim (ou Reinaldo). O ex-jagunço Riobaldo relata, para um interlocutor não nomeado na obra, fatos de sua juventude em meio a um bando de jagunços.", true, 1, "/img/livros/Grande Sertão Veredas.png", "Grande Sertão: Veredas", "1956 " },
                    { 6, 1, "4,8", "A obra narra o caso de amor entre o árabe Nacib e a sertaneja Gabriela, como pano de fundo o período áureo do cacau na região de Ilhéus, descrevendo as alterações profundas da vida social da Bahia da década de 1920.", true, 1, "/img/livros/Gabriela,cravo e canela.png", "Gabriela Cravo e Canela", "1958" },
                    { 7, 5, "4,6", "O romance conta o amor de um branco, Martim Soares Moreno, pela índia Iracema, a virgem dos lábios de mel. A relação do casal serviria de alegoria para a formação da nação brasileira. A índia Iracema representaria a natureza virgem e a inocência enquanto o colonizador Martim representa a cultura (europeia).", true, 1, "/img/livros/iracema.png", "Iracema", "1865" },
                    { 8, 2, "4,8", "Brás Cubas decide narrar sua própria vida após a morte. A narrativa começa com sua agonia e enterro, e retrocede para sua infância, juventude e vida adulta. O livro é uma crítica à sociedade da época, com seus costumes, valores e hipocrisias.", true, 1, "/img/livros/Memórias Póstumas de Brás Cubas.png", "Memórias Póstumas de Brás Cubas", "1880" },
                    { 9, 6, "4,7", "Os sonetos de Camões abordam uma variedade de temas, com destaque para o amor, a paixão, a saudade, a melancolia, a fé e a reflexão sobre a vida e a morte. Sua poesia é um retrato da alma humana, com suas alegrias, tristezas, esperanças e desilusões.", true, 1, "/img/livros/Sonetos De Camões.png", "Sonetos", "1595" },
                    { 10, 7, "4,9", "O livro é um diário em que Carolina Maria de Jesus narra seu cotidiano, descrevendo as dificuldades que enfrenta como mãe solteira de três filhos, trabalhando como catadora de papel e enfrentando a falta de recursos para suprir as necessidades básicas da família.", true, 1, "/img/livros/Quarto De Despejo.png", "Quarto de Despejo", "1960" },
                    { 11, 8, "3,8", "O momento em que o país vivia a Era Vargas é a mais cobrada no ENEM. Isso acontece porque ela reflete o engajamento social e político do poeta, características que costumam ser muito bem aproveitadas", true, 1, "/img/livros/Poesia Completa Carlos Drummond De Andrade.png", "Poesia Completa", "" },
                    { 12, 9, "4,9", "A obra busca responder à pergunta: quem são os brasileiros? mergulhando na história do Brasil, analisando as matrizes culturais, os mecanismos de formação étnica e cultural, os conflitos e as contradições.", true, 1, "/img/livros/O Povo Brasileiro.png", "O povo brasileiro", "1995" },
                    { 13, 10, "4,8", "A história acompanha a saga de Fabiano, Sinhá Vitória e seus dois filhos, além da cachorra Baleia, em busca de melhores condições de vida. A família enfrenta a seca, a fome, a violência e a injustiça social, sendo constantemente humilhada e explorada pelos proprietários de terra.", true, 1, "/img/livros/Vidas Secas.png", "Vidas Secas", "1938" },
                    { 14, 11, "4,7", "O Cortiço é um romance naturalista que retrata a vida de pessoas pobres que viviam em cortiços no Rio de Janeiro no final do século XIX. O livro denuncia a exploração e as péssimas condições de vida dos moradores.", true, 1, "/img/livros/o cortiço.png", "O Cortiço", "1890" },
                    { 15, 12, "4,8", "é um livro composto por: Prosas: Vinte textos em prosa poética que abordam temas diversos marcados pela concisão, pela ironia e pelo humor, e Odes Mínimas: Treze poemas curtos, concisos e minimalistas, que exploram os temas das prosas,com uma linguagem depurada e essencial. Os poemas são marcados pela reflexão, pela ironia e pela brevidade.", true, 2, "/img/livros/Prosas seguidas de odes mínimas.png", "Prosas seguidas de odes mínimas", "1992" },
                    { 16, 13, "4,8", "Olhos d'água é um livro de contos da escritora Conceição Evaristo que aborda a vida de pessoas negras e afro-brasileiras.A metáfora dos olhos d'água simboliza a união estabelecida entre passado, presente e futuro", true, 2, "/img/livros/Olhos d'água.png", "Olhos d’água", "2014" },
                    { 17, 14, "4,8", "é um livro que questiona o sistema capitalista, o consumismo e a destruição ambiental. Composto por cinco textos: Não se come dinheiro, Sonhos para adiar o fim do mundo, A máquina de fazer coisas, O amanhã não está à venda, A vida não é útil.", true, 2, "/img/livros/A vida não é útil.png", "A vida não é útil", "2020" },
                    { 18, 2, "4,6", "Casa Velha é um romance de Machado de Assis que aborda temas como o poder das normas sociais, a ascensão social e as relações de poder entre as classes sociais", true, 2, "/img/livros/Casa Velha.png", "Casa Velha", "1886" },
                    { 19, 15, "4,5", "Vida e morte de M.J Gonzaga de Sá é um livro que conta a história de um jornalista negro que vive no Rio de Janeiro no início do século XX, o qual aborda temas como: Desigualdade social, Racismo, Corrupção política, Abandono das populações periféricas, Burocratização do Estado.", true, 2, "/img/livros/Vida e morte de M.J Gonzaga de Sá.png", "Vida e morte de M.J Gonzaga de Sá", "1919" },
                    { 20, 16, "4,2", "No seu pescoço é um livro que aborda temas  sobre injustiça social, desigualdade de gênero, sonho, nostalgia, racismo e preconceito contra imigrantes de forma combativa, sem ser abusiva", true, 2, "/img/livros/No seu pescoço.png", "No Seu Pescoço", "2017" },
                    { 21, 17, "4,6", "Morangos Mofados é um livro de contos que retratam a angústia, a solidão, a repressão e a busca por liberdade de jovens na década de 1970, durante a ditadura militar no Brasil.", true, 2, "/img/livros/Morangos mofados.png", "Morangos mofados", "1982" },
                    { 22, 18, null, "As canções escolhidas de Cartola são Alvorada, As rosas não falam, Cordas de aço, Disfarça e chora, O inverno do meu tempo, O mundo é um moinho, Que é feito de você?, Sala de recepção, Silêncio de um cipreste e Sim", true, 2, "/img/livros/Canções Escolhida - Cartola.png", "Canções Escolhidas", "" },
                    { 23, 19, "4,8", "é uma história sobre uma menina que sonha que cai numa toca de coelho e acaba num mundo mágico. Lá, ela vive aventuras e se depara com o absurdo, o impossível e questiona tudo o que aprendeu até ali", true, 2, "/img/livros/Alice no país das maravilhas.png", "Alice no país das maravilhas", "1865 " },
                    { 24, 20, "3,5", "A obra conta a história de Celestino, homem cujo passado de brutalidade e violência assombrosas é substituído, no crepúsculo da vida, por um amor delicado e cuidadoso pelas plantas de seu jardim.", true, 3, "/img/livros/A visão das plantas.png", "A visão das plantas", "2019" },
                    { 25, 21, "4,2", "O livro acompanha a jornada de três jovens mulheres universitárias no início da década de 70. Lorena, Ana Clara e Lia são de mundos distantes, vivendo impasses, cada qual com seu próprio drama durante o período turbulento da ditadura.", true, 3, "/img/livros/As meninas.png", "As meninas", "1973" },
                    { 26, 22, "4", "A obra conta a história de amor entre Sarnau e Mwando, na qual faz uma crítica à poligamia e às tradições machistas e patriarcais que afetam a vida das mulheres.", true, 3, "/img/livros/Balada de amor ao vento.png", "Balada de amor ao vento", "1990" },
                    { 27, 23, "3,5", "Na Fortaleza dos anos 1930, durante a Era Vargas, Roberto tem a missão de recrutar operários para uma nova célula de esquerda. Uma das pessoas que se interessam é Noemi: mãe de Guri e casada com um homem que não ama mais, ela está em busca de algo que a faça se sentir viva.", true, 3, "/img/livros/Caminho de Pedras.png", "Caminho de pedras", "1937" },
                    { 28, 24, "4,2", "A obra questiona o patriarcado e as construções sociais da masculinidade, é um retrato de um homem através dos relacionamentos que ele coleciona com várias mulheres negras.", true, 3, "/img/livros/Canção para Ninar Menino grande.png", "Canção para ninar menino grande", "2018" },
                    { 29, 25, "3,5", "A obra narra a história de uma jovem chamada Marta, que viveu no Rio de Janeiro no final do século XIX, é uma autobiografia ficcional que retrata as dificuldades enfrentadas por Marta e sua mãe, viúva.", true, 3, "/img/livros/Memórias de Martha.png", "Memórias de Martha", "1899" },
                    { 30, 26, "3", "Seus poemas revelam uma voz lírica única, que aborda temas íntimos, femininos e ligados à natureza, ao mesmo tempo em que expressam uma preocupação social evidente, especialmente em relação à abolição da escravatura, uma questão presente na sociedade brasileira do século XIX.", true, 3, "/img/livros/Nebulosas.png", "Nebulosas", "2024" },
                    { 31, 27, "3,7", "O livro é composto por uma série de poemas que contam a história de uma lenda sobre o assassinato de um cigano e a construção de uma imagem de Cristo.", true, 3, "/img/livros/O cristo cigano.png", "O cristo cigano", "1961" },
                    { 32, 28, "3,6", "A obra traça a evolução das condições femininas e mostram a experiência da autora tanto em leitura, quanto em vivências em suas viagens.", true, 3, "/img/livros/Opúsculo Humanitário.png", "Opúsculo Humanitário", "1853" }
                });

            migrationBuilder.InsertData(
                table: "usuario_perfil",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "1" },
                    { "3", "1" }
                });

            migrationBuilder.InsertData(
                table: "faculdadeLivro",
                columns: new[] { "FaculdadeLivroId", "FaculdadeId", "LivroId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 1, 11 },
                    { 12, 1, 12 },
                    { 13, 1, 13 },
                    { 14, 1, 14 },
                    { 15, 2, 15 },
                    { 16, 2, 16 },
                    { 17, 2, 17 },
                    { 18, 2, 18 },
                    { 19, 2, 19 },
                    { 20, 2, 20 },
                    { 21, 2, 21 },
                    { 22, 2, 22 },
                    { 23, 2, 23 },
                    { 24, 3, 24 },
                    { 25, 3, 25 },
                    { 26, 3, 26 },
                    { 27, 3, 27 },
                    { 28, 3, 28 },
                    { 29, 3, 29 },
                    { 30, 3, 30 },
                    { 31, 3, 31 },
                    { 32, 3, 32 }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_faculdadeLivro_FaculdadeId",
                table: "faculdadeLivro",
                column: "FaculdadeId");

            migrationBuilder.CreateIndex(
                name: "IX_faculdadeLivro_LivroId",
                table: "faculdadeLivro",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_livro_AutorId",
                table: "livro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_livro_FaculdadeId",
                table: "livro",
                column: "FaculdadeId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "perfil",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_perfil_regra_RoleId",
                table: "perfil_regra",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_pergunta_FaculdadeId",
                table: "pergunta",
                column: "FaculdadeId");

            migrationBuilder.CreateIndex(
                name: "IX_perguntaAlternativa_PerguntaId",
                table: "perguntaAlternativa",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_login_UserId",
                table: "usuario_login",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_perfil_RoleId",
                table: "usuario_perfil",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_regra_UserId",
                table: "usuario_regra",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "faculdadeLivro");

            migrationBuilder.DropTable(
                name: "perfil_regra");

            migrationBuilder.DropTable(
                name: "perguntaAlternativa");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "usuario_login");

            migrationBuilder.DropTable(
                name: "usuario_perfil");

            migrationBuilder.DropTable(
                name: "usuario_regra");

            migrationBuilder.DropTable(
                name: "usuario_token");

            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "pergunta");

            migrationBuilder.DropTable(
                name: "perfil");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropTable(
                name: "faculdade");
        }
    }
}
