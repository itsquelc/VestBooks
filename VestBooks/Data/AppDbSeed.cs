using VestBooks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AspNetCoreGeneratedDocument;

namespace VestBooks.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Faculdade> faculdades = new()
        {
            new Faculdade { Id = 1, Nome = "ENEM", Foto = "/img/faculdades/ENEM.png", Descricao =
            @"Anualmente, o Exame Nacional do Ensino Médio (Enem) aplica questões com foco em obras
            literárias brasileiras. Entretanto, o órgão que desenvolve a prova (Inep) não fornece uma lista de
            leituras, mas é preciso saber quais livros provavelmente estarão presentes no exame e, assim, adotar
            algumas leituras obrigatórias.
            <br><br>
            Como o Enem exige dos candidatos uma série de conhecimentos literários (tudo o que aprenderam no Ensino
            Médio), espera-se do candidato que ele conheça as principais obras de cada escola literária.
            <br><br>
            A prova de Linguagens, Códigos e suas Tecnologias do Enem , por exemplo, pede que você conheça a
            importância do autor/obra para a sociedade e para a cultura em geral.
            Por isso, é fundamental conhecer as principais obras, autores e como eles influenciaram tudo o que veio
            depois." },



            new Faculdade { Id = 2, Nome = "UNICAMP", Foto = "/img/faculdades/UNICAMP.png", Descricao =
            @"O vestibular para ingressar na Unicamp, uma das maiores e mais conceituadas
              universidades do país, está marcado para 20 de outubro. Além de todas as
              disciplinas cobradas no Ensino Médio, o edital estipula uma lista de 8 livros de
              leitura obrigatória.
              <br><br>
              O objetivo da Comvest (Comissão Permanente para os Vestibulares da Unicamp)
              ao fazer esta lista, é estimular a leitura e o olhar atento dos estudantes para as
              questões do mundo contemporâneo, então livros como “A vida não é útil“ de
              Ailton Krenak e “Niketche – uma História de Poligamia“ de Paulina Chiziane estão
              ao lado de “Casa Velha“ de Machado de Assis, por exemplo."},
            new Faculdade { Id = 3, Nome = "USP", Foto = "/img/faculdades/USP.png", Descricao = "" },
            new Faculdade { Id = 4, Nome = "UNESP", Foto = "/img/faculdades/UNESP.png" },
        };
        builder.Entity<Faculdade>().HasData(faculdades);


        List<Autor> autores = new()
        {
            new Autor { AutorId = 1, Nome = "Jorge Amado", Foto = "/img/autores/Jorge Amado.png"  },
            new Autor { AutorId = 2, Nome = "Machado de Assis", Foto = "/img/autores/Machado de Assis.png"},
            new Autor { AutorId = 3, Nome = "Manuel Bandeira", Foto = "/img/autores/Manuel Bandeira.png" },
            new Autor { AutorId = 4, Nome = "João Guimarães Rosa", Foto = "/img/autores/João Guimarães Rosa.png" },
            new Autor { AutorId = 5, Nome = "José de Alencar", Foto = "/img/autores/José de Alencar.png" },
            new Autor { AutorId = 6, Nome = "Luis de Camões", Foto = "/img/autores/Luis de Camões.png" },
            new Autor { AutorId = 7, Nome = "Carolina Maria de Jesus", Foto = "/img/autores/Carolina Maria de Jesus.png" },
            new Autor { AutorId = 8, Nome = "Carlos drummond de Andrade", Foto = "/img/autores/Carlos drummond de Andrade.png"  },
            new Autor { AutorId = 9, Nome = "Darcy Ribeiro", Foto = "/img/autores/Darcy Ribeiro.png"  },
            new Autor { AutorId = 10, Nome = "Graciliano Ramos",Foto = "/img/autores/Graciliano Ramos.png"  },
            new Autor { AutorId = 11, Nome = "Aluísio Azevedo", Foto = "/img/autores/Aluísio Azevedo.png"  },
            new Autor { AutorId = 12, Nome = "José Paulo Paes",Foto = "/img/autores/José Paulo Paes.png"  },
            new Autor { AutorId = 13, Nome = "Conceição Evaristo",Foto = "/img/autores/Conceição Evaristo.png"  },
            new Autor { AutorId = 14, Nome = "Ailton Krenak",Foto = "/img/autores/Ailton Krenak.png"  },
            new Autor { AutorId = 15, Nome = "Lima Barreto",Foto = "/img/autores/Lima Barreto.png"  },
            new Autor { AutorId = 16, Nome = "Chimamanda Ngozi Adichie",Foto = "/img/autores/Chimamanda Ngozi Adichie.png"  },
            new Autor { AutorId = 17, Nome = "Caio Fernando Abreu", Foto = "/img/autores/Caio Fernando Abreu.png"  },
            new Autor { AutorId = 18, Nome = "Cartola", Foto = "/img/autores/Cartola.png"  },
            new Autor { AutorId = 19, Nome = "Lewis Carroll", Foto = "/img/autores/Lewis Carroll.png"  },
            new Autor { AutorId = 20, Nome = "Djamilia Pereira de Almdeida", Foto = "/img/autores/Djamilia Pereira de Almdeida.png" },
            new Autor { AutorId = 21, Nome = "Lygia Fagundes Telles", Foto = "Lygia Fagundes Telles.png" },
            new Autor { AutorId = 22, Nome = "Paulina Chiziane", Foto = "/img/autores/Paulina Chiziane.png" },
            new Autor { AutorId = 23, Nome = "Rachel de Queiroz", Foto = "/img/autores/Rachel de Queiroz.png" },
            new Autor { AutorId = 24, Nome = "Conceição Evaristo", Foto = "/img/autores/Conceição Evaristo.png" },
            new Autor { AutorId = 25, Nome = "Julia Lopes de Almeida", Foto = "/img/autores/Julia Lopes de Almeida.png" },
            new Autor { AutorId = 26, Nome = "Narcisa Amália", Foto = "/img/autores/Narcisa Amália.png" },
            new Autor { AutorId = 27, Nome = "Sophia de Mello Breyner Andresen", Foto = "/img/autores/Sophia de Mello Breyner Andresen.png" },
            new Autor { AutorId = 28, Nome = "Nísia Floresta", Foto = "/img/autores/Nísia Floresta.png" },


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



        List<FaculdadeLivro> faculdadeLivros = new()
    {
        new() {FaculdadeLivroId =  1, FaculdadeId =  1, LivroId =  1},
        new() {FaculdadeLivroId =  2, FaculdadeId =  1, LivroId =  2},
        new() {FaculdadeLivroId =  3, FaculdadeId =  1, LivroId =  3},
        new() {FaculdadeLivroId =  4, FaculdadeId =  1, LivroId =  4},
        new() {FaculdadeLivroId =  5, FaculdadeId =  1, LivroId =  5},
        new() {FaculdadeLivroId =  6, FaculdadeId =  1, LivroId =  6},
        new() {FaculdadeLivroId =  7, FaculdadeId =  1, LivroId =  7},
        new() {FaculdadeLivroId =  8, FaculdadeId =  1, LivroId =  8},
        new() {FaculdadeLivroId =  9, FaculdadeId =  1, LivroId =  9},
        new() {FaculdadeLivroId =  10, FaculdadeId =  1, LivroId =  10},
        new() {FaculdadeLivroId =  11, FaculdadeId =  1, LivroId =  11},
        new() {FaculdadeLivroId =  12, FaculdadeId =  1, LivroId =  12},
        new() {FaculdadeLivroId =  13, FaculdadeId =  1, LivroId =  13},
        new() {FaculdadeLivroId =  14, FaculdadeId =  1, LivroId =  14},
        new() {FaculdadeLivroId =  15, FaculdadeId =  2, LivroId =  15},
        new() {FaculdadeLivroId =  16, FaculdadeId =  2, LivroId =  16},
        new() {FaculdadeLivroId =  17, FaculdadeId =  2, LivroId =  17},
        new() {FaculdadeLivroId =  18, FaculdadeId =  2, LivroId =  18},
        new() {FaculdadeLivroId =  19, FaculdadeId =  2, LivroId =  19},
        new() {FaculdadeLivroId =  20, FaculdadeId =  2, LivroId =  20},
        new() {FaculdadeLivroId =  21, FaculdadeId =  2, LivroId =  21},
        new() {FaculdadeLivroId =  22, FaculdadeId =  2, LivroId =  22},
        new() {FaculdadeLivroId =  23, FaculdadeId =  2, LivroId =  23},
        new() {FaculdadeLivroId =  24, FaculdadeId =  3, LivroId =  24},
        new() {FaculdadeLivroId =  25, FaculdadeId =  3, LivroId =  25},
        new() {FaculdadeLivroId =  26, FaculdadeId =  3, LivroId =  26},
        new() {FaculdadeLivroId =  27, FaculdadeId =  3, LivroId =  27},
        new() {FaculdadeLivroId =  28, FaculdadeId =  3, LivroId =  28},
        new() {FaculdadeLivroId =  29, FaculdadeId =  3, LivroId =  29},
        new() {FaculdadeLivroId =  30, FaculdadeId =  3, LivroId =  30},
        new() {FaculdadeLivroId =  31, FaculdadeId =  3, LivroId =  31},
        new() {FaculdadeLivroId =  32, FaculdadeId =  3, LivroId =  32},

    };
        builder.Entity<FaculdadeLivro>().HasData(faculdadeLivros);


        List<Pergunta> perguntas = new(){
        new Pergunta { PerguntaId = 1, FaculdadeId = 1, Enunciado =
            @"Quem é pobre, porque se sujou, é um prisioneiro; vaga nas gerais, que nem os rios distantes de
              sua ligação. O cabaré tem o apito do trem, o sofá manchado. Dona Flor é toda cheia de vestidos, de
              coentro, de cheiros.”
              <br>
              (Amado, J. Dona Flor e seus dois maridos. São Paulo: Companhia das Letras, 1992.)
              <br><br>
              No trecho citado, o autor representa uma situação desencantada da mulher brasileira dos anos
              1940, tratando com humor a sensualidade e os conflitos sociais que envolvem essa época."},
        
        new Pergunta { PerguntaId = 2, FaculdadeId = 1, Enunciado =
            @"(Livro: Dona Flor e Seus Dois Maridos)
            <br>
            Sobre a personagem Dona Flor, é correto afirmar que:"},

        new Pergunta { PerguntaId = 3, FaculdadeId = 1, Enunciado =
         @"(Dom Casmurro)
         <br>
         (ESPCEx/2019)
         Retórica dos namorados, dá-me uma comparação exata e poética para dizer o que foram aqueles olhos de Capitu.
         Não me acode imagem capaz de dizer, sem quebra da dignidade do estilo, o que eles foram e me fizeram. 
         Olhos de ressaca? Vá, de ressaca. É o que me dá idéia daquela feição nova. Traziam não sei que fluido misterioso 
         e enérgico, uma força que arrastava para dentro, como a vaga que se retira da praia, nos dias de ressaca.
         Para não ser arrastado, agarrei-me às outras partes vizinhas, às orelhas, aos braços, aos cabelos espalhados pelos ombros; 
         mas tão depressa buscava as pupilas, a onda que saía delas vinha crescendo, cava e escura, ameaçando envolver-me, 
         puxar-me e tragar-me.
         <br>
        (ASSIS. Machado de. Dom Casmurro. São Paulo: Ática,1999. p.55 (fragmento))
        <br><br>
        Com Dom Casmurro, obra publicada em 1899, depois de Memórias Póstumas de Brás Cubas (1881) e de Quincas Borba (1891),
        Machado de Assis deixa marcas indeléveis de que a Literatura Brasileira vivia um novo período literário, bem diferente
        do Romantismo. Nessas obras, nota-se uma forma diferente de sentir e de ver a realidade, menos idealizada, mais verdadeira
        e crítica: uma perspectiva realista. O trecho apresentado acima representa essa perspectiva porque o narrador:"
        },

         new Pergunta { PerguntaId = 4, FaculdadeId = 2, Enunciado =
         @"Morro da Babilônia
         <br>
         À noite, do morro    <br>
        descem vozes que criam o terror    <br>
        (terror urbano, cinquenta por cento de cinema,     <br>
        e o resto que veio de Luanda ou se perdeu na língua     <br>
        Geral).

        Quando houve revolução, os soldados     <br>
        espalharam no morro,    <br>
        O quartel pegou fogo, eles não voltaram.    <br>
        Alguns, chumbados, morreram.    <br>
        O morro ficou mais encantado.    <br>

        Mas as vozes do morro    <br>
        não são propriamente lúgubres.    <br>
        Há mesmo um cavaquinho bem afinado     <br>
        que domina os ruídos de pedra e da folhagem    <br>
        e desce até nós modesto e recreativo,    <br>
        como uma gentileza no morro    <br>

         <br>
        (Carlos Drummond de Andrade Sentimento do mundo. São Paulo: Companhia das Letras, 2012, p. 19.)
        <br><br>
        No poema “Morro da Babilônia”, de Carlos Drummond de Andrade,"
      },

       new Pergunta { PerguntaId = 5, FaculdadeId = 2, Enunciado =
         @"Para driblar a censura imposta pela ditadura militar, compositores 
         de música popular brasileira (MPB) valiam-se do que Gilberto Vasconcelos 
         chamou de “linguagem da fresta”, expressão inspirada na canção “Festa imodesta”, de Caetano Veloso.
         <br>
       (...)
        Numa festa imodesta como esta
        Vamos homenagear
        Todo aquele que nos empresta sua testa
        Construindo coisas pra se cantar
        Tudo aquilo que o malandro pronuncia
        E que o otário silencia
        Toda festa que se dá ou não se dá
        Passa pela fresta da cesta e resta a vida.
        Acima do coração que sofre com razão
        A razão que volta do coração
        E acima da razão a rima

        E acima da rima a nota da canção
        Bemol natural sustenida no ar
        Viva aquele que se presta a esta ocupação
        Salve o compositor popular
         <br>
       (Gilberto de Vasconcelos, Música popular: de olho na fresta. Rio de Janeiro: Graal, 1977.)
        <br><br>
        É correto afirmar que, na canção, essa “linguagem dafresta” transparece"
      },

        new Pergunta { PerguntaId = 6, FaculdadeId = 2, Enunciado =
         @"O romance Memórias póstumas de Brás Cubas é considerado um divisor de 
         águas tanto na obra de Machado de Assis quanto na literatura brasileira 
         do século XIX. Indique a alternativa em que todas as características mencionadas 
         podem ser adequadamente atribuídas ao romance em questão."
      },
      new Pergunta { PerguntaId = 7, FaculdadeId = 3, Enunciado =
       @"Nun´Álvares Pereira
         <br>
       Que auréola te cerca?
        É a espada que, volteando, 
        Faz que o ar alto perca
        Seu azul negro e brando.

        Mas que espada é que, erguida, 
        Faz esse halo no céu?
        É Excalibur, a ungida, 
        Que o Rei Artur te deu.

        ´Sperança consumada,
        S. Portugal em ser,
        Ergue a luz da tua espada 
        Para a estrada se ver!
         <br>
        Fernando Pessoa. In: “A Coroa”, Parte I, Mensagem.
        <br><br>
        A primeira parte de Mensagem, organizada como um correlativo poético do Brasão das Armas de Portugal, perfila uma série de figuras míticas e históricas que teriam sido responsáveis pela formação nacional portuguesa. A seleção de Nun´Álvares Pereira para ocupar o lugar da Coroa"
      },

      new Pergunta { PerguntaId = 8, FaculdadeId = 3, Enunciado =
         @"Sobre a obra Dom Casmurro, é correto afirmar:"
      },

      new Pergunta { PerguntaId = 9, FaculdadeId = 3, Enunciado =
         @"Na obra A Hora da Estrela, a metanarrativa presente na voz do narrador é utilizada para:"
      },

      new Pergunta { PerguntaId = 10, FaculdadeId = 3, Enunciado =
         @"A linguagem concisa e econômica em Vidas Secas serve principalmente para:"
      },

       new Pergunta { PerguntaId = 11, FaculdadeId = 4, Enunciado =
         @"Futurismo.
         <br>
        O Manifesto Futurista, de autoria do poeta italiano Filippo Tommaso Marinetti (1876-1944), foi publicado em Paris em 1909. Nesse manifesto, Marinetti declara a raiz italiana da nova estética: “queremos libertar esse país (a Itália) de sua fétida gangrena de professores, arqueólogos, cicerones e antiquários”. Falando da Itália para o mundo, o Futurismo coloca-se contra o “passadismo” burguês e o tradicionalismo cultural. A exaltação da máquina e da “beleza da velocidade”, associada ao elogio da técnica e da ciência, torna-se emblemática da nova atitude estética e política.
         <br>
        (https://enciclopedia.itaucultural.org.br. Adaptado.)
        <br><br>
       Verifica-se a influência dessa vanguarda artística nos seguintes versos do poeta português Fernando Pessoa:"
      },

       new Pergunta { PerguntaId = 12, FaculdadeId = 4, Enunciado =
         @"O romance Galvez, Imperador do Acre"
      },

       new Pergunta { PerguntaId = 13, FaculdadeId = 4, Enunciado =
         @"No romance A moreninha, o personagem Augusto é um jovem"
      },

       new Pergunta { PerguntaId = 14, FaculdadeId = 4, Enunciado =
         @"De fato, este romance constitui um dos poucos romances cômicos do romantismo nacional, afastando-se dos traços idealizantes que caracterizam boa parte das obras “sérias” dos autores de então. O modo pelo qual este romance pinta a sociedade, representado-a a partir de um ângulo abertamente cômico e satírico, também era relativamente novo nas letras brasileiras do século XIX.
         <br>
        (Mamede Mustafa Jarouche. “Galhofa sem melancolia”, 2003. Adaptado.)
        <br><br>
         O comentário refere-se ao romance"
      },
    };


        List<PerguntaAlternativa> perguntasAlternativas = new(){
        new PerguntaAlternativa { PerguntaAlternativaId = 1, PerguntaId = 1, Descricao = "Relata a vida feliz e harmoniosa de mulheres da década de 1940, demonstrando que não havia disposição em superar essa é poca.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 2, PerguntaId = 1, Descricao = "Mostra um posicionamento progressista e feminista do autor diante da condição da mulher no século XXI.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 3, PerguntaId = 1, Descricao = "Denuncia a falta de comprometimento e a desvalorização das mulheres, que eram excluídas dos espaços sociais e políticos.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 4, PerguntaId = 1, Descricao = "Mantém o distanciamento narrativo coerente com sua posição social, de espectador da forma.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 5, PerguntaId = 2, Descricao = "É uma mulher submissa e resignada, que aceita seu destino de ter dois maridos sem questionamentos. ", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 6, PerguntaId = 2, Descricao = "É uma professora de culinária que busca independência financeira e emocional após a morte do primeiro marido. ", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 7, PerguntaId = 2, Descricao = "É uma mulher sensual e provocadora, que usa sua beleza para manipular os homens ao seu redor.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 8, PerguntaId = 2, Descricao = "É uma personagem que representa a mulher moderna, que desafia os padrões sociais e busca a liberdade sexual.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 9, PerguntaId = 3, Descricao = "Exagera nas imagens poéticas traduzidas por “fluido misterioso”, “praia”, “cabelos espalhados pelos ombros” em uma realização imagética da mulher que o tragava como fazem as ondas de um mar em ressaca.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 10, PerguntaId = 3, Descricao = "Deixa-se levar pelas ondas que saíam das pupilas de Capitu em um fluido, misterioso e enérgico, que o arrasta depressa como uma vaga que se retira da praia em dias de ressaca, não adiantando agarrar-se nem aos braços nem aos cabelos da moça.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 11, PerguntaId = 3, Descricao = "Retira-se da praia como as vagas em dias de ressaca por não ser capaz de dizer a Capitu o que está sentindo ao olhá-la nos olhos sem quebrar a dignidade mínima daquele momento em que duas pessoas apaixonam-se.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 12, PerguntaId = 3, Descricao = "Solicita à “retórica dos namorados” uma comparação que seja, ao mesmo tempo, exata e poética capaz de descrever os olhos de Capitu, revelando a dificuldade de apresentar uma verdade que não estrague a idealização romântica.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 13, PerguntaId = 3, Descricao = "Ridiculariza a retórica dos românticos ao afirmar que os olhos de Capitu pareciam com uma ressaca do mar e, por isso, não seria capaz de descrevê-los de maneira poética, traduzindo, assim, o realismo literário de sua época.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 14, PerguntaId = 4, Descricao = "A menção à cidade do Rio de Janeiro é feita de modo indireto, metonimicamente, pela referência ao Morro da Babilônia.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 15, PerguntaId = 4, Descricao = "O sentimento do mundo é representado pela percepção particular sobre a cidade do Rio de Janeiro, aludida pela metáfora do Morro da Babilônia", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 16, PerguntaId = 4, Descricao = "O tratamento dado ao Morro da Babilônia assemelha-se ao que é dado a uma pessoa, o que caracteriza a figura de estilo denominada paronomásia.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 17, PerguntaId = 4, Descricao = "A referência ao Morro da Babilônia produz, no percurso figurativo do poema, um oximoro: a relação entre terror e gentileza no espaço urbano.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 18, PerguntaId = 5, Descricao = "na contradição entre “festa” e “fresta”, que funciona como crítica ao malandro.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 19, PerguntaId = 5, Descricao = "na repetição de palavras com pronúncia semelhante para louvar a MPB.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 20, PerguntaId = 5, Descricao = "na referência à “fresta” como forma de o compositor se pronunciar.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 21, PerguntaId = 5, Descricao = "na incoerência da rima entre “festa” e “imodesta” para prestigiar o compositor.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 22, PerguntaId = 6, Descricao = "Rejeição dos valores românticos, narrativa linear e fluente de um defunto autor, visão pessimista em relação aos problemas sociais.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 23, PerguntaId = 6, Descricao = "Distanciamento do determinismo científico, cultivo do humor e digressões sobre banalidades, visão reformadora das mazelas sociais.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 24, PerguntaId = 6, Descricao = "Abandono das idealizações românticas, uso de técnicas pouco usuais de narrativa, sugestão implícita de contradições sociais.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 25, PerguntaId = 6, Descricao = "Crítica do realismo literário, narração iniciada com a morte do narrador-personagem, tematização de conflitos sociais.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 26, PerguntaId = 7, Descricao = "sugere, pela imagem do halo de luz, que a verdadeira nobreza é de espírito.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 27, PerguntaId = 7, Descricao = "destaca, através da referência ao mito arturiano, o seu sangue bretão", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 28, PerguntaId = 7, Descricao = "distingue, por meio do substantivo “´sperança”, um regente digno de seu posto.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 29, PerguntaId = 7, Descricao = "enaltece, pela repetição da palavra espada, a guerra como estrada para o futuro", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 30, PerguntaId = 8, Descricao = "Bentinho é um narrador onisciente que revela com clareza todos os eventos da trama, sem deixar dúvidas sobre as ações dos personagens.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 31, PerguntaId = 8, Descricao = "A dúvida sobre a fidelidade de Capitu é um elemento central da narrativa, deixando em aberto a interpretação do leitor.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 32, PerguntaId = 8, Descricao = "A obra é um romance de aventura, com ênfase em episódios de ação e suspense.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 33, PerguntaId = 8, Descricao = "O enredo é linear e cronológico, sem o uso de flashbacks ou digressões.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 34, PerguntaId = 9, Descricao = "Criar uma distância total entre o narrador e a história, sem envolver o leitor.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 35, PerguntaId = 9, Descricao = "Apresentar um narrador onisciente que tudo sabe sobre os personagens.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 36, PerguntaId = 9, Descricao = "Evitar reflexões sobre a condição social da protagonista, focando apenas em sua vida pessoal.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 37, PerguntaId = 9, Descricao = "Construir uma história linear e objetiva, sem interferências do narrador.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 38, PerguntaId = 9, Descricao = "Desconstruir a narrativa tradicional e estabelecer um diálogo direto com o leitor, questionando o papel do escritor e da personagem.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 39, PerguntaId = 10, Descricao = "Embelezar poeticamente a descrição do sertão e da natureza.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 40, PerguntaId = 10, Descricao = "Facilitar a leitura e tornar a obra mais acessível para crianças.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 41, PerguntaId = 10, Descricao = "Apresentar uma linguagem rebuscada e sofisticada, típica do modernismo europeu.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 42, PerguntaId = 10, Descricao = "Reforçar a dureza da vida dos retirantes, refletindo a escassez e a dificuldade do ambiente.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 43, PerguntaId = 10, Descricao = "Esconder as emoções dos personagens por meio de longas descrições.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 44, PerguntaId = 11, Descricao = "Mas, ah outra vez a raiva mecânica constante! Outra vez a obsessão movimentada dos ônibus. E outra vez a fúria de estar indo ao mesmo tempo [dentro de todos os comboios De todas as partes do mundo, De estar dizendo adeus de bordo de todos os navios, Que a estas horas estão levantando ferro ou [afastando-se das docas.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 45, PerguntaId = 11, Descricao = "O sonho é ver as formas invisíveis Da distância imprecisa, e, com sensíveis Movimentos da esprança e da vontade, Buscar na linha fria do horizonte A árvore, a praia, a flor, a ave, a fonte — Os beijos merecidos da Verdade.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 46, PerguntaId = 11, Descricao = "O teu silêncio é uma nau com todas as velas pandas... Brandas, as brisas brincam nas flâmulas, teu sorriso... E o teu sorriso no teu silêncio é as escadas e as andas Com que me finjo mais alto e ao pé de qualquer paraíso...", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 47, PerguntaId = 11, Descricao = "Não me compreendo nem no que, compreendendo, faço. Não atinjo o fim ao que faço pensando num fim. É diferente do que é o prazer ou a dor que abraço. Passo, mas comigo não passa um eu que há em mim.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 48, PerguntaId = 12, Descricao = "idealiza o passado da conquista do espaço amazônico.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 49, PerguntaId = 12, Descricao = "desmistifica as aventuras e os aventureiros da Amazônia.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 50, PerguntaId = 12, Descricao = "faz uma reconstituição objetiva do passado histórico da Amazônia.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 51, PerguntaId = 12, Descricao = "retrata os aventureiros amazônicos como homens especiais, desinteressados da vida mundana.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 52, PerguntaId = 12, Descricao = "constrói um mito fundador para o povo amazônico, apoiado na miscigenação de brancos e índios.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 53, PerguntaId = 13, Descricao = "instável, com relações afetivas curtas e inconstantes, que por fim se transforma ao encontrar o amor verdadeiro.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 54, PerguntaId = 13, Descricao = "prático, crítico ao romantismo, que ironiza o modo como as pessoas são vulneráveis às paixões.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 55, PerguntaId = 13, Descricao = "romântico, que não se relaciona com nenhuma mulher por fidelidade a uma promessa que havia feito na infância.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 56, PerguntaId = 13, Descricao = "melancólico, que prefere imaginar um amor perfeito, semelhante aos dos livros, o que o paralisa diante das relações afetivas reais e presentes.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 57, PerguntaId = 13, Descricao = "interesseiro, que submetia suas relações afetivas ao cálculo sobre as vantagens sociais que elas lhe trariam.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 58, PerguntaId = 14, Descricao = "O cortiço, de Aluísio Azevedo.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 59, PerguntaId = 14, Descricao = "Memórias póstumas de Brás Cubas, de Machado de Assis.", Correta = false},
        new PerguntaAlternativa { PerguntaAlternativaId = 60, PerguntaId = 14, Descricao = "Memórias de um sargento de milícias, de Manuel Antônio de Almeida.", Correta = true},
        new PerguntaAlternativa { PerguntaAlternativaId = 61, PerguntaId = 14, Descricao = "Iracema, de José de Alencar.", Correta = false},       
        new PerguntaAlternativa { PerguntaAlternativaId = 62, PerguntaId = 14, Descricao = "Macunaíma, de Mário de Andrade.", Correta = false},
    };
    builder.Entity<Pergunta>().HasData(perguntas);


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