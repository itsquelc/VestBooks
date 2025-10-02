using VestBooks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace VestBooks.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Faculdade> faculdades = new()
        {
            new Faculdade { FaculdadeId = 1, Nome = "ENEM", Foto = "/img/faculdades/ENEM.png" },
            new Faculdade { FaculdadeId = 2, Nome = "UNICAMP", Foto = "/img/faculdades/UNICAMP.png" },
            new Faculdade { FaculdadeId = 3, Nome = "USP", Foto = "/img/faculdades/USP.png" },
            new Faculdade { FaculdadeId = 4, Nome = "UNESP", Foto = "/img/faculdades/UNESP.png" },
        };
        builder.Entity<Faculdade>().HasData(faculdades);


        List<Autor> autores = new()
        {
            new Autor { AutorId = 1, Nome = "Jorge Amado" },
            new Autor { AutorId = 2, Nome = "Machado de Assis" },
            new Autor { AutorId = 3, Nome = "Manuel Bandeira" },
            new Autor { AutorId = 4, Nome = "João Guimarães Rosa" },
            new Autor { AutorId = 5, Nome = "José de Alencar" },
            new Autor { AutorId = 6, Nome = "Luís de Camões" },
            new Autor { AutorId = 7, Nome = "Carolina Maria de Jesus" },
            new Autor { AutorId = 8, Nome = "Carlos drummond de Andrade" },
            new Autor { AutorId = 9, Nome = "Darcy Ribeiro" },
            new Autor { AutorId = 10, Nome = "Graciliano Ramos" },
            new Autor { AutorId = 11, Nome = "Aluísio Azevedo" },
            new Autor { AutorId = 12, Nome = "José Paulo Paes" },
            new Autor { AutorId = 13, Nome = "Conceição Evaristo" },
            new Autor { AutorId = 14, Nome = "Ailton Krenak" },
            new Autor { AutorId = 15, Nome = "Lima Barreto" },
            new Autor { AutorId = 16, Nome = "Chimamanda Ngozi Adichie" },
            new Autor { AutorId = 17, Nome = "Caio Fernando Abreu" },
            new Autor { AutorId = 18, Nome = "Cartola" },
            new Autor { AutorId = 19, Nome = "Lewis Carroll" },
            new Autor { AutorId = 20, Nome = "Djamilia Pereira de Almdeida" },
            new Autor { AutorId = 21, Nome = "Lygia Fagundes Telles" },
            new Autor { AutorId = 22, Nome = "Paulina Chiziane" },
            new Autor { AutorId = 23, Nome = "Rachel de Queiroz" },
            new Autor { AutorId = 24, Nome = "Conceição Evaristo" },
            new Autor { AutorId = 25, Nome = "Julia Lopes de Almeida" },
            new Autor { AutorId = 26, Nome = "Narcisa Amália" },
            new Autor { AutorId = 27, Nome = "Sophia de Mello Breyner Andresen" },
            new Autor { AutorId = 28, Nome = "Nísia Floresta" },


        };

        builder.Entity<Autor>().HasData(autores);

        List<Livro> livros = new List<Livro>

             {
            // ENEM
    new Livro { LivroId = 1, FaculdadeId = 1, Nome = "Dona flor e seus dois maridos", Descricao = "A narrativa explora a paixão de Dona Flor por seus dois maridos, mostrando como ela lida com as diferenças entre eles e como busca a felicidade em meio a um triângulo amoroso.", Publicacao = "1966", AutorId = 1, Avaliacao = "4", Destaque = true, Foto = "/img/livros/Dona Flor e seus dois maridos.png"  },
    new Livro { LivroId = 2, FaculdadeId = 1, Nome = "Dom Casmurro", Descricao = "é um romance de Machado de Assis que conta a história de Bento Santiago, um homem que, já velho, decide escrever um livro para narrar sua versão dos acontecimentos de sua juventude.", Publicacao = "1899", AutorId = 2, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Dom Casmurro.png" },
    new Livro { LivroId = 3, FaculdadeId = 1, Nome = "Capitães da Areia", Descricao = "A história se passa em Salvador, Bahia, e retrata a vida de um grupo de meninos de rua que vivem em um trapiche abandonado, enfrentam a miséria, a violência e sobrevivem roubando e praticando pequenos crimes, mas também demonstram um forte senso de união e solidariedade.", Publicacao = "1937", AutorId = 1, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Capitães De Areia .png" },
    new Livro { LivroId = 4, FaculdadeId = 1, Nome = "Estrela da vida inteira", Descricao = "é um livro de poemas que reúne todos os livros de poesia do autor, desde o seu primeiro, A Cinza das Horas, até os poemas que escreveu ao longo de sua vida.", Publicacao = "1965", AutorId = 3, Avaliacao = "4,7", Destaque = true, Foto = "/img/livros/Estrelas Da Vida Inteira.png" },
    new Livro { LivroId = 5, FaculdadeId = 1, Nome = "Grande Sertão: Veredas", Descricao = "conta a história de amor entre Riobaldo e Diadorim (ou Reinaldo). O ex-jagunço Riobaldo relata, para um interlocutor não nomeado na obra, fatos de sua juventude em meio a um bando de jagunços.", Publicacao = "1956 ", AutorId = 4, Avaliacao = "4,9", Destaque = true, Foto = "/img/livros/Grande Sertão Veredas.png" },
    new Livro { LivroId = 6, FaculdadeId = 1, Nome = "Gabriela Cravo e Canela", Descricao = "A obra narra o caso de amor entre o árabe Nacib e a sertaneja Gabriela, como pano de fundo o período áureo do cacau na região de Ilhéus, descrevendo as alterações profundas da vida social da Bahia da década de 1920.", Publicacao = "1958", AutorId = 1, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Gabriela,cravo e canela.png" },
    new Livro { LivroId = 7, FaculdadeId = 1, Nome = "Iracema", Descricao = "O romance conta o amor de um branco, Martim Soares Moreno, pela índia Iracema, a virgem dos lábios de mel. A relação do casal serviria de alegoria para a formação da nação brasileira. A índia Iracema representaria a natureza virgem e a inocência enquanto o colonizador Martim representa a cultura (europeia).", Publicacao = "1865", AutorId = 5, Avaliacao = "4,6", Destaque = true, Foto = "/img/livros/iracema.png" },
    new Livro { LivroId = 8, FaculdadeId = 1, Nome = "Memórias Póstumas de Brás Cubas", Descricao = "Brás Cubas decide narrar sua própria vida após a morte. A narrativa começa com sua agonia e enterro, e retrocede para sua infância, juventude e vida adulta. O livro é uma crítica à sociedade da época, com seus costumes, valores e hipocrisias.", Publicacao = "1880", AutorId = 2, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Memórias Póstumas de Brás Cubas.png"},
    new Livro { LivroId = 9, FaculdadeId = 1, Nome = "Sonetos", Descricao = "Os sonetos de Camões abordam uma variedade de temas, com destaque para o amor, a paixão, a saudade, a melancolia, a fé e a reflexão sobre a vida e a morte. Sua poesia é um retrato da alma humana, com suas alegrias, tristezas, esperanças e desilusões.", Publicacao = "1595", AutorId = 6, Avaliacao= "4,7", Destaque = true, Foto = "/img/livros/Sonetos De Camões.png" },
    new Livro { LivroId = 10, FaculdadeId = 1, Nome = "Quarto de Despejo", Descricao = "O livro é um diário em que Carolina Maria de Jesus narra seu cotidiano, descrevendo as dificuldades que enfrenta como mãe solteira de três filhos, trabalhando como catadora de papel e enfrentando a falta de recursos para suprir as necessidades básicas da família.", Publicacao = "1960", AutorId = 7, Avaliacao = "4,9", Destaque = true, Foto = "/img/livros/Quarto De Despejo.png" },
    new Livro { LivroId = 11, FaculdadeId = 1, Nome = "Poesia Completa", Descricao = "O momento em que o país vivia a Era Vargas é a mais cobrada no ENEM. Isso acontece porque ela reflete o engajamento social e político do poeta, características que costumam ser muito bem aproveitadas", Publicacao = "", AutorId = 8, Avaliacao = "3,8", Destaque = true, Foto = "/img/livros/Poesia Completa Carlos Drummond De Andrade.png" },
    new Livro { LivroId = 12, FaculdadeId = 1, Nome = "O povo brasileiro", Descricao = "A obra busca responder à pergunta: quem são os brasileiros? mergulhando na história do Brasil, analisando as matrizes culturais, os mecanismos de formação étnica e cultural, os conflitos e as contradições.", Publicacao = "1995", AutorId = 9, Avaliacao = "4,9", Destaque = true, Foto = "/img/livros/O Povo Brasileiro.png" },
    new Livro { LivroId = 13, FaculdadeId = 1, Nome = "Vidas Secas", Descricao = "A história acompanha a saga de Fabiano, Sinhá Vitória e seus dois filhos, além da cachorra Baleia, em busca de melhores condições de vida. A família enfrenta a seca, a fome, a violência e a injustiça social, sendo constantemente humilhada e explorada pelos proprietários de terra.", Publicacao = "1938", AutorId = 10, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Vidas Secas.png" },
    new Livro { LivroId = 14, FaculdadeId = 1, Nome = "O Cortiço", Descricao = "O Cortiço é um romance naturalista que retrata a vida de pessoas pobres que viviam em cortiços no Rio de Janeiro no final do século XIX. O livro denuncia a exploração e as péssimas condições de vida dos moradores.", Publicacao = "1890", AutorId = 11, Avaliacao= "4,7", Destaque = true, Foto = "/img/livros/o cortiço.png" },

            // UNICAMP
    new Livro { LivroId = 15, FaculdadeId = 2, Nome = "Prosas seguidas de odes mínimas", Descricao = "é um livro composto por: Prosas: Vinte textos em prosa poética que abordam temas diversos marcados pela concisão, pela ironia e pelo humor, e Odes Mínimas: Treze poemas curtos, concisos e minimalistas, que exploram os temas das prosas,com uma linguagem depurada e essencial. Os poemas são marcados pela reflexão, pela ironia e pela brevidade.", Publicacao = "1992", AutorId = 12, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Prosas seguidas de odes mínimas.png" },
    new Livro { LivroId = 16, FaculdadeId = 2, Nome = "Olhos d’água", Descricao = "Olhos d'água é um livro de contos da escritora Conceição Evaristo que aborda a vida de pessoas negras e afro-brasileiras.A metáfora dos olhos d'água simboliza a união estabelecida entre passado, presente e futuro", Publicacao = "2014", AutorId = 13, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Olhos d'água.png" },
    new Livro { LivroId = 17, FaculdadeId = 2, Nome = "A vida não é útil", Descricao = "é um livro que questiona o sistema capitalista, o consumismo e a destruição ambiental. Composto por cinco textos: Não se come dinheiro, Sonhos para adiar o fim do mundo, A máquina de fazer coisas, O amanhã não está à venda, A vida não é útil.", Publicacao = "2020", AutorId = 14, Avaliacao= "4,8", Destaque = true, Foto = "/img/livros/A vida não é útil.png" },
    new Livro { LivroId = 18, FaculdadeId = 2, Nome = "Casa Velha", Descricao = "Casa Velha é um romance de Machado de Assis que aborda temas como o poder das normas sociais, a ascensão social e as relações de poder entre as classes sociais", Publicacao = "1886", AutorId = 2, Avaliacao = "4,6", Destaque = true, Foto = "/img/livros/Casa Velha.png" },
    new Livro { LivroId = 19, FaculdadeId = 2, Nome = "Vida e morte de M.J Gonzaga de Sá", Descricao = "Vida e morte de M.J Gonzaga de Sá é um livro que conta a história de um jornalista negro que vive no Rio de Janeiro no início do século XX, o qual aborda temas como: Desigualdade social, Racismo, Corrupção política, Abandono das populações periféricas, Burocratização do Estado.", Publicacao = "1919", AutorId = 15, Avaliacao = "4,5", Destaque = true, Foto = "/img/livros/Vida e morte de M.J Gonzaga de Sá.png" },
    new Livro { LivroId = 20, FaculdadeId = 2, Nome = "No Seu Pescoço", Descricao = "No seu pescoço é um livro que aborda temas  sobre injustiça social, desigualdade de gênero, sonho, nostalgia, racismo e preconceito contra imigrantes de forma combativa, sem ser abusiva", Publicacao = "2017", AutorId = 16, Avaliacao = "4,2", Destaque = true, Foto = "/img/livros/No seu pescoço.png" },
    new Livro { LivroId = 21, FaculdadeId = 2, Nome = "Morangos mofados", Descricao = "Morangos Mofados é um livro de contos que retratam a angústia, a solidão, a repressão e a busca por liberdade de jovens na década de 1970, durante a ditadura militar no Brasil.", Publicacao = "1982", AutorId = 17, Avaliacao = "4,6", Destaque = true, Foto = "/img/livros/Morangos mofados.png" },
    new Livro { LivroId = 22, FaculdadeId = 2, Nome = "Canções Escolhidas", Descricao = "As canções escolhidas de Cartola são Alvorada, As rosas não falam, Cordas de aço, Disfarça e chora, O inverno do meu tempo, O mundo é um moinho, Que é feito de você?, Sala de recepção, Silêncio de um cipreste e Sim", Publicacao = "", AutorId = 18, Avaliacao = null, Destaque = true, Foto = "/img/livros/Canções Escolhida - Cartola.png" },
    new Livro { LivroId = 23, FaculdadeId = 2, Nome = "Alice no país das maravilhas", Descricao = "é uma história sobre uma menina que sonha que cai numa toca de coelho e acaba num mundo mágico. Lá, ela vive aventuras e se depara com o absurdo, o impossível e questiona tudo o que aprendeu até ali", Publicacao = "1865 ", AutorId = 19, Avaliacao = "4,8", Destaque = true, Foto = "/img/livros/Alice no país das maravilhas.png" },

            // FUVEST
    new Livro { LivroId = 24, FaculdadeId = 3, Nome = "A visão das plantas", Descricao = "A obra conta a história de Celestino, homem cujo passado de brutalidade e violência assombrosas é substituído, no crepúsculo da vida, por um amor delicado e cuidadoso pelas plantas de seu jardim.", Publicacao = "2019", AutorId = 20, Avaliacao = "3,5", Destaque = true, Foto = "/img/livros/A visão das plantas.png" },
    new Livro { LivroId = 25, FaculdadeId = 3, Nome = "As meninas", Descricao = "O livro acompanha a jornada de três jovens mulheres universitárias no início da década de 70. Lorena, Ana Clara e Lia são de mundos distantes, vivendo impasses, cada qual com seu próprio drama durante o período turbulento da ditadura.", Publicacao = "1973", AutorId = 21, Avaliacao = "4,2", Destaque = true, Foto = "/img/livros/As meninas.png" },
    new Livro { LivroId = 26, FaculdadeId = 3, Nome = "Balada de amor ao vento", Descricao = "A obra conta a história de amor entre Sarnau e Mwando, na qual faz uma crítica à poligamia e às tradições machistas e patriarcais que afetam a vida das mulheres.", Publicacao = "1990", AutorId = 22, Avaliacao = "4", Destaque = true, Foto = "/img/livros/Balada de amor ao vento.png" },
    new Livro { LivroId = 27, FaculdadeId = 3, Nome = "Caminho de pedras", Descricao = "Na Fortaleza dos anos 1930, durante a Era Vargas, Roberto tem a missão de recrutar operários para uma nova célula de esquerda. Uma das pessoas que se interessam é Noemi: mãe de Guri e casada com um homem que não ama mais, ela está em busca de algo que a faça se sentir viva.", Publicacao = "1937", AutorId = 23, Avaliacao = "3,5", Destaque = true, Foto = "/img/livros/Caminho de Pedras.png" },
    new Livro { LivroId = 28, FaculdadeId = 3, Nome = "Canção para ninar menino grande", Descricao = "A obra questiona o patriarcado e as construções sociais da masculinidade, é um retrato de um homem através dos relacionamentos que ele coleciona com várias mulheres negras.", Publicacao = "2018", AutorId = 24, Avaliacao = "4,2", Destaque = true, Foto = "/img/livros/Canção para Ninar Menino grande.png" },
    new Livro { LivroId = 29, FaculdadeId = 3, Nome = "Memórias de Martha", Descricao = "A obra narra a história de uma jovem chamada Marta, que viveu no Rio de Janeiro no final do século XIX, é uma autobiografia ficcional que retrata as dificuldades enfrentadas por Marta e sua mãe, viúva.", Publicacao = "1899", AutorId = 25, Avaliacao = "3,5", Destaque = true, Foto = "/img/livros/Memórias de Martha.png" },
    new Livro { LivroId = 30, FaculdadeId = 3, Nome = "Nebulosas", Descricao = "Seus poemas revelam uma voz lírica única, que aborda temas íntimos, femininos e ligados à natureza, ao mesmo tempo em que expressam uma preocupação social evidente, especialmente em relação à abolição da escravatura, uma questão presente na sociedade brasileira do século XIX.", Publicacao = "2024", AutorId = 26, Avaliacao = "3", Destaque = true, Foto = "/img/livros/Nebulosas.png" },
    new Livro { LivroId = 31, FaculdadeId = 3, Nome = "O cristo cigano", Descricao = "O livro é composto por uma série de poemas que contam a história de uma lenda sobre o assassinato de um cigano e a construção de uma imagem de Cristo.", Publicacao = "1961", AutorId = 27, Avaliacao = "3,7", Destaque = true, Foto = "/img/livros/O cristo cigano.png" },
    new Livro { LivroId = 32, FaculdadeId = 3, Nome = "Opúsculo Humanitário", Descricao = "A obra traça a evolução das condições femininas e mostram a experiência da autora tanto em leitura, quanto em vivências em suas viagens.", Publicacao = "1853", AutorId = 28, Avaliacao = "3,6", Destaque = true, Foto = "/img/livros/Opúsculo Humanitário.png"},
    };
        
    builder.Entity<Livro>().HasData(livros);


    #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
            Id = "1",
            Name = "Administrador",
            NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
            Id = "2",
            Name = "Funcionário",
            NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole() {
            Id = "3",
            Name = "Cliente",
            NormalizedName = "CLIENTE"
            },
        };

        builder.Entity<IdentityRole>().HasData(roles);
    #endregion



        #region Populate Usuário
         var usuario = new Usuario()
        {
            Id = "1",
            Email = "gallojunior@gmail.com",
            NormalizedEmail = "GALLOJUNIOR@GMAIL.COM",
            UserName = "GalloJunior",
            NormalizedUserName = "GALLOJUNIOR",
            LockoutEnabled = true,
            EmailConfirmed = true,
            Nome = "José Antonio Gallo Junior",
            DataNascimento = DateTime.Parse("05/08/1981"),
            Foto = "/img/usuarios/ddf093a6-6cb5-4ff7-9a64-83da34aee005.png"
        };

        PasswordHasher<Usuario> pass = new();
        usuario.PasswordHash = pass.HashPassword(usuario, "123456");

        builder.Entity<Usuario>().HasData(usuario);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = "1" },
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = "2" },
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = "3" }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}