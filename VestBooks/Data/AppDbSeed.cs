



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
            new Faculdade { Id = 1, Nome = "ENEM", Foto = "/img/faculdades/ENEM.png", Descricao =
            @"Anualmente, o Exame Nacional do Ensino Médio (Enem) aplica questões com foco em obras literárias brasileiras. Entretanto, o órgão que desenvolve a prova (Inep) não fornece uma lista de leituras, mas é preciso saber quais livros provavelmente estarão presentes no exame e, assim, adotar algumas leituras obrigatórias.

            Como o Enem exige dos candidatos uma série de conhecimentos literários (tudo o que aprenderam no Ensino Médio), espera-se do candidato que ele conheça as principais obras de cada escola literária.

            A prova de Linguagens, Códigos e suas Tecnologias do Enem , por exemplo, pede que você conheça a importância do autor/obra para a sociedade e para a cultura em geral.
            
            Por isso, é fundamental conhecer as principais obras, autores e como eles influenciaram tudo o que veio depois."},

            new Faculdade { Id = 2, Nome = "UNICAMP", Foto = "/img/faculdades/UNICAMP.png", Descricao =
            @"O vestibular para ingressar na Unicamp, uma das maiores e mais conceituadas universidades do país, está marcado para 20 de outubro. Além de todas as disciplinas cobradas no Ensino Médio, o edital estipula uma lista de 8 livros de leitura obrigatória.

              O objetivo da Comvest (Comissão Permanente para os Vestibulares da Unicamp) ao fazer esta lista, é estimular a leitura e o olhar atento dos estudantes para as questões do mundo contemporâneo, então livros como “A vida não é útil“ de Ailton Krenak e “Niketche – uma História de Poligamia“ de Paulina Chiziane estão ao lado de “Casa Velha“ de Machado de Assis, por exemplo."},
            
            new Faculdade { Id = 3, Nome = "USP", Foto = "/img/faculdades/USP.png", Descricao = 
            @"Além do objetivo de se adequar a Base Nacional Comum Curricular (BNCC) e às legislações vigentes, a Fuvest quer tornar seus alunos mais críticos e atualizados. A nova lista de leitura é justificada pela necessidade de se valorizar o papel das mulheres na literatura, não apenas como personagens, mas como autoras.
            " },
            
            new Faculdade { Id = 4, Nome = "UNESP", Foto = "/img/faculdades/UNESP.png", Descricao = 
            @"Universidade Estadual Paulista 'Júlio de Mesquita Filho' (Unesp) é uma universidade pública brasileira, com atuação no ensino, na pesquisa e na extensão de serviços à comunidade. A instituição é uma das quatro universidades mantidas pelo governo do estado de São Paulo, ao lado da Universidade de São Paulo (USP), Universidade Estadual de Campinas (Unicamp) e da Universidade Virtual do Estado de São Paulo (Univesp). Em 2024, a Unesp foi eleita a quinta melhor universidade da América Latina pela revista Times Higher Education
            A Unesp distingue-se das outras universidades estaduais por ter unidades em 24 municípios do estado — 22 campi no interior, um câmpus na cidade de São Paulo e um câmpus em São Vicente, o primeiro de uma universidade pública no litoral paulista.[1] Este modelo de universidade multicampi é inspirado na estrutura da Universidade da Califórnia, nos Estados Unidos, que é composta por 23 campi, criados entre os anos de 1857 e 2002." },
        };
        builder.Entity<Faculdade>().HasData(faculdades);


        List<Autor> autores = new()
        {
            new Autor { AutorId = 1, Nome = "Jorge Amado", Foto = "/img/autores/Jorge Amado.png", Biografia =
            @"Jorge Leal Amado de Faria, conhecido como Jorge Amado, nasceu em 10 de agosto de 1912, na antiga fazenda Auricídia, em Itabuna, mas cresceu em Ilhéus, na Bahia. Faleceu em 6 de agosto de 2001, em Salvador.
            É um dos escritores brasileiros mais lidos no mundo, com obras traduzidas para mais de 50 idiomas. Seu estilo combina realismo, crítica social, humor, sensualidade, cultura popular e fortes elementos da Bahia, especialmente do candomblé e da miscigenação brasileira.

            Infância e juventude:
            Jorge Amado cresceu em meio às plantações de cacau do sul da Bahia. Essa região — marcada por coronéis, disputas de terra, tradições populares e injustiças sociais — se tornaria cenário de muitos de seus romances.
            Começou a escrever ainda adolescente e, aos 19 anos, publicou seu primeiro livro.
            Cursou Direito no Rio de Janeiro, embora nunca tenha exercido a profissão.

            Carreira literária:
            Jorge Amado foi um dos escritores mais importantes da fase social do Modernismo (década de 1930).
            Sua obra é marcada por:
           
            - defesa dos pobres, trabalhadores e marginalizados

            - crítica à injustiça social

            - personagens carismáticos e populares

            - forte presença da cultura baiana

            - erotismo leve e humor

            Atuação política:
            Jorge Amado teve intensa atividade política, ele foi membro do Partido Comunista Brasileiro (PCB), deputado federal (1945–1947), Defendeu leis em prol da liberdade religiosa, resultando na legalização dos cultos afro-brasileiros, criou o primeiro projeto de proteção aos direitos autorais e com a perseguição política após 1947, viveu exilado na França e na Tchecoslováquia.

            Vida pessoal e candomblé:
            Foi casado com a escritora Zélia Gattai, com quem viveu por 56 anos.
            Era também adepto e defensor das religiões afro-brasileiras e filho de santo no candomblé da Casa do Gantois.
            Esse universo espiritual está fortemente presente em sua obra.

            Reconhecimento e prêmios:
            Foi membro da Academia Brasileira de Letras (ABL), ocupando a cadeira 23.
            É o escritor brasileiro contemporâneo mais adaptado para cinema e televisão.
            Recebeu dezenas de prêmios no Brasil e no exterior e tornou-se um símbolo da cultura baiana.

            Morte e legado:
            Faleceu em Salvador, em 2001, aos 88 anos.
            Seu legado permanece vivo por meio de sua obra, que retrata
            - a alma do povo baiano

            - as desigualdades brasileiras

            - a força da cultura popular

            - personagens inesquecíveis como Gabriela, Pedro Bala, Vadinho, Dona Flor e Tieta


            É considerado um dos maiores romancistas do Brasil e um dos mais conhecidos internacionalmente.
            "  },

            new Autor { AutorId = 2, Nome = "Machado de Assis", Foto = "/img/autores/Machado de Assis.png", Biografia = @"
            Joaquim Maria Machado de Assis nasceu em 21 de junho de 1839, no Rio de Janeiro, e morreu em 29 de setembro de 1908 na mesma cidade.
            É amplamente considerado o maior escritor brasileiro de todos os tempos e um dos maiores da literatura mundial.
            Foi romancista, contista, cronista, poeta, dramaturgo e crítico literário.
            Fundou e presidiu a Academia Brasileira de Letras (ABL).

            Origem e infância:
            Machado nasceu no Morro do Livramento, em uma família pobre.
            Seu pai era pintor de paredes e sua mãe, lavadeira; Ficou órfão cedo e teve pouca educação formal.
            A convivência com professores, padres e intelectuais que conheceu ainda jovem o levou à leitura e ao aprendizado autodidata.
            Era gago, epilético e introvertido — condições que influenciaram sua sensibilidade literária.

            Juventude e início da carreira:
            Começou a trabalhar cedo como,
            - aprendiz de tipógrafo

            - funcionário da Imprensa Nacional

            - revisor de textos

            A convivência com jornais e escritores foi essencial para sua formação.
            
            Iniciou a carreira literária com, 
            - poemas

            - crônicas

            - peças de teatro

            - contos

            E logo passou a colaborar com revistas e jornais.

            Carreira literária:
            A obra de Machado é dividida em duas fases

            1) Fase romântica (antes de 1880)
            Marca: influência do romantismo, histórias mais sentimentais e convencionais.
            2) Fase realista (a partir de 1881)
            É sua fase mais importante e original.
            Começa com Memórias Póstumas de Brás Cubas (1881), marco do Realismo brasileiro.
            
            Nessa fase, explora profundamente:
            - a psicologia humana

            - a ironia

            - o pessimismo filosófico

            - a crítica à sociedade

            - o olhar sobre o egoísmo e a hipocrisia social

            Estilo literário:
            Machado criou um estilo único, marcante por,
            - ironia fina e mordaz

            - narradores pouco confiáveis

            - diálogo direto com o leitor

            - crítica social aprofundada

            - psicologia dos personagens

            - pessimismo filosófico (“humanitismo”, “bentinho ciumento”, etc.)

            - narrativas inventivas e modernas, antecipando técnicas do século XX

            Vida pessoal:
            Em 1869, casou-se com Carolina Augusta Xavier de Novais, que foi sua grande parceira intelectual.
            O casal não teve filhos.
            A morte de Carolina, em 1880, foi um dos golpes mais duros da vida de Machado.
            Apesar de ser negro ou pardo (segundo a maior parte dos estudiosos), viveu em uma sociedade extremamente racista, mas conquistou posição central na elite literária de seu tempo.

            Academia Brasileira de Letras:
            Machado fundou a ABL em 1897 e foi seu primeiro presidente.
            Permaneceu no cargo até sua morte, tornando-se símbolo máximo da instituição.

            Últimos anos e morte:
            Nos últimos anos, mesmo com problemas de saúde, continuou escrevendo.
            Morreu em 29 de setembro de 1908, aos 69 anos.

            Legado:
            Machado de Assis é considerado o maior escritor brasileiro de todos os tempos, um dos maiores da literatura universal, pioneiro do Realismo psicológico, referência mundial em contos e romances

            Sua obra permanece atual, estudada em universidades do mundo inteiro, e figura nos principais vestibulares.
            "},

            new Autor { AutorId = 3, Nome = "Manuel Bandeira", Foto = "/img/autores/Manuel Bandeira.png", Biografia = @"
            Manuel Carneiro de Sousa Bandeira Filho nasceu em 19 de abril de 1886, em Recife (PE), e morreu em 13 de outubro de 1968, no Rio de Janeiro (RJ).
            É um dos maiores poetas brasileiros, integrante fundamental do Modernismo, especialmente da chamada Geração de 1930. Sua poesia é marcada pela simplicidade aparente, pela emoção profunda e pela reflexão sobre a vida, a morte e o cotidiano.

            Infância e formação:
            Filho de um engenheiro e de uma dona de casa, cresceu em um ambiente culturalmente rico. Em 1890, a família mudou-se para o Rio de Janeiro, onde Bandeira passou a maior parte de sua vida.
            Fez o curso secundário no Colégio Pedro II e iniciou estudos de arquitetura na Escola Nacional de Belas Artes.
            Porém, em 1904, aos 18 anos, foi diagnosticado com tuberculose, doença que interrompeu seus planos e marcaria profundamente sua obra.

            A tuberculose e sua influência literária:
            A doença o obrigou a longos períodos de isolamento e repouso, inclusive temporadas em Campos do Jordão e na Suíça.
            A consciência da fragilidade da vida, a proximidade constante com a morte e o sentimento de não pertencimento aparecem fortemente em seus poemas.
            Essa condição acaba gerando um dos elementos mais famosos de sua trajetória: a ideia de poeta do sofrimento e da transcendência.

            Carreira literária:
            Manuel Bandeira publicou seu primeiro livro, A Cinza das Horas (1917), ainda com forte influência simbolista e parnasiana.
            Sua verdadeira mudança estilística acontece com a chegada do Modernismo, especialmente após a Semana de Arte Moderna de 1922, da qual não participou presencialmente, mas teve poemas lidos e aclamados.
            A partir daí, sua poesia ganha
            - linguagem simples e coloquial

            - humor e ironia suave

            - imagens do cotidiano

            - temas existenciais

            - musicalidade leve

            - liberdade formal

            Vida profissional:
            Além de poeta foi professor universitário, crítico literário, tradutor de Shakespeare, Molière e outros, membro da Academia Brasileira de Letras, eleito em 1940, trabalhou no Serviço do Patrimônio Histórico e Artístico Nacional (SPHAN)

            Últimos anos e morte:
            Mesmo com a saúde frágil por toda a vida, viveu até os 82 anos.
            Morreu no Rio de Janeiro, em 1968.

            Legado
            Manuel Bandeira é considerado um dos maiores poetas do Modernismo brasileiro, mestre da poesia simples, musical e profunda, autor de alta sensibilidade estética e emocional, influência decisiva para gerações posteriores, presença constante em vestibulares e currículos escolares

            Sua poesia concilia dor, humor e leveza como poucos na literatura brasileira.
            " },

            new Autor { AutorId = 4, Nome = "João Guimarães Rosa", Foto = "/img/autores/João Guimarães Rosa.png", Biografia =
            @"João Guimarães Rosa nasceu em 27 de junho de 1908, em Cordisburgo, Minas Gerais, e morreu em 19 de novembro de 1967, no Rio de Janeiro.
            É considerado um dos maiores escritores brasileiros de todos os tempos e uma referência mundial da literatura moderna. Sua obra mais conhecida, “Grande Sertão: Veredas”, revolucionou a linguagem literária brasileira com invenções linguísticas, regionalismos e profundidade filosófica.

             Infância e Formação:
            Filho de comerciante, cresceu ouvindo histórias de viajantes e sertanejos, algo que influenciou toda sua escrita.
            Desde criança lia muito e demonstrava inteligência acima da média — aos 6 anos aprendeu sozinho francês e, mais tarde, dominaria mais de 10 idiomas.
            Formou-se em Medicina em 1930, pela Universidade de Minas Gerais, e trabalhou como médico no interior mineiro, convivendo diretamente com o sertão e seus personagens reais. Essa vivência marcou profundamente sua literatura.


             Carreira Diplomática:
            Em 1934, prestou concurso e entrou para o Itamaraty, iniciando carreira como diplomata. Serviu em países como,
            -Alemanha;
            -França;
            -Colômbia.

            Durante a Segunda Guerra Mundial, esteve na Alemanha nazista e ajudou judeus perseguidos — mais tarde seria reconhecido como alguém que salvou vidas, embora não oficialmente como “Justo entre as Nações”.
            Em 1967, foi eleito para a Academia Brasileira de Letras (ABL), mas faleceu três dias após tomar posse.

             A Obra Literária:
            Guimarães Rosa inaugurou uma nova forma de escrever no Brasil, misturando,
            - neologismos (palavras inventadas);

            -regionalismos do sertão;

            -elementos filosóficos e metafísicos;

            -poesia na prosa;

            -profundo conhecimento da alma humana.


             Temas Centrais:
            -o sertão brasileiro;

            -dilemas humanos universais;

            -a luta entre bem e mal;

            -amor e coragem;

            -identidade, destino e transcendência;

            -o poder da linguagem.


             Últimos Anos e Morte:
            Em novembro de 1967, tomou posse na Academia Brasileira de Letras, realizando um sonho antigo.
            Três dias depois, morreu de infarto, aos 59 anos. Sua morte precoce deixou a literatura brasileira em luto, sem que ele tivesse concluído outros projetos e manuscritos.

             Legado:
            -um dos maiores escritores da língua portuguesa

            -inovador radical da linguagem

            -mestre na representação do sertão

            -autor universal, comparado a James Joyce, Kafka e Faulkner

            Suas obras continuam sendo estudadas e celebradas mundialmente por sua profundidade, complexidade e beleza.
            " },

            new Autor { AutorId = 5, Nome = "José de Alencar", Foto = "/img/autores/José de Alencar.png", Biografia =
            @" José Martiniano de Alencar, conhecido como José de Alencar, nasceu em 1º de maio de 1829, em Mecejana (hoje bairro de Fortaleza), Ceará, e morreu em 12 de dezembro de 1877, no Rio de Janeiro.
            É considerado o maior romancista do Romantismo brasileiro, pai do romance indianista e um dos escritores mais influentes do século XIX.

             Infância e Formação:
            Filho de uma família politicamente influente, José de Alencar mudou-se ainda jovem para o Rio de Janeiro.
            Estudou em colégios tradicionais e ingressou na Faculdade de Direito de São Paulo, onde participou de grupos literários e escreveu para jornais estudantis.
            Formou-se em 1850 e trabalhou como advogado, mas desde cedo demonstrou forte vocação para a literatura.

             Carreira Jornalística e Literária:
            Alencar começou a carreira escrevendo crônicas, críticas e folhetins para jornais importantes do Rio de Janeiro.
            Em pouco tempo chamou atenção pelo seu estilo nacionalista, elegante e voltado para a construção de uma identidade brasileira na literatura.
           
            Ele buscou retratar:
            -a natureza

            -os costumes do país

            -a formação do povo brasileiro

            -o romantismo idealizado dos indígenas

            -dramas urbanos do século XIX


             As fases da obra de Alencar:
            José de Alencar produziu uma obra vasta e diversificada, dividida em três grandes grupos

            1. Romances Indianistas
            Nessas obras, o indígena aparece como herói nacional e símbolo da identidade brasileira.
            -O Guarani (1857) – sua obra mais famosa
            -Iracema (1865) – a “virgem dos lábios de mel”, símbolo do Ceará
            -Ubirajara (1874)

            2. Romances Urbanos
            Mostram a sociedade carioca do século XIX e os conflitos sociais e amorosos da época.
            -Lucíola (1862)
            -Diva(1864)
            -Senhora (1875) – seu romance urbano mais célebre

            3. Romances Regionalistas
            Retratam a vida no interior do Brasil e seus costumes.
            -O Gaúcho (1870)
            -O Tronco do Ipê (1871)
            -O Sertanejo (1875)

            Além disso, escreveu peças de teatro e discursos políticos.

             Carreira política:
            José de Alencar também teve trajetória importante na política. Foi,
            -Deputado geral
            -Ministro da Justiça (1868)

            Era defensor do conservadorismo da época e crítico feroz do imperador Dom Pedro II, o que gerou atritos que impediram sua nomeação ao Senado vitalício.

             Estilo literário:
            Alencar marcou o Romantismo brasileiro com características como,
            -forte nacionalismo

            -linguagem poética e descritiva

            -idealização do indígena

            -defesa da identidade cultural brasileira

            -crítica social nos romances urbanos

            É considerado um dos escritores que mais contribuíram para construir a literatura brasileira como algo distinto da literatura portuguesa.

             Últimos Anos e Morte:
            Nos anos finais, sofreu com problemas de saúde, especialmente tuberculose.
            Faleceu em 12 de dezembro de 1877, aos 48 anos, deixando uma obra vasta e fundamental.

             Legado
            -pai do romance nacional

            -criador do mito literário de Iracema

            -um dos maiores nomes do Romantismo

            -pioneiro da literatura verdadeiramente brasileira

            Sua obra continua amplamente estudada nas escolas e universidades e permanece como parte central da tradição literária do país.
            " },

            new Autor { AutorId = 6, Nome = "Luis de Camões", Foto = "/img/autores/Luis de Camões.png", Biografia = @"
            Luís Vaz de Camões nasceu provavelmente em 1524, em Lisboa (embora algumas fontes mencionem Coimbra), e morreu em 10 de junho de 1580, também em Lisboa.
            É considerado o maior poeta da língua portuguesa e um dos maiores da literatura mundial.
            Sua obra-prima, “Os Lusíadas”, é o grande épico nacional de Portugal e celebra as navegações portuguesas, especialmente a viagem de Vasco da Gama à Índia.

            Infância e formação:
            Pouco se sabe com precisão sobre sua infância.
            Camões nasceu em uma família nobre, embora não muito rica.
            Estudou letras, latim, história e filosofia, provavelmente no Mosteiro de Santa Cruz de Coimbra, o que explica sua vasta cultura clássica.
            
            Ainda jovem começou a escrever poesia lírica, influenciado por,
            - Petrarca

            - Dante

            - os clássicos greco-romanos

            Juventude e vida militar:
            Camões teve uma vida agitada. Foi soldado do rei e participou de diversas campanhas militares.
            Serviu no norte da África e, em uma batalha em Ceuta, perdeu o olho direito, o que lhe rendeu o apelido de “o Cisne de um só olho”.
            Sua vida turbulenta incluiu: duelos, brigas, dificuldades financeiras, prisão por ferir um funcionário da corte e mesmo com esses conflitos, nunca deixou de escrever.

            Viagem ao Oriente:
            Em 1553, Camões embarcou para a Índia como militar.
            Viajou por Goa, Macau e Moçambique.

            E viveu por 17 anos no Oriente, passando por naufrágios, doenças e pobreza.
            
            Segundo relatos, durante um naufrágio próximo ao Camboja, Camões teria salvo o manuscrito de “Os Lusíadas” nadando com o livro acima da água.

            “Os Lusíadas”
            Publicado em 1572, é o grande poema épico da língua portuguesa, composto por 10 cantos em oitavas rimadas.
            A obra exalta:
            - as Grandes Navegações

            - o heroísmo português

            - a história de Portugal

            - mitologia greco-romana

            - críticas sociais e políticas disfarçadas

            Tem como eixo central a viagem de Vasco da Gama à Índia (1498).
            O poema combina história, ficção, mito e filosofia, e garantiu a Camões um lugar permanente na literatura mundial.

            Poesia lírica:
            Além do épico, Camões escreveu um vasto conjunto de poemas líricos, entre eles,
            - sonetos

            - canções

            - odas

            - redondilhas

            Seus sonetos são considerados algumas das obras-primas da lírica ocidental, abordando temas com,
            - amor idealizado

            - saudade

            - sofrimento

            - tempo e morte

            - desilusão com o mundo

            Últimos anos:
            Ao voltar a Portugal, Camões encontrou o país empobrecido e mergulhado em crise.
            Recebeu uma pequena pensão do rei, insuficiente para viver bem.
            Passou seus últimos anos em dificuldades financeiras e saúde frágil.
            Morreu em 10 de junho de 1580, ano em que Portugal perdeu sua independência para a Espanha — fato que ele lamentou antes de morrer:
            “Morro com a Pátria.”

            Legado:
            - o maior poeta da língua portuguesa

            - símbolo da literatura lusófona

            - referência mundial em poesia épica e lírica

            - autor estudado em todo o mundo

            Em sua homenagem, o dia de sua morte, 10 de junho, é o Dia de Portugal, de Camões e das Comunidades Portuguesas.
            " },

            new Autor { AutorId = 7, Nome = "Carolina Maria de Jesus", Foto = "/img/autores/Carolina Maria de Jesus.png", Biografia = 
            @" Carolina Maria de Jesus (nascida em 14 de março de 1914, em Sacramento, Minas Gerais, e falecida em 13 de fevereiro de 1977, em São Paulo) foi escritora, poeta, compositora e uma das vozes mais importantes da literatura brasileira, especialmente por denunciar a pobreza, o racismo e as desigualdades sociais a partir de sua própria experiência.
            É considerada hoje uma das maiores autoras do país, reconhecida nacional e internacionalmente.
           
            Infância e juventude:
            Carolina nasceu em uma família muito pobre e teve pouquíssima escolaridade formal, estudando apenas até o segundo ano do ensino fundamental. Ainda assim, aprendeu a ler e escrever com enorme interesse, desenvolvendo desde cedo paixão por palavras e cadernos.
            Na juventude, mudou-se para São Paulo em busca de trabalho e melhores condições de vida. Após dificuldades, passou a viver na Favela do Canindé, às margens do Rio Tietê.
            A vida na favela e o início da escrita
            Para sustentar seus três filhos, Carolina trabalhava como catadora de papel. No pouco tempo livre que tinha, escrevia em cadernos achados no lixo, registrando:
            -sua vida na favela
            -a fome e a miséria
            -o descaso do governo
            
            Suas Reflexões Sobre Dignidade, Humanidade e Esperança:
            Seus textos misturavam relato, poesia e crítica social.

            Descoberta e fama literária:
            Em 1958, o jornalista Audálio Dantas conheceu Carolina ao vê-la escrevendo durante um conflito na favela. Impressionado com sua força literária, começou a divulgar seus textos.
            Em 1960, foi lançado o livro “Quarto de Despejo: Diário de uma Favelada”, que se tornou um enorme sucesso. A obra foi traduzida para mais de 14 idiomas e publicada em mais de 40 países.
            
            Por que o livro é tão importante?
            Porque é um relato real, duro e humano do cotidiano da pobreza, escrito por quem a viveu. Carolina rompeu barreiras e deu visibilidade a vidas que eram ignoradas pela sociedade..
           
            Últimos anos:
            Apesar do sucesso inicial, Carolina enfrentou dificuldades econômicas e preconceito racial e social ao longo de toda a vida. Passou seus últimos anos no interior de São Paulo, em Parelheiros, escrevendo e criando galinhas e porcos.
            Faleceu em 1977, aos 62 anos.
            
            Legado:
            Carolina Maria de Jesus é hoje reconhecida como uma das maiores escritoras brasileiras, pioneira na literatura marginal e periférica, símbolo de resistência, força e voz das comunidades pobres e referência para gerações de escritores negros
            Seus escritos continuam impactantes, atuais e essenciais para entender o Brasil.
            " },

            new Autor { AutorId = 8, Nome = "Carlos drummond de Andrade", Foto = "/img/autores/Carlos drummond de Andrade.png", Biografia = 
            @"Carlos Drummond de Andrade (nascido em 31 de outubro de 1902, em Itabira, Minas Gerais, e falecido em 17 de agosto de 1987, no Rio de Janeiro) é considerado um dos maiores poetas da língua portuguesa e um dos principais nomes da literatura brasileira do século XX. Seu estilo único, irônico, humano e profundamente reflexivo marcou de forma definitiva a poesia moderna no Brasil.
            
            Infância e juventude:
            Drummond nasceu em uma tradicional família mineira. Em Itabira, viveu a infância e adolescência que mais tarde inspirariam muitos de seus poemas, especialmente os que tratam de memória, raízes e identidade.
            Estudou em colégios internos e depois fez o curso de Farmácia, embora nunca tenha exercido a profissão.
            Ainda jovem, tornou-se colaborador de jornais e revistas literárias.
            
            Carreira literária:
            Drummond fez parte da segunda geração modernista, ao lado de nomes como Mário Quintana e Cecília Meireles. Sua obra dialoga com o cotidiano, os conflitos humanos, a crítica social e os dilemas existenciais.
            Seu primeiro livro, “Alguma Poesia” (1930), já trazia dois de seus poemas mais famosos:
            “No meio do caminho” e “Poema de Sete Faces”

            Ao longo da carreira, publicou mais de 50 obras, entre poesia, contos, crônicas e literatura infantil.
            Temas recorrentes:
            - o individual e o coletivo

            - solidão e afetos

            - memória e identidade

            - vida urbana

            - conflitos sociais

            - passagem do tempo

            - amor e desilusões

            - o absurdo e o mistério da existência

            Seu verso é ao mesmo tempo simples e sofisticado, capaz de transformar o cotidiano em poesia.
            
            Atuação profissional:
            Além de poeta, Drummond atuou por décadas como funcionário público, chegando a ser chefe de gabinete do então ministro da Educação, Gustavo Capanema, durante o governo Vargas.
            Trabalhou também como cronista e jornalista em jornais importantes, como o Correio da Manhã, O Jornal e Jornal do Brasil, onde suas crônicas se tornaram extremamente populares.
            Vida pessoal
            Casou-se com Dolores Dutra de Morais, com quem teve uma filha, Maria Julieta, também escritora. Era uma pessoa reservada, de humor peculiar e grande sensibilidade. Viveu seus últimos anos no Rio de Janeiro.
            Drummond faleceu em 1987, poucos dias após a morte da filha, fato que abalou profundamente seus últimos dias.
            Legado
            Carlos Drummond de Andrade é considerado o maior poeta brasileiro moderno, um dos autores mais lidos e estudados em escolas e universidades, referência na poesia da língua portuguesa e mestre em transformar sentimentos profundos em palavras simples
            Seus versos continuam influenciando leitores, escritores e músicos, mantendo-o como um dos maiores nomes da literatura de todos os tempos.
            "  },

            new Autor { AutorId = 9, Nome = "Darcy Ribeiro", Foto = "/img/autores/Darcy Ribeiro.png", Biografia =
            @"
            Darcy Ribeiro (nascido em 26 de outubro de 1922, em Montes Claros, Minas Gerais, e falecido em 17 de fevereiro de 1997, em Brasília) foi um dos mais importantes antropólogos, educadores, escritores e políticos brasileiros. Sua atuação intelectual e pública marcou profundamente os debates sobre educação, cultura, povos indígenas e construção da identidade nacional no Brasil.
            É considerado um dos maiores pensadores brasileiros do século XX.

            Infância e formação:
            Darcy cresceu em Minas Gerais e mudou-se jovem para Belo Horizonte, onde iniciou seus estudos superiores.
            Ingressou na Faculdade de Medicina, mas logo abandonou o curso para seguir sua verdadeira vocação: estudar antropologia.
            Na década de 1940, se aproximou de pesquisadores como Claude Lévi-Strauss e iniciou seus trabalhos etnográficos com povos indígenas brasileiros.

            Carreira como antropólogo e a defesa dos povos indígenas:
            Darcy dedicou grande parte da vida ao estudo e proteção dos povos originários. Foi responsável por pesquisas marcantes sobre etnias como, Kadiwéu, Urubu-Kaapor, Xavante e Tenetehara

            Em 1957, tornou-se o primeiro diretor do Museu do Índio e coordenou o antigo Serviço de Proteção ao Índio (SPI), que mais tarde daria origem à FUNAI.
            Defendeu incansavelmente a autonomia, a cultura e os direitos dos povos indígenas.
           
            Atuação na educação:
            Darcy foi um dos maiores educadores do Brasil.
            Em 1962, convidado por Anísio Teixeira, participou da formulação de projetos educacionais inovadores.
            Foi Ministro da Educação no governo João Goulart, criador da Universidade de Brasília (UnB), da qual foi vice-reitor e depois reitor, responsável por importantes planos de ampliação e democratização do ensino

            Em seus últimos anos, idealizou no Rio de Janeiro os CIEPs (Centros Integrados de Educação Pública), em parceria com Leonel Brizola — escolas integrais pioneiras no país.

            Exílio político:
            Com o golpe militar de 1964, Darcy foi cassado e exilado.
            Viveu por mais de 10 anos no Chile, Uruguai e Venezuela.
            Nesse período escreveu algumas de suas obras mais importantes, incluindo estudos sobre o Brasil e a formação do povo latino-americano.

            Carreira política:
            Após a anistia, retornou ao Brasil e continuou atuando na vida pública. Foi,
            - vice-governador do Rio de Janeiro (1983–1987)

            - senador pelo PDT (1991–1997)

            No Senado, desempenhou papel ativo em debates sobre educação, povos indígenas e políticas sociais.

            Últimos anos e morte:
            Darcy Ribeiro morreu em Brasília em 1997, aos 74 anos, vítima de câncer.
            Pouco antes de falecer, disse a famosa frase:
            “Eu não gostaria de ser lembrado como alguém que fez tudo o que pôde.
            Quero ser lembrado como alguém que fez tudo o que não pôde, mas fez mesmo assim.”

            Legado:
            - um dos maiores intelectuais brasileiros

            - referência em antropologia, educação e políticas públicas

            - defensor incansável dos povos indígenas

            - pensador fundamental para compreender o Brasil

            Sua obra segue atual, inspirando debates sobre identidade, democracia, desigualdade e futuro do país.
            "  },

            new Autor { AutorId = 10, Nome = "Graciliano Ramos",Foto = "/img/autores/Graciliano Ramos.png", Biografia =
            @"
            Graciliano Ramos nasceu em 27 de outubro de 1892, na cidade de Quebrangulo, em Alagoas, e faleceu em 20 de março de 1953, no Rio de Janeiro. É considerado um dos maiores escritores do Modernismo brasileiro, especialmente da segunda fase (1930), marcada por obras sociais, realistas e de forte crítica às desigualdades do país.
            Seu estilo seco, direto e preciso é uma das marcas mais fortes da literatura brasileira.

            Infância e formação:
            Graciliano passou parte da infância em Buíque (PE) e depois em Viçosa (AL).
            Foi um menino introspectivo, leitor voraz e atento aos detalhes do cotidiano – traços que mais tarde definiriam sua escrita.
            Não teve formação universitária; foi autodidata, aprendendo por conta própria através de livros.

            Carreira como jornalista e funcionário público:
            Ainda jovem, Graciliano trabalhou como,
            - revisor de jornal

            - redator

            - professor

            - jornalista

            Em 1928, assumiu o cargo de prefeito de Palmeira dos Índios, onde ganhou fama por administrar a cidade com organização e rigor. Seus relatórios administrativos, escritos com precisão literária, chamaram a atenção do cenário intelectual brasileiro.
            Mais tarde, mudou-se para Maceió, onde se tornou diretor da Imprensa Oficial do estado.

            Prisão e influência na sua obra:
            Em 1936, durante o governo de Getúlio Vargas, Graciliano foi preso sob suspeita de envolvimento com movimentos comunistas — embora não houvesse provas concretas.
            Ficou quase um ano encarcerado em diversas prisões, experiência traumática que relatou no livro:
            “Memórias do Cárcere” (póstumo, 1953)

            Essa obra é uma das mais importantes denúncias políticas da literatura brasileira.

            Suas obras evidenciam:
            - crítica social

            - psicologia profunda dos personagens

            - realismo duro e preciso

            - atenção às injustiças do Nordeste brasileiro

            Últimos anos:
            Nos anos finais, Graciliano filiou-se ao Partido Comunista Brasileiro (PCB) e passou a atuar politicamente, viajando inclusive à União Soviética.
            Faleceu no Rio de Janeiro, em 1953, vítima de câncer no pulmão.

            Legado:
            - um dos maiores prosadores da literatura brasileira

            - mestre do estilo conciso e direto

            - autor de algumas das obras mais importantes do modernismo de 1930

            - crítico profundo das injustiças sociais

            Seus livros continuam sendo estudados nas escolas e universidades e inspiram debates sobre o Brasil, a pobreza, o poder e o sofrimento humano.
            "  },

            new Autor { AutorId = 11, Nome = "Aluísio Azevedo", Foto = "/img/autores/Aluísio Azevedo.png", Biografia =
            @"
              Aluísio Tancredo Gonçalves de Azevedo (nascido em 14 de abril de 1857, em São Luís, Maranhão, e falecido em 21 de janeiro de 1913, em Buenos Aires, Argentina) foi um importante escritor, jornalista, caricaturista e diplomata brasileiro, reconhecido principalmente como o maior representante do Naturalismo no Brasil.
              Juventude e formação
              Filho de um vice-cônsul português e de uma maranhense, cresceu em um ambiente familiar marcado por influências políticas e culturais. Ainda jovem, demonstrou talento artístico e mudou-se para o Rio de Janeiro, onde estudou na Academia Imperial de Belas-Artes. Ali desenvolveu-se como pintor e caricaturista, colaborando com jornais satíricos.
              Ingresso na literatura
              A carreira literária começou em 1879 com o romance “Uma Lágrima de Mulher”, ainda de forte influência romântica. No entanto, logo Azevedo aderiu ao Naturalismo, movimento literário influenciado pelo cientificismo, pelo determinismo e pela observação social crítica.
              
              As obras retratam:
              - desigualdades sociais

              - preconceito racial

              - condições de vida dos trabalhadores pobres

              - hipocrisia das elites

              - influência do meio e da hereditariedade
              
              - Jornalismo e carreira diplomática

              Além de escritor, Azevedo atuou como jornalista e como caricaturista, colaborando com diversos periódicos. Em 1895, passou a integrar o serviço diplomático brasileiro e serviu em países como Espanha, Inglaterra, Japão e Argentina.
              Sua dedicação à diplomacia acabou afastando-o gradualmente da produção literária. Viveu seus últimos anos em Buenos Aires, onde faleceu em 1913.
              
              Legado:
              - pioneiro do Naturalismo no Brasil

              - um dos escritores mais importantes do fim do século XIX

              - crítico agudo da sociedade brasileira

              - autor de obras que até hoje são estudadas em escolas, vestibulares e universidades"  },

            new Autor { AutorId = 12, Nome = "José Paulo Paes",Foto = "/img/autores/Jose Paulo Paes.png", Biografia =
            @"
              José Paulo Paes nasceu em 22 de julho de 1926, em Taquaritinga (SP), e faleceu em 9 de outubro de 1998, em São Paulo.
              Foi poeta, tradutor, ensaísta e crítico literário, considerado um dos mais importantes nomes da poesia brasileira do século XX, especialmente pela sua escrita concisa, irônica, inteligente e profundamente crítica.

              Infância e formação:
              Cresceu no interior de São Paulo e mudou-se para Curitiba ainda jovem.
              Formou-se em Química Industrial pela Universidade Federal do Paraná — profissão que exerceu por muitos anos.
              Apesar de não ter formação acadêmica em Letras, tornou-se uma das vozes literárias mais respeitadas de sua geração.
              Desde cedo, escrevia poemas curtos, humorísticos e reflexivos.

              Início da carreira literária:
              Publicou seu primeiro livro, “O Aluno” (1947), aos 21 anos.
              Seu estilo chamou atenção por reunir,
              - humor e ironia

              - linguagem direta

              - crítica social e cultural

              - reflexões filosóficas

              - jogos de palavras e epigramas (poemas breves e satíricos)

              Foi identificado com a chamada “geração de 45”, que buscava rigor formal e concisão depois da fase mais livre do modernismo.

              A poesia é marcada por:
              - brevidade

              - humor crítico

              - experimentação linguística

              - olhar filosófico sobre o cotidiano

              - reflexões sobre a condição humana

              Transformava situações simples em profundas reflexões, sempre com leveza e inteligência.

              Reconhecimento:
              Recebeu diversos prêmios literários e tornou-se membro da Academia Brasileira de Letras (cadeira nº 26), embora tenha falecido antes da posse oficial.
              Foi amplamente respeitado por escritores, críticos e leitores por sua inteligência, humor refinado e contribuição à poesia moderna.

              Morte e legado:
              José Paulo Paes morreu em 1998, aos 72 anos.
              Deixou uma obra essencial para compreender a poesia brasileira contemporânea, especialmente o poema curto, irônico e filosófico.
              Seu legado permanece vivo nas escolas, universidades e entre leitores que apreciam a união entre simplicidade, humor e profundidade"  },

            new Autor { AutorId = 13, Nome = "Conceição Evaristo",Foto = "/img/autores/Conceição Evaristo.png", Biografia =
            @"
            Maria da Conceição Evaristo de Brito (nascida em 29 de novembro de 1946, em Belo Horizonte, Minas Gerais) é uma das mais importantes escritoras, professoras, pesquisadoras e vozes da literatura afro-brasileira. Sua obra é marcada pela denúncia das desigualdades sociais, pelo combate ao racismo e pela valorização das vivências de mulheres negras.
            Conceição é referência na chamada escrevivência, um conceito que ela criou para expressar a escrita que nasce da vida — das memórias, dores, lutas e resistências da população negra.

            Infância e juventude:
            Conceição cresceu em uma família pobre no bairro do Pindura Saia, em Belo Horizonte.
            Filha de empregada doméstica, trabalhou como babá e cozinheira desde muito jovem para ajudar nas despesas de casa.
            Apesar das dificuldades, sempre demonstrou grande amor pela leitura e escreveu desde a infância.

            Mudança para o Rio de Janeiro e formação:
            Na década de 1970, mudou-se para o Rio de Janeiro, onde ingressou no magistério. Aos 25 anos, concluiu o curso normal e passou a trabalhar como professora.
            Com grande esforço, ingressou na Universidade Federal do Rio de Janeiro (UFRJ), graduando-se em Letras.
            Depois, fez mestrado em Literatura Brasileira na PUC-Rio, e doutorado em Literatura Comparada na Universidade Federal Fluminense (UFF).

            Carreira literária e escrevivência:
            A estreia literária ocorreu em 1990, na Série Cadernos Negros, fundamental para autores negros no Brasil.
            A partir daí, Conceição se consolidou como uma das maiores escritoras brasileiras contemporâneas, com textos que abordam,
            - racismo estrutural

            - violência contra a mulher

            - desigualdades sociais

            - ancestralidade africana

            - resistência e identidade negra

            - memória e cotidiano periférico

            Conceição Evaristo é considerada uma das maiores autoras negras da literatura brasileira, símbolo de resistência e representatividade, referência em estudos de literatura afro-brasileira, grande difusora do conceito de escrevivência

            Em 2018, foi indicada pela sociedade civil para ocupar uma cadeira na Academia Brasileira de Letras (ABL), movimento histórico que gerou grande mobilização nacional.
            Seus livros são estudados em escolas, vestibulares, universidades e pesquisas acadêmicas, influenciando novas gerações de escritores negros.

            Vida atual:
            Conceição segue escrevendo, participando de feiras literárias no Brasil e no exterior, dando palestras e debatendo temas como:
            - direitos humanos

            - literatura

            - educação

            - racismo

            - lugar das mulheres negras na sociedade

            Vive no Rio de Janeiro e permanece como uma das vozes mais potentes e atuantes da literatura contemporânea.
            "  },

            new Autor { AutorId = 14, Nome = "Ailton Krenak",Foto = "/img/autores/Ailton Krenak.png", Biografia =
            @"
              Ailton Alves Lacerda Krenak (nascido em 1953, em Resplendor, Minas Gerais) é um dos mais importantes líderes indígenas do Brasil, além de escritor, filósofo, ambientalista e referência mundial nas discussões sobre meio ambiente, direitos indígenas e novos modos de existência.
              Pertencente ao povo indígena Krenak, Ailton cresceu às margens do Rio Doce — rio que considera sagrado e cuja destruição pelo desastre da barragem da Samarco/Vale/BHP em 2015 tornou-se um marco em sua luta socioambiental.
              Atuação política e defesa dos povos indígenas
              Nos anos 1980, tornou-se uma figura central na mobilização pelos direitos indígenas. Durante a Assembleia Constituinte de 1987–1988, emocionou o país ao pintar o rosto de preto em protesto contra tentativas de retirar direitos indígenas no texto constitucional. Sua atuação foi decisiva para garantir os direitos originários na Constituição de 1988.
              Fundou e participou de diversas organizações de defesa indígena e ambiental, como a União dos Povos Indígenas.
              
              Pensamento e produção intelectual:
              Krenak se tornou um dos maiores pensadores contemporâneos do Brasil. Sua obra aborda temas como,
              - crise ambiental global

              - crítica ao modelo de desenvolvimento ocidental

              - importância da ancestralidade

              - visão indígena de mundo

              - relação harmônica entre ser humano e natureza

              Reconhecimento nacional e internacional:
              Krenak é membro da Academia Brasileira de Letras (cadeira 5, eleito em 2023), tornando-se um dos poucos indígenas a ocupar tal posição na instituição. Ele também recebeu diversos prêmios por sua atuação ambiental e cultural.
              Viaja pelo Brasil e pelo mundo dando palestras, cursos, conferências e participa ativamente de movimentos socioambientais e debates sobre o futuro do planeta.
              Legado
              Ailton Krenak é considerado uma das vozes mais importantes para a construção de um pensamento ecológico contemporâneo. Sua mensagem destaca que:
              A humanidade só tem futuro se aprender a viver em relação, não em exploração.
              Ele permanece como um líder visionário, inspirando debates sobre sustentabilidade, respeito aos povos originários e novos modos de existir no mundo.
              " },

            new Autor { AutorId = 15, Nome = "Lima Barreto",Foto = "/img/autores/Lima Barreto.png", Biografia = @"
            Afonso Henriques de Lima Barreto, conhecido como Lima Barreto, nasceu em 13 de maio de 1881, no Rio de Janeiro, e morreu em 1º de novembro de 1922, na mesma cidade.
            É um dos mais importantes escritores brasileiros do início do século XX, marcado pelo estilo crítico, direto, antielitista e profundamente humano.
            Sua obra denuncia o racismo, a desigualdade social, a hipocrisia das elites e a burocracia estatal, tornando-se cada vez mais valorizada na atualidade.

            Infância e formação:
            Lima Barreto nasceu em uma família humilde. Seu pai era tipógrafo e sua mãe, professora — ela faleceu quando ele tinha 7 anos.
            Estudou em boas escolas graças ao apoio do padrinho, Visconde de Ouro Preto.
            Ingressou na Escola Politécnica, para cursar Engenharia, mas abandonou o curso para sustentar a família quando o pai adoeceu mentalmente.
            Desde cedo publicou crônicas, artigos e contos em jornais cariocas.

            Carreira literária:
            Lima Barreto trabalhou como escriturário na Secretaria da Guerra, função burocrática que detestava, mas que lhe garantia sustento e o inspirou a criticar a máquina pública em seus textos.
            Foi um escritor marginalizado pela elite literária de sua época, especialmente pela Academia Brasileira de Letras, que rejeitou suas tentativas de ingresso por preconceito racial e social.
            Apesar disso, continuou produzindo intensamente.

            Temas centrais:
            - racismo e injustiça social

            - desigualdade urbana

            - corrupção e burocracia

            - crítica às elites e ao academicismo

            - loucura, alcoolismo e exclusão

            - vida nas periferias do Rio

            Sua escrita é simples, direta, irônica e profundamente empática.

            Problemas pessoais e alcoolismo:
            Lima Barreto enfrentou episódios de depressão, pobreza e alcoolismo.
            Foi internado duas vezes no hospício, experiências que apareceriam em seus textos, como em:
            “O Cemitério dos Vivos” – obra autobiográfica, publicada postumamente.

            Últimos anos e morte:
            Viveu seus últimos anos em dificuldades financeiras e sem reconhecimento oficial.
            Morreu aos 41 anos, vítima de problemas cardíacos agravados pelo alcoolismo.

            Legado:
            Hoje, Lima Barreto é reconhecido como um dos maiores escritores brasileiros, precursor da literatura social, crítico genial do racismo estrutural e referência obrigatória da literatura moderna


            Sua obra ganhou grande destaque a partir dos anos 2000, sendo amplamente reeditada, adaptada e estudada, mostrando sua atualidade e importância histórica.
            "  },

            new Autor { AutorId = 16, Nome = "Chimamanda Ngozi Adichie", Foto = "/img/autores/Chimamanda Ngozi Adichie.png", Biografia =
            @"
            Chimamanda Ngozi Adichie (nascida em 15 de setembro de 1977, em Enugu, Nigéria) é uma das escritoras contemporâneas mais importantes do mundo. Romancista, ensaísta e palestrante, é reconhecida internacionalmente por obras que abordam temas como identidade, feminismo, imigração, política, racismo e a experiência africana no mundo globalizado.
            Cresceu na cidade de Nsukka, em uma família ligada ao ambiente acadêmico — seu pai era professor universitário e sua mãe, administradora na Universidade da Nigéria.

            Formação e trajetória:
            Aos 19 anos, mudou-se para os Estados Unidos para estudar Comunicação e Ciência Política na Drexel University e, posteriormente, na Eastern Connecticut State University.
            Completou mestrado em Escrita Criativa pela Johns Hopkins University e outro em Estudos Africanos pela Yale University.
            Desde cedo, Chimamanda mostrou interesse pela escrita, influenciada por autoras como Chinua Achebe e Toni Morrison.

            Carreira literária:
            Chimamanda tornou-se uma voz fundamental na literatura contemporânea, com livros traduzidos em dezenas de idiomas.
            Atuação como feminista e palestrante
            Chimamanda ganhou reconhecimento mundial com sua palestra “We Should All Be Feminists” (Sejamos Todos Feministas), uma das mais assistidas do TED.
            Ela defende um feminismo inclusivo, acessível e cotidiano, e critica estereótipos sobre mulheres e sobre a África.
            Sua fala sobre “o perigo da história única” — a ideia de reduzir culturas a narrativas únicas e simplificadas — também se tornou referência mundial.

            Temas recorrentes na obra:
            - identidade cultural

            - feminismo

            - racismo

            - diáspora africana

            - política e sociedade nigeriana

            - imigração

            - relações familiares

            - perspectivas múltiplas sobre o continente africano

            Sua escrita é marcada por sensibilidade, humor, crítica social e forte habilidade narrativa.

            Chimamanda é considerada uma das vozes mais influentes da literatura do século XXI, grande referência do feminismo moderno, porta-voz global da intelectualidade africana, autora estudada em escolas e universidades ao redor do mundo

            Suas obras aparecem constantemente em listas internacionais de melhores livros e influenciam leitores jovens e adultos.

            Vida pessoal:
            Chimamanda alterna sua vida entre a Nigéria e os Estados Unidos.
            É casada e tem um filho. Continua escrevendo, palestrando e participando de debates sobre igualdade, política, cultura e literatura.
            "  },

            new Autor { AutorId = 17, Nome = "Caio Fernando Abreu", Foto = "/img/autores/Caio Fernando Abreu.png", Biografia =
            @"
              Caio Fernando Loureiro de Abreu (nascido em 12 de setembro de 1948, em Santiago, Rio Grande do Sul, e falecido em 25 de fevereiro de 1996, em Porto Alegre) foi um dos mais importantes escritores, dramaturgos e jornalistas brasileiros do século XX. Tornou-se conhecido por sua escrita sensível, intensa e profundamente humana, marcada por temas como amor, solidão, sexualidade, amizade, medo, e as angústias da vida contemporânea.
              
              Infância e juventude:
              Criado em família de classe média, Caio demonstrou cedo sua inclinação para a literatura. Ainda jovem, mudou-se para Porto Alegre, onde se envolveu ativamente com o meio cultural e literário. Após passar por tentativas frustradas de cursos universitários, mergulhou definitivamente no jornalismo e na escrita.
              
              Atuação jornalística e cultural:
              Caio trabalhou em grandes veículos de imprensa, como Revista Veja, Zero Hora e O Estado de S. Paulo. Também viveu períodos no exterior — em Londres, Paris e na Espanha — onde ampliou sua visão sobre política, cultura e comportamento.
              Durante os anos da ditadura militar, parte de seus textos expressou a tensão política e o sentimento de liberdade cerceada.
              
              Vida pessoal e temas recorrentes:
              Caio viveu de forma intensa e assumiu publicamente sua homossexualidade, algo incomum na época. Sua sensibilidade e franqueza transformaram seu texto em um espaço de acolhimento para jovens que se sentiam deslocados ou incompreendidos.
              Sua obra aborda:
              - amor e desamor

              - solidão

              - busca por identidade

              - sexualidade

              - afetos e fragilidades humanas

              - espiritualidade

              - crises políticas e sociais

              Doença e últimos anos:
              Nos anos 1990, Caio foi diagnosticado com HIV. Diferente de muitos artistas da época, falou sobre a doença abertamente em cartas e crônicas — gesto corajoso num tempo marcado por preconceito.
              Passou seus últimos anos em Porto Alegre, escrevendo e recebendo amigos. Morreu em 1996, aos 47 anos.
    
              Caio Fernando Abreu é considerado um dos maiores contistas da literatura brasileira, referência LGBTQIA+, símbolo da sensibilidade e da escrita emocional, autor que dialoga profundamente com jovens e adultos até hoje

              Seus textos continuam extremamente populares nas redes sociais, escolas e clubes de leitura, por sua capacidade única de nomear sentimentos difíceis e tocar o íntimo das pessoas.
              "  },

            new Autor { AutorId = 18, Nome = "Cartola", Foto = "/img/autores/Cartola.png", Biografia =
            @"
            Carolina Maria de Jesus (nascida em 14 de março de 1914, em Sacramento, Minas Gerais, e falecida em 13 de fevereiro de 1977, em São Paulo) foi escritora, poeta, compositora e uma das vozes mais importantes da literatura brasileira, especialmente por denunciar a pobreza, o racismo e as desigualdades sociais a partir de sua própria experiência.
            É considerada hoje uma das maiores autoras do país, reconhecida nacional e internacionalmente.
           
            Infância e juventude:
            Carolina nasceu em uma família muito pobre e teve pouquíssima escolaridade formal, estudando apenas até o segundo ano do ensino fundamental. Ainda assim, aprendeu a ler e escrever com enorme interesse, desenvolvendo desde cedo paixão por palavras e cadernos.
            Na juventude, mudou-se para São Paulo em busca de trabalho e melhores condições de vida. Após dificuldades, passou a viver na Favela do Canindé, às margens do Rio Tietê.
           
            A vida na favela e o início da escrita:
            Para sustentar seus três filhos, Carolina trabalhava como catadora de papel. No pouco tempo livre que tinha, escrevia em cadernos achados no lixo, registrando sua vida na favela, a fome e a miséria, o descaso do governo, suas reflexões sobre dignidade, humanidade e esperança

            Seus textos misturavam relato, poesia e crítica social.
            
            Descoberta e fama literária:
            Em 1958, o jornalista Audálio Dantas conheceu Carolina ao vê-la escrevendo durante um conflito na favela. Impressionado com sua força literária, começou a divulgar seus textos.
            Em 1960, foi lançado o livro “Quarto de Despejo: Diário de uma Favelada”, que se tornou um enorme sucesso. A obra foi traduzida para mais de 14 idiomas e publicada em mais de 40 países.
            
            Por que o livro é tão importante?
            é um relato real, duro e humano do cotidiano da pobreza, escrito por quem a viveu. Carolina rompeu barreiras e deu visibilidade a vidas que eram ignoradas pela sociedade..
           
            Últimos anos:
            Apesar do sucesso inicial, Carolina enfrentou dificuldades econômicas e preconceito racial e social ao longo de toda a vida. Passou seus últimos anos no interior de São Paulo, em Parelheiros, escrevendo e criando galinhas e porcos.
            Faleceu em 1977, aos 62 anos.
            
            Legado:
            Carolina Maria de Jesus é hoje reconhecida como uma das maiores escritoras brasileiras, pioneira na literatura marginal e periférica, símbolo de resistência, força e voz das comunidades pobres e referência para gerações de escritores negros
            Seus escritos continuam impactantes, atuais e essenciais para entender o Brasil.
            "  },

            new Autor { AutorId = 19, Nome = "Lewis Carroll", Foto = "/img/autores/Lewis Carroll.png", Biografia = @"
            Lewis Carroll era o pseudônimo de Charles Lutwidge Dodgson, escritor, matemático, lógico, fotógrafo e professor inglês.
            Ele nasceu em 27 de janeiro de 1832, em Daresbury, Cheshire (Inglaterra), e faleceu em 14 de janeiro de 1898, em Guildford.
            É mundialmente conhecido como o autor de “Alice no País das Maravilhas” e “Através do Espelho”, obras que revolucionaram a literatura infantojuvenil.

            Infância e formação:
            Carroll veio de uma família numerosa e religiosa. Desde cedo mostrou talento para a matemática, habilidade com palavras, gosto por contar histórias e interesse por teatro e jogos lógicos

            Estudou no Christ Church, da Universidade de Oxford, onde se destacou academicamente.

            Carreira como matemático e professor:
            Carroll foi professor de Matemática em Oxford por muitos anos.
            Publicou livros acadêmicos

            Seu raciocínio lógico influenciou diretamente sua literatura, cheia de paradoxos, jogos de linguagem e situações absurdas.

            A criação de Alice:
            A ideia para “Alice no País das Maravilhas” surgiu em 1862, durante um passeio de barco com as irmãs Liddell — especialmente Alice Liddell, para quem Carroll improvisou a história.
            A narrativa fez tanto sucesso que ele a escreveu e publicou em 1865.
            Principais características de “Alice”
            - humor nonsense

            - lógica invertida

            - personagens excêntricos

            - jogos de palavras

            - crítica sutil à sociedade vitoriana

            Fotografia:
            Lewis Carroll também foi um dos fotógrafos amadores mais importantes da Inglaterra vitoriana.
            Fotografou artistas, escritores, colegas de Oxford, cenas cotidianas, crianças e famílias conhecidas

            A fotografia era, para ele, uma forma de arte e estudo da expressão humana.

            Vida pessoal e personalidade:
            Carroll era tímido, reservado e profundamente ligado à lógica.
            Tinha tendência a gaguejar, o que o deixava desconfortável em situações sociais.
            Apesar disso, era querido pelos alunos e conhecido por sua gentileza e imaginação extraordinária.

            Morte:
            Lewis Carroll morreu de pneumonia em 14 de janeiro de 1898, aos 65 anos.
            
            Carroll é lembrado como:
            - um dos maiores autores de fantasia

            - pioneiro do nonsense literário

            - criador de personagens icônicos: Alice, Chapeleiro Maluco, Rainha de Copas

            - influenciador de autores, artistas e cineastas do mundo inteiro

            Seu estilo inovador, que mistura lógica, humor e imaginação, permanece atual e encantador até hoje."  },

            new Autor { AutorId = 20, Nome = "Djamilia Pereira de Almdeida", Foto = "/img/autores/Djamilia Pereira de Almdeida.png", Biografia =
            @"
            Djaimilia Pereira de Almeida (nascida em 1982, em Luanda, Angola) é uma escritora, ensaísta e intelectual contemporânea, de grande importância na literatura de língua portuguesa. 
            Quando tinha cerca de três anos, mudou-se com a família para Portugal, onde cresceu, nos arredores de Lisboa.

            Formou-se em Estudos Portugueses pela Universidade Nova de Lisboa.

            Em 2012, obteve doutorado em Teoria da Literatura pela Universidade de Lisboa. 
            Atualmente, Djaimilia é também professora da New York University (NYU).

            A escrita de Djaimilia se destaca por:
            - abordar a questão racial e a negritude a partir de uma perspectiva pessoal e crítica;

            - explorar a migração e o deslocamento — particularmente a experiência de africanos em Portugal.

            - refletir sobre identidade, memória, pertencimento e legado colonial;

            - utilizar uma prosa híbrida: muitas vezes seus livros combinam elementos de romance, ensaio, autobiografia e crônica.

            Ela representa uma das vozes mais vivas da literatura contemporânea de língua portuguesa — plural, crítica e de forte impacto social e cultural.

            Reconhecimento e prêmios:
            Vencedora do Prémio Oceanos pelo livro Luanda, Lisboa, Paraíso.

            Recebeu o Grande Prémio de Romance e Novela APE/DGLAB 2024.

            Em 2023, foi agraciada com o Prémio FLUL Alumni (Faculdade de Letras da Universidade de Lisboa).

            Em 2025, foi homenageada com o Prémio Vergílio Ferreira, concedido pela Universidade de Évora, pelo conjunto de sua obra.

            Além disso, sua obra está traduzida para várias línguas e é estudada internacionalmente. 

           Djaimilia Pereira de Almeida é hoje reconhecida como:
           - uma das principais escritoras da nova geração de autores lusófonos;

           - uma voz importante que dá visibilidade às experiências de afrodescendentes, imigrantes e mulheres negras — temas ainda pouco representados na literatura tradicional;

           - uma autora que ajuda a renovar a literatura de língua portuguesa, com uma prosa contemporânea, plural e híbrida;

           - uma intelectual que, além de escrever ficção, participa de debates sobre identidade, racismo, memória e pós-colonialismo — contribuindo para reflexões culturais profundas.
            " },

            new Autor { AutorId = 21, Nome = "Lygia Fagundes Telles", Foto = "/img/autores/Lygia Fagundes Telles.png", Biografia = @"
            Lygia Fagundes Telles nasceu em 19 de abril de 1923, em São Paulo, e morreu em 3 de abril de 2022, também em São Paulo.
            É considerada uma das maiores escritoras brasileiras do século XX, integrante da chamada terceira geração modernista. Sua obra é marcada pela profundidade psicológica, pelo foco na intimidade humana, e por temas como memória, desejo, culpa e identidade.
            Foi membro da Academia Brasileira de Letras (ABL) e vencedora de vários prêmios nacionais e internacionais.

            Infância e formação:
            Lygia cresceu entre São Paulo e o interior devido ao trabalho do pai, que era promotor público.
            Desde muito jovem demonstrou interesse pela escrita.
            
            Formou-se em:
            - Direito na famosa Faculdade de Direito do Largo de São Francisco (USP)

            - Educação Física (curso que chegou a cursar antes do Direito)

            Durante a juventude conviveu com importantes nomes da literatura brasileira, como Mário de Andrade e Oswald de Andrade.

            Início da carreira literária:
            Publicou seu primeiro livro aos 15 anos, Porão e Sobrado (1938).
            Seu reconhecimento, porém, cresceu nas décadas de 1940 e 1950, quando começou a publicar contos e romances que exploravam,
            - conflitos íntimos

            - dramas existenciais

            - relações humanas complexas

            As principais marcas do estilo de são:
            - narrativa introspectiva e psicológica

            - foco na subjetividade, especialmente feminina

            - fusão entre realidade e ficção

            - atmosfera intimista

            - linguagem poética e refinada

            É muito associada ao conto, gênero em que se destacou de forma excepcional.

            Atuação cultural e política:
            Além da literatura, Lygia participou ativamente da defesa dos direitos humanos e da liberdade artística durante o regime militar.
            Foi funcionária do Serviço Público e atuou na Cinemateca Brasileira, aproximando-se do cinema e de cineastas.
            Em 1985, tornou-se membro da Academia Brasileira de Letras.

            Prêmios:
            - Prêmio Jabuti (várias vezes)
            - Prêmio Camões (2005), o mais importante da língua portuguesa
            - Prêmio da Associação Paulista de Críticos de Arte

            Últimos anos:
            Mesmo com a idade avançada, Lygia continuou participando de eventos, entrevistas e publicações.
            Faleceu em 3 de abril de 2022, aos 98 anos, deixando um legado gigantesco para a literatura brasileira.

            Lygia Fagundes Telles é considerada a Grande Dama da Literatura Brasileira, uma das maiores contistas do país, referência na escrita feminina, intimista e psicológica, autora fundamental para vestibulares, universidades e estudos literários

            Sua obra permanece viva por sua profundidade, sensibilidade e força narrativa.
            " },
            new Autor { AutorId = 22, Nome = "Paulina Chiziane", Foto = "/img/autores/Paulina Chiziane.png", Biografia= @"
            Paulina Chiziane nasceu em 4 de junho de 1955, em Manjacaze, província de Gaza, Moçambique.
            É considerada uma das maiores escritoras moçambicanas, a primeira mulher a publicar um romance no país e a primeira autora africana de língua portuguesa a receber o Prêmio Camões (2021), o mais importante da literatura lusófona.
            Sua obra denuncia desigualdades, violências de gênero, colonialismo, guerra civil e conflitos culturais, sempre com forte presença da tradição oral africana.

            Infância e formação:
            Cresceu em uma família chope (etnia tradicional do sul de Moçambique) e, ainda criança, mudou-se para Lourenço Marques (hoje Maputo).
            Criada em ambiente rural e urbano, vivenciou desde cedo:
            - tradições locais

            - opressões coloniais

            - desigualdade social e racial

            - submissão feminina na sociedade patriarcal

            - Estudou no ensino missionário e aprendeu português como segunda língua.

            Juventude e contexto político:
            Viveu a adolescência durante o período colonial português.
            Com a independência de Moçambique, em 1975, trabalhou com organizações sociais e, mais tarde, na Cruz Vermelha, atuando com famílias atingidas pela guerra civil moçambicana (1977–1992).
            Essas experiências influenciaram profundamente sua escrita, marcada por testemunho, crítica e humanismo.

            Carreira literária:
            Paulina começou escrevendo contos e depois se dedicou ao romance, tornando-se pioneira na literatura de Moçambique escrita por mulheres.
            Seus livros unem,
            - crítica social

            - espiritualidade africana

            - tradições orais

            - protagonismo feminino

            - denúncia da violência de gênero

            - reflexão sobre identidade, cultura e pós-colonialismo

            Temas centrais de sua escrita:
            - condição feminina em Moçambique

            - tensões entre tradição e modernidade

            - colonialismo e pós-colonialismo

            - guerra civil

            - poligamia

            - poder, feitiçaria e espiritualidade

            - violência doméstica

            - identidades africanas

            Seu estilo mescla o português com ritmos, metáforas e estruturas da oralidade africana, criando uma narrativa poética, forte e simbólica.

            Em 2021, Paulina Chiziane tornou-se:
            - a primeira mulher africana a ganhar o Prêmio Camões
            - reconhecimento máximo da literatura de língua portuguesa
            O júri destacou a força política, social e estética de sua obra.

            Últimos anos:
            Paulina continua ativa, participando de eventos literários, debates sobre direitos das mulheres e projetos culturais. É hoje uma das vozes mais importantes da literatura africana contemporânea.

            Paulina Chiziane é pioneira da literatura feminina moçambicana, referência do feminismo africano, voz poderosa contra a violência de gênero, autora de obra original e profundamente moçambicana, leitura essencial para entender África, identidade e resistência

            Sua escrita ocupa lugar central na literatura lusófona e mundial.
            " },
            new Autor { AutorId = 23, Nome = "Rachel de Queiroz", Foto = "/img/autores/Rachel de Queiroz.png", Biografia = @"
            Rachel de Queiroz nasceu em 17 de novembro de 1910, em Fortaleza (CE), e morreu em 4 de novembro de 2003, no Rio de Janeiro (RJ).
            Foi romancista, cronista, dramaturga, tradutora e jornalista — considerada uma das maiores escritoras do Brasil e a primeira mulher a ingressar na Academia Brasileira de Letras (ABL).

            Infância e formação:
            Cresceu entre Fortaleza e o sertão do Ceará, especialmente em Quixadá, ambiente que marcaria profundamente sua literatura.
            Aos 15 anos, publicou seu primeiro texto em jornal.
            Era uma leitora precoce e se interessava por política, questões sociais e pela vida do sertão nordestino.

            Início da carreira literária:
            Aos 19 anos, publicou O Quinze (1930), seu romance de estreia, que a tornou nacionalmente conhecida.
            A obra narra a grande seca de 1915 no Ceará e seus impactos na vida de retirantes e sertanejos — clássico do Romance de 30, movimento marcado pelo realismo social e pela denúncia das desigualdades no Nordeste.
           
            Temas centrais:
            - a vida no sertão

            - seca e retirantes

            - desigualdades sociais

            - papel da mulher

            - tradição e modernidade

            - liberdade e escolha

            - conflitos familiares

            Seu estilo é marcado por:
            - clareza

            - linguagem enxuta

            - força emocional

            - observação humana profunda

            Vida política e jornalística:
            Rachel teve forte atuação na imprensa, Escreveu para O Povo, Diário da Manhã, O Cruzeiro e O Estado de S. Paulo, defendeu pautas sociais e posicionamentos políticos diversos ao longo da vida, Foi presa brevemente na época do Estado Novo por suas posições políticas, Atuou em debates públicos sobre cultura e sociedade, Além disso, traduziu obras de autores como Tolstói e Shakespeare.

            Academia Brasileira de Letras:
            Em 1977, Rachel tornou-se a primeira mulher eleita para a ABL, ocupando a cadeira 5.
            Sua entrada abriu caminho para diversas escritoras brasileiras.

            Prêmios e reconhecimentos:
            - Prêmio Camões (1993) – maior prêmio da literatura de língua portuguesa
            - Prêmio Saci
            - Prêmio Machado de Assis (ABL) pelo conjunto da obra
            - Título de Doutora Honoris Causa por várias universidades

            Últimos anos e morte:
            Rachel passou os últimos anos entre o Rio de Janeiro e o sítio “Não Me Deixes”, em Quixadá, Ceará.
            Morreu em 4 de novembro de 2003, aos 92 anos.

            Rachel de Queiroz é pioneira feminina na literatura brasileira, voz essencial do regionalismo nordestino, referência do Romance de 30, autora de obras presentes em vestibulares e estudos literários, uma das maiores escritoras da língua portuguesa

            Sua escrita combina realismo, sensibilidade e crítica social de forma única.
            " },
            new Autor { AutorId = 24, Nome = "Conceição Evaristo", Foto = "/img/autores/Conceição Evaristo.png", Biografia = @"
            Maria da Conceição Evaristo de Brito (nascida em 29 de novembro de 1946, em Belo Horizonte, Minas Gerais) é uma das mais importantes escritoras, professoras, pesquisadoras e vozes da literatura afro-brasileira. Sua obra é marcada pela denúncia das desigualdades sociais, pelo combate ao racismo e pela valorização das vivências de mulheres negras.
            Conceição é referência na chamada escrevivência, um conceito que ela criou para expressar a escrita que nasce da vida — das memórias, dores, lutas e resistências da população negra.

            Infância e juventude:
            Conceição cresceu em uma família pobre no bairro do Pindura Saia, em Belo Horizonte.
            Filha de empregada doméstica, trabalhou como babá e cozinheira desde muito jovem para ajudar nas despesas de casa.
            Apesar das dificuldades, sempre demonstrou grande amor pela leitura e escreveu desde a infância.

            Mudança para o Rio de Janeiro e formação:
            Na década de 1970, mudou-se para o Rio de Janeiro, onde ingressou no magistério. Aos 25 anos, concluiu o curso normal e passou a trabalhar como professora.
            Com grande esforço, ingressou na Universidade Federal do Rio de Janeiro (UFRJ), graduando-se em Letras.
            Depois, fez mestrado em Literatura Brasileira na PUC-Rio, e doutorado em Literatura Comparada na Universidade Federal Fluminense (UFF).

            Carreira literária e escrevivência:
            A estreia literária ocorreu em 1990, na Série Cadernos Negros, fundamental para autores negros no Brasil.
            A partir daí, Conceição se consolidou como uma das maiores escritoras brasileiras contemporâneas, com textos que abordam,
            - racismo estrutural

            - violência contra a mulher

            - desigualdades sociais

            - ancestralidade africana

            - resistência e identidade negra

            - memória e cotidiano periférico

            Conceição Evaristo é considerada uma das maiores autoras negras da literatura brasileira, símbolo de resistência e representatividade, referência em estudos de literatura afro-brasileira, grande difusora do conceito de escrevivência

            Em 2018, foi indicada pela sociedade civil para ocupar uma cadeira na Academia Brasileira de Letras (ABL), movimento histórico que gerou grande mobilização nacional.
            Seus livros são estudados em escolas, vestibulares, universidades e pesquisas acadêmicas, influenciando novas gerações de escritores negros.

            Vida atual:
            Conceição segue escrevendo, participando de feiras literárias no Brasil e no exterior, dando palestras e debatendo temas como:
            - direitos humanos

            - literatura

            - educação

            - racismo

            - lugar das mulheres negras na sociedade

            Vive no Rio de Janeiro e permanece como uma das vozes mais potentes e atuantes da literatura contemporânea.
            " },

            new Autor { AutorId = 25, Nome = "Julia Lopes de Almeida", Foto = "/img/autores/Julia Lopes de Almeida.png", Biografia = 
            @"Júlia Valentina da Silveira Lopes de Almeida, conhecida como JúliaLopes de Almeida, nasceu em 24 de setembro de 1862, no Rio de Janeiro, e morreu em 30 de maio de 1934, na mesma cidade.
            Foi romancista, cronista, contista, dramaturga e jornalista, considerada uma das mais importantes escritoras brasileiras do final do século XIX e início do XX. É reconhecida como pioneira na literatura feminina e uma das fundadoras da moderna literatura urbana no Brasil.

            Infância e formação:
            Júlia era filha de um médico e cresceu em um ambiente culto, onde desde cedo foi estimulada a estudar e ler.
            Recebeu educação formal acima da média das mulheres da época e começou a escrever ainda jovem.
            Com 20 anos, casou-se com o poeta e jornalista Filinto de Almeida, com quem teve filhos e também parceria intelectual.

            Carreira literária:
            Júlia publicou em jornais e revistas importantes, como O Paiz e Gazeta de Notícias, ganhando destaque por sua escrita elegante, crítica e sensível.
            Também escreveu para o público infantil e produziu peças de teatro.
            Sua obra aborda temas como:
            - papel da mulher na sociedade

            - vida urbana e conflitos familiares

            - moralidade, educação e modernização

            - questões sociais e psicológicas

            Foi uma das primeiras escritoras brasileiras a viver profissionalmente de literatura.

            Júlia foi figura central no debate sobre:
            - direitos das mulheres

            - educação feminina

            - igualdade intelectual

            - papel da mulher na literatura

            Ela influenciou outras autoras, como Lúcia Miguel Pereira, Rachel de Queiroz e Cecília Meireles.

            A polêmica da Academia Brasileira de Letras:
            Júlia Lopes de Almeida foi uma das idealizadoras da fundação da ABL, ao lado de seu marido e de diversos escritores.
            No entanto, não foi aceita como membro por ser mulher.
            Em seu lugar, foi incluído o marido, Filinto de Almeida.
            Hoje, Júlia é reconhecida como uma “acadêmica sem cadeira”, símbolo da exclusão feminina na literatura brasileira.

            Últimos anos e morte:
            Em seus últimos anos, continuou escrevendo e participando ativamente da vida cultural carioca.
            Faleceu em 1934, aos 71 anos.

            Júlia Lopes de Almeida é lembrada como:
            - uma das primeiras grandes romancistas brasileiras

            - pioneira na representação feminina na literatura

            - voz crítica da sociedade patriarcal do século XIX

            - referência na história da literatura e do feminismo no Brasil

            Seu reconhecimento cresceu muito no século XXI, com reedições de suas obras e estudos que recuperam sua importância.
            " },

            new Autor { AutorId = 26, Nome = "Narcisa Amália", Foto = "/img/autores/Narcisa Amália.png", Biografia = @"
            Narcisa Amália de Campos nasceu em 3 de abril de 1852, em São João da Barra (RJ), e morreu em 24 de julho de 1924, em Rio Claro (RJ).
            Foi poeta, jornalista, professora e ativista — considerada a primeira mulher a exercer profissionalmente o jornalismo no Brasil e uma das vozes femininas mais importantes do século XIX.
            Sua obra combina poesia romântica com críticas sociais, defesa da liberdade, abolicionismo e reivindicação dos direitos das mulheres.

            Infância e formação:
            Filha de um músico e de uma professora, Narcisa cresceu em um ambiente alfabetizado e culturalmente rico, algo incomum para mulheres do período.
            Desde cedo demonstrou talento para a escrita, e sua mãe teve papel essencial na sua formação intelectual.
            Aos 12 anos já escrevia poemas.

            Carreira literária:
            Narcisa Amália começou a publicar seus textos em jornais do Rio de Janeiro e de outras províncias.
            Aos 18 anos lançou o livro:
            Nebulosas (1872)
            - sua obra mais famosa
            - reúne poemas de forte carga romântica e social
            - recebeu elogios de escritores consagrados da época, como Machado de Assis, que destacou sua sensibilidade e energia poética.

            Narcisa se destacou como a primeira mulher jornalista profissional do Brasil, atuando em:
            - redações de jornais

            - periódicos abolicionistas

            - revistas literárias

            Escrevia sobre:
            - direitos das mulheres

            - abolição da escravidão

            - política

            - literatura

            - desigualdade social

            Foi colaboradora de jornais importantes como:
            - O Fluminense

            - A República

            - O País

            - Revista da Semana

            Também fundou e dirigiu periódicos voltados à educação e à emancipação feminina.

            Pioneirismo e ativismo:
            Narcisa Amália foi uma das primeiras mulheres brasileiras a defender igualdade de direitos entre homens e mulheres, participar ativamente do movimento abolicionista, ocupar espaços públicos e intelectuais dominados por homens, usar a imprensa como ferramenta política e educativa, Sua postura firme e progressista causou admiração e resistência em sua época.

            Sua poesia mistura:
            - romantismo tardio

            - subjetividade feminina

            - nacionalismo

            - crítica social

            - defesa da liberdade

            - exaltação da força feminina

            É considerada precursora da literatura de resistência feminina no Brasil.

            Vida pessoal e obstáculos
            Narcisa enfrentou dificuldades financeiras, preconceito por ser mulher em ambiente jornalístico, períodos de isolamento social após o casamento e separações, esquecimento após a morte. Mesmo assim, continuou escrevendo e defendendo suas ideias.

            Últimos anos e morte:
            Nos últimos anos viveu com poucos recursos e pouca visibilidade pública.
            Faleceu em 1924, em Rio Claro (RJ), deixando um legado injustamente apagado por décadas.

            Hoje, Narcisa Amália é reconhecida como:
            - a primeira mulher jornalista do Brasil

            - uma das pioneiras da literatura feminina

            - importante voz abolicionista e feminista

            - autora de obra poética marcante e engajada

            - figura essencial nos estudos sobre história das mulheres na literatura

            Seu livro Nebulosas é reeditado e estudado por universidades, resgatando seu valor literário e histórico.
            " },
            new Autor { AutorId = 27, Nome = "Sophia de Mello Breyner Andresen", Foto = "/img/autores/Sophia de Mello Breyner Andresen.png", Biografia = @"
            Sophia de Mello Breyner Andresen nasceu em 6 de novembro de 1919, no Porto, Portugal, e morreu em 2 de julho de 2004, em Lisboa.
            É considerada uma das maiores poetisas da literatura portuguesa e uma das vozes mais importantes do século XX.
            Sua escrita une beleza formal, humanismo, ética, natureza, mar, mitologia e compromisso político.
            Foi também autora de contos, textos infantis e tradutora.

            Infância e formação:
            Nasceu em uma família aristocrática do Porto, com forte influência cultural.
            Passou a infância entre o mar da Foz do Douro, jardins e casas antigas, contato com mitologia, arte e literatura clássica

            Essas experiências foram fundamentais em sua obra, marcada pelo mar, luz, paisagem e harmonia.
            Estudou Letras na Universidade de Lisboa, onde fortaleceu sua formação humanista.

            Início da carreira literária:
            Começou a escrever ainda jovem.
            
            Suas primeiras obras revelam:
            - forte presença da natureza

            - musicalidade

            - imaginação mítica

            - busca pela beleza e pela ética

            Nos anos 1940 publicou seus primeiros livros de poesia, conquistando reconhecimento imediato.
            
            Temas centrais:
            - O mar (símbolo de liberdade, origem e infinito)

            - Natureza e beleza

            - Mitologia grega (deuses, destino, harmonia)

            - Justiça e ética humana

            - Liberdade política

            - Busca pela verdade e pelo bem

            - Memória, infância e espiritualidade

            - Sua poesia é clara, luminosa, musical e rigorosa.

            Compromisso político:
            Sophia participou ativamente da resistência ao regime ditatorial de Salazar, integrando movimentos democráticos.
            Após a Revolução dos Cravos, em 1974, foi eleita deputada à Assembleia Constituinte, ajudando a escrever a nova Constituição Portuguesa (1976).
            Sua defesa dos direitos humanos e da liberdade está presente em muitos poemas.

            Prêmios:
            Foi a primeira mulher a receber o Prêmio Camões (1999), o maior reconhecimento da literatura em língua portuguesa.
            Também recebeu Grande Prêmio de Poesia da Sociedade Portuguesa de Escritores, Prêmio Max Jacob (França) e Medalha de Mérito Cultural (Portugal)

            Últimos anos e morte:
            Continuou escrevendo até o fim da vida.
            Faleceu em 2 de julho de 2004, em Lisboa, aos 84 anos.
            Em 2014, seus restos mortais foram trasladados para o Panteão Nacional, onde estão figuras ilustres da cultura portuguesa — uma honra raríssima.

            Sophia é considerada uma das maiores poetisas portuguesas de todos os tempos, referência de ética, liberdade e beleza poética, autora essencial para a literatura lusófona responsável por renovar a poesia portuguesa do século XX,  leitura obrigatória em escolas e universidades

            Sua obra permanece viva por sua força, verdade e simplicidade luminosa.

            " },

            new Autor { AutorId = 28, Nome = "Nísia Floresta", Foto = "/img/autores/Nísia Floresta.png", Biografia = @"
            Dionísia Gonçalves Pinto, conhecida como Nísia Floresta Brasileira Augusta, nasceu em 12 de outubro de 1810, em Papari (hoje Nísia Floresta), no Rio Grande do Norte, e morreu em 24 de abril de 1885, em Rouen, na França.
            É considerada a primeira feminista do Brasil, além de educadora, escritora, tradutora e ativista dos direitos das mulheres, dos indígenas e dos escravizados.

            Infância e formação:
            Filha de um líder político liberal, cresceu em um ambiente que valorizava estudos e debates.
            Casou-se muito jovem, mas separou-se em pouco tempo — o que era extremamente raro e ousado para uma mulher do século XIX.
            
            Depois passou a adotar o pseudônimo “Nísia Floresta Brasileira Augusta”:
            Nísia = forma abreviada de Dionísia
            Floresta = referência à sua cidade natal
            Brasileira Augusta = homenagem à pensadora feminista inglesa Mary Wollstonecraft

            Carreira como educadora:
            Em 1838, fundou no Rio de Janeiro o Colégio Augusto, uma das primeiras escolas brasileiras dedicadas à educação feminina moderna, oferecendo disciplinas que iam além das “artes domésticas”, como ciências, línguas, história, filosofia, literatura

            Defendia que mulheres tinham capacidade intelectual igual à dos homens, algo revolucionário na época.

            Atuação feminista e social:
            • Defesa dos direitos das mulheres
            Publicou livros e artigos defendendo educação, liberdade e direitos civis para as mulheres.
            • Luta abolicionista
            Criticava a escravidão como prática desumana e incompatível com o progresso moral.
            • Defesa dos povos indígenas
            Escreveu sobre a violência, o apagamento cultural e o abandono do Estado.
            Suas ideias eram extremamente avançadas para o Brasil do século XIX.

            Viagens e vida na Europa:
            Nísia viveu muitos anos na Itália, França, Alemanha e Inglaterra.

            Teve contato com filósofos, cientistas, escritores e movimentos intelectuais europeus.
            Frequentava círculos culturais e publicou em jornais europeus, defendendo o Brasil no exterior.

            Últimos anos e morte:
            Em 1870, fixou residência naa França, onde continuou escrevendo e estudando até sua morte.
            Faleceu em 24 de abril de 1885, em Rouen.
            Seu corpo foi transladado para o Brasil em 1954.

            Nísia Floresta é hoje reconhecida como a primeira feminista brasileira, pioneira na defesa da educação das mulheres, voz ativa contra a escravidão, defensora dos povos indígenas, figura fundamental da literatura, educação e sociologia brasileiras

            Sua cidade natal recebeu seu nome em homenagem à sua importância.
            " },


        };

        builder.Entity<Autor>().HasData(autores);

        List<Livro> livros = new List<Livro>

             {

 // ENEM
    new Livro {
      LivroId = 1,
      Nome = "Dona flor e seus dois maridos",
      Descricao = "A narrativa explora a paixão de Dona Flor por seus dois maridos, mostrando como ela lida com as diferenças entre eles e como busca a felicidade em meio a um triângulo amoroso.",
      Publicacao = "1966",
      AutorId = 1,
      Avaliacao = "4",
      NumeroPaginas= 480,
      Destaque = true,
      Foto = "/img/livros/Dona Flor e seus dois maridos.png",
      Video = "oxpXwPhc6Lo",
      Pdf = "/pdf/livros/dona-flor-e-seus-dois-maridos.pdf",
      Resumo =
     @" Durante um domingo de Carnaval vestido de baiana, Vadinho tropeça e cai enquanto dançava e acaba morrendo e seu funeral é bem concorrido, nele regressam as lembranças que estavam presentes, sobre o morto, os amigos de festa, as possíveis amantes, os colegas e especialmente a esposa Flor.

      	Flor lembra de seu marido infiel, de muita lábia, esperto, apostador e malicioso e ainda assim completamente adorável, na definição de um amigo no funeral, Vadinho sempre foi ¨ porreta ¨.

      	Dona Rozilda inconsolável com a morte de Vadinho, volta para a cidade e a situação fica pior, ela é o típico modelo de sogra, não gostava do genro, é bem chata, controladora.

      	Começa a plantar intriga sobre o falecido com algumas beatas, enquanto outras poucas defendem Vadinho, não pelas suas ações, mas pelo seu jeito adorável com o próximo.

      	A mãe de Flor queria ver suas filhas casadas com ricos, no entanto, Vadinho aparece, ele e Flor se encontraram numa festa chique, onde Vadinho tinha entrado como penetra, e iniciaram o namoro com a benção de Dona Rozilda, até o dia que ela descobriu quem era o genro.

      	Depois de um tempo, Flor saiu de casa, se casando de azul, porque não tinha coragem de usar o branco, Vadinho foi ausente, gastava o dinheiro dos outros com mulheres e jogo, certa ocasião Flor sendo estéril por pouco não adotou um garoto que ela pensava ser filho de Vadinho.

      	Algum tempo depois Flor estava mais alegre, porém mantém a pose de viúva. As beatas começaram a procurar um candidato a pretendente, e encontram Eduardo outro canalha, esse enganava viúvas para roubar seu dinheiro, mas ele foi descoberto.

      	Flor começa a se retrair, seu sono fica mais conturbado, sua vontade vai crescendo na medida em que os homens ficam fora de sua vida, até que o farmacêutico Teodoro Madureira boa pinta solteirão e respeitado, pede em casamento Flor e eles têm o mais inocente dos noivados, nunca estando juntos sozinhos.

      	Sendo aprovado por sua mãe, acontece o casamento de Flor, depois de sua lua de mel eles voltam para a vida normal, Flor entende que ele é diferente do falecido em tudo, inteligente, é fiel, e até mesmo romântico, Teodoro compõem uma música para sua amada e toca no aniversário de casamento deles, ele traz harmonia e paz a vida da esposa.

      	Após os convidados partirem, no dia do aniversário de casamento Flor vê Vadinho nú na cama, como no dia de seu falecimento, ele o tenta seduzir Flor, ela se nega naquele momento, era fiel ao seu esposo, Teodoro vai dormir e Vadinho aparece logo depois, antes de Flor procurá-lo.

      	Flor, Vadinho e Teodoro, passam a ter um matrimônio juntos ao mesmo tempo, Vadinho sempre pelado, invisível para todos, menos para Flor que se sente confusa, porém Vadinho diz que não tem porque são colegas casados perante ao juiz e ao padre.

      	Flor até faz uma encomenda de um trabalho para enviar Vadinho de novo ao além, durante esse tempo Vadinho vai manipulando os jogos de mesa, ajudando amigos. Dona Flor acaba aceitando Vadinho e passam a viver em harmonia os três.

      	Vadinho consegue o milagre de expulsar sua sogra quando ela aparece de mala para morar com eles, ele começa a desaparecer e Flor percebe que era por culpa do feitiço que foi encomendado.

      	Há um confronto entre diversos orixás contra Exu que defende Vadinho, porém quando Exu começa a perder, o amor e a inteligência de Vadinho vencem a batalha.

      	Com isso Dona Flor e seus dois maridos andam felizes nas ruas de Salvador."},

    new Livro { 
      LivroId = 2, 
      Nome = "Dom Casmurro", 
      Descricao = "é um romance de Machado de Assis que conta a história de Bento Santiago, um homem que, já velho, decide escrever um livro para narrar sua versão dos acontecimentos de sua juventude.", 
      Publicacao = "1899", 
      AutorId = 2, 
      Avaliacao = "4,8", 
      NumeroPaginas= 250, 
      Destaque = true, 
      Foto = "/img/livros/Dom Casmurro.png",
      Video = "rnpUJvVpngY", 
      Pdf = "/pdf/livros/Dom_Casmurro.pdf",
      Resumo = 
    @" No início da obra, o narrador Bentinho explica como escolheu o título para o seu livro. Assim, ele conta que conheceu um poeta em uma viagem de trem. O jovem recitou alguns versos, mas Bentinho, já velho, fechou os olhos algumas vezes. O poeta, então, achou que ele estava cochilando e, ofendido, lhe chamou de Dom Casmurro.

Em seguida, o narrador inicia a narrativa de suas memórias, que começa quando ele tem 15 anos. Nessa época, Capitu, uma jovem de 14 anos, é sua vizinha. Os adolescentes têm uma forte amizade, o que incomoda o agregado da família, o amante de superlativos José Dias.

Desconfiado da relação entre os jovens, ele sugere à D. Glória, mãe de Bentinho, que já é hora de enviar o rapaz para o seminário. Isso porque, quando o menino nasceu, sua mãe fez uma promessa de que ele seria padre. Dessa forma, se apresenta um obstáculo ao amor do jovem casal, o que, enganosamente, faz parecer que o livro é um romance romântico.

Porém, José Dias está longe de ser um vilão folhetinesco, ele apenas não gosta da família do vizinho Pádua, o pai de Capitu. Aliás, é do agregado a famosa percepção de que a menina tem olhos “de cigana oblíqua e dissimulada”. Assim, ao notar o envolvimento dos jovens, ele tenta evitar transtornos a D. Glória e a si mesmo.

Apesar de o casal tentar fugir da separação imposta pela promessa de D. Glória, Bentinho acaba indo para o seminário de São José, onde conhece Ezequiel de Sousa Escobar. Logo os dois rapazes iniciam uma forte amizade, e Bentinho fala de seu amor por Capitu. Escobar, então, tem a ideia que permitirá que Bentinho abandone o seminário.

Para ocupar o lugar de Bentinho, D. Glória deve escolher um rapaz órfão e fazer dele padre. Assim, ela não quebra a promessa feita e deixa o filho livre para, um dia, se casar. Desse modo, o protagonista sai do seminário, estuda Direito e, com 22 anos, é um bacharel. Em seguida, ele e Capitu se casam e podem ser felizes para sempre.

Poderiam, se Dom Casmurro fosse um livro romântico, mas como é uma obra realista, a vida do jovem casal logo se mostra distante do ideal de felicidade. O primeiro problema a perturbar a aparente alegria dos dois é a ausência de filhos. Bentinho quer ser pai; porém, Capitu não consegue engravidar.

Eles são grandes amigos do casal Escobar e Sancha, que têm uma filha, cujo nome também é Capitolina, em homenagem à esposa de Bentinho. Para diferenciar uma da outra, a menina é chamada, carinhosamente, de Capituzinha. Quando, finalmente, Capitu fica grávida e nasce o filho de Bentinho, eles retribuem a homenagem e batizam o menino com o nome de Ezequiel.

Agora parece que Bentinho e Capitu vão ser felizes para sempre, mas, então, Escobar morre afogado. Durante o velório do amigo, o sofrimento de Capitu faz com que Bentinho, pela primeira vez, desconfie que a esposa tinha um caso com seu amigo Escobar. A partir daí, a vida do casal se torna um inferno, pois a desconfiança de Bentinho acaba com qualquer chance de felicidade.

O ciumento Bentinho logo começa a perceber que seu filho Ezequiel se parece bastante com o falecido Escobar. Então, adquire a certeza de que o menino não é seu filho, mas do defunto. E seu desespero é tão grande que, em uma ocasião, ele está prestes a se matar com um café envenenado, quando o filho entra em seu gabinete:

No entanto, o narrador acaba desistindo do suicídio e do assassinato. Por fim, decide falar abertamente com a esposa. Diante das acusações, ela nega. Entretanto, não há mais como salvar aquele casamento. Assim, Bentinho resolve mandar Capitu e Ezequiel para a Europa, de forma a manter as aparências.
" },

    new Livro { 
      LivroId = 3, 
      Nome = "Capitães da Areia", 
      Descricao = "A história se passa em Salvador, Bahia, e retrata a vida de um grupo de meninos de rua que vivem em um trapiche abandonado, enfrentam a miséria, a violência e sobrevivem roubando e praticando pequenos crimes, mas também demonstram um forte senso de união e solidariedade.", 
      Publicacao = "1937", 
      AutorId = 1, 
      Avaliacao = "4,8", 
      NumeroPaginas= 300, 
      Destaque = true, 
      Foto = "/img/livros/Capitães De Areia .png", 
      Video = "M8h-WXKyLFc", 
      Pdf = "/pdf/livros/capitaes-da-areia.pdf",
      Resumo = 
    @"Os menores que envolvem a trama vivem na capital baiana, Salvador. Conhecidos como capitães, o grupo reúne cerca de quarenta menores (entre 9 e 16 anos) que vivem num trapiche (velho armazém) abandonado no cais do porto.

    Grande parte da história acontece no mercado, uma das importantes aglomerações comerciais. Ali, os meninos de rua pediam dinheiro para comer ou roubavam os que passavam.

    Além disso, eles costumavam caminhar pelo corredor da Vitória, área nobre da cidade de Salvador. Pedro Bala é o líder do grupo, um garoto loiro que possui uma cicatriz no rosto por lutar com o ex-líder: O caboclo Raimundo.

    Garoto valente e que conhece todas as partes da cidade, uma vez que anos esteve vagueando por Salvador. Tem um caso com Dora, uma das integrantes do grupo.

    A rotina do grupo era andar pela cidade pedindo dinheiro ou roubando algo para comerem. Visto que furtavam cotidianamente, eles aterrorizaram grande parte da população. Assim, eram procurados pela polícia, mas pela idade não podiam ser presos.

    Quando capturados, seriam enviados para o reformatório, um local fechado para menores infratores. No entanto, eles preferiam viver nas ruas e serem livres.

    Dora e Pedro foram pegos quando roubavam uma mansão e foram enviados para o reformatório. Dora fica doente e acaba morrendo.

    Num dos momentos da trama, a cidade de Salvador foi assolada pela varíola. Um dos membros do grupo não sobreviveu: Almiro. Por fim, alguns são capturados, outros mortos. Na última parte do livro, o autor apresenta o destino de cada um deles.
"  },

    new Livro { 
      LivroId = 4, 
      Nome = "Estrela da vida inteira", 
      Descricao = "é um livro de poemas que reúne todos os livros de poesia do autor, desde o seu primeiro, A Cinza das Horas, até os poemas que escreveu ao longo de sua vida.", 
      Publicacao = "1965", 
      AutorId = 3, 
      Avaliacao = "4,7", 
      NumeroPaginas= 600, 
      Destaque = true, 
      Foto = "/img/livros/Estrelas Da Vida Inteira.png", 
      Video = "mKR1Vkqxyjo", 
      Pdf = "/pdf/livros/estrela-da-vida-inteira.pdf",
      Resumo = 
    @"Cinza das horas
    A cinza das horas (1917) é uma obra marcada pelo rigor formal, ou seja, tem versos regulares, além de teor melancólico e temática do amor e da morte, como é possível verificar no trecho do poema “Boda espiritual”, escrito em versos alexandrinos (12 sílabas poéticas):
  
    Tu não estás comigo em momentos escassos:
    No pensamento meu, amor, tu vives nua
    — Toda nua, pudica e bela, nos meus braços.
    [...]
    Tua boca sem voz implora em um arquejo.
    Eu te estreito cada vez mais, e espio absorto
    A maravilha astral dessa nudez sem pejo...

    E te amo como se ama um passarinho morto.

    Carnaval
    Em Carnaval (1919), livro em que está publicado o famoso poema “Os sapos”, ainda são predominantes os versos regulares, que deixam transparecer um tom irônico e certo pessimismo, exemplificados também no poema “Bacanal”, uma paródia do poema “Mocidade e morte”, do escritor romântico Castro Alves (1847-1871), e escrito com versos octossílabos (oito sílabas poéticas):

    Quero beber! cantar asneiras
    No esto brutal das bebedeiras
    Que tudo emborca e faz em caco...
              	Evoé Baco!

    Lá se me parte a alma levada
    No torvelim da mascarada,
    A gargalhar em doudo assomo...
               	Evoé Momo!

    Lacem-na toda, multicores,
    As serpentinas dos amores,
    Cobras de lívidos venenos...
               	Evoé Vênus!

    […]

    O ritmo dissoluto
    O ritmo dissoluto (1924) mostra a transição do poeta para o modernismo, pois é possível perceber a presença de versos regulares, mas também de versos livres, como no poema “Meninos carvoeiros”, de temática social:

    Os meninos carvoeiros
    Passam a caminho da cidade.
    — Eh, carvoero!
    E vão tocando os animais com um relho enorme.

    [...]
    — Eh, carvoero!
    Só mesmo estas crianças raquíticas
    Vão bem com estes burrinhos descadeirados.
    A madrugada ingênua parece feita para eles...
    Pequenina, ingênua miséria!
    Adoráveis carvoeirinhos que trabalhais como se brincásseis!
    — Eh, carvoero!
    [...]

    Libertinagem
    Em Libertinagem (1930) está o poema “Poética”, que, de forma metalinguística, defende os ideais da primeira geração modernista, e também o famoso e irônico “Vou-me embora pra Pasárgada”. Nesse livro, predominam os versos livres, a temática nacionalista regionalista e a simplicidade, que caracteriza o poema “Namorados”:

    O rapaz chegou-se para junto da moça e disse:

    — Antônia, ainda não me acostumei com o seu corpo, com sua cara.
    A moça olhou de lado e esperou.
    — Você não sabe quando a gente é criança e de repente vê uma lagarta listada?
    A moça se lembrava:

    — A gente fica olhando...

    [...]
    O rapaz prosseguiu com muita doçura:
    — Antônia, você parece uma lagarta listada.

    [...]

    Estrela da manhã
    Estrela da Manhã (1936) traz temática social, elementos do cotidiano e um retorno à simetria de versos, como em “Flores murchas”, poema escrito com versos em redondilha menor (cinco sílabas poéticas):

    Pálidas crianças
    Mal desabrochadas
    Na manhã da vida!
    Tristes asiladas
    Que pendeis cansadas
    Como flores murchas!

    [...]

    Pálidas meninas
    Sem amor de mãe,
    Pálidas meninas
    Uniformizadas,
    Quem vos arrancara
    Dessas vestes tristes
    Onde a caridade
    Vos amortalhou!

    [...]

    Ao cair da tarde
    Vós me recordais
    — Oh meninas tristes! —
    Minhas esperanças!
    Minhas esperanças
    — Meninas cansadas,
    Pálidas crianças
    A quem ninguém diz:
    — Anjos, debandai!...

    Lira dos cinquent’anos
    Já em Lira dos cinquent’anos (1940), Manuel Bandeira dialoga com a tradição e com a memória, como se fizesse um resgate de sua história pessoal e da história de seu país, sem se esquecer das influências culturais externas. Nessa obra, poemas com versos simétricos convivem com versos livres, e o cotidiano está entremeado de lembranças, como ilustra o poema “Canção do vento e da minha vida”:

    O vento varria as folhas,
    O vento varria os frutos,
    O vento varria as flores...

    E a minha vida ficava
    Cada vez mais cheia
    De frutos, de flores, de folhas.

    [...]
    O vento varria os meses
    E varria os teus sorrisos...
    O vento varria tudo!

    E a minha vida ficava
    Cada vez mais cheia
    De tudo.


    O vento é metáfora para tempo.
    Belo belo
    Belo belo (1948) utiliza versos simétricos e versos livres, e trata de temas regionais, além de temáticas como o Natal e o amor, entre outras. Faz também homenagens, como no “Poema só para Jaime Ovalle”:

    Quando hoje acordei, ainda fazia escuro
    (Embora a manhã já estivesse avançada).
    Chovia.
    Chovia uma triste chuva de resignação
    Como contraste e consolo ao calor tempestuoso da noite.
    Então me levantei,
    Bebi o café que eu mesmo preparei,
    Depois me deitei novamente, acendi um cigarro e fiquei pensando...
    — Humildemente pensando na vida e nas mulheres que amei.

    Opus 10
    Em Opus 10 (1952), livro com poemas compostos em versos simétricos e livres, é possível verificar temas regionais, além de referências à morte, ao cotidiano e a elementos da tradição católica, como no poema “Oração para aviadores”:

    [...]

    Santa Clara, clareai.
    Afastai
    Todo risco.
    Por amor de S. Francisco,
    Vosso mestre, nosso pai,
    Santa Clara, todo risco
    Dissipai.

    Santa Clara, clareai.


    Estrela da tarde
    Em Estrela da tarde (1963), os versos regulares convivem com os versos livres. O livro tem um tom melancólico de despedida, entremeado por lembranças, como demonstra o poema “Canção para a minha morte”, escrito em versos hexassílabos (seis sílabas poéticas):

    Bem que filho do Norte,
    Não sou bravo nem forte.
    Mas, como a vida amei
    Quero te amar, ó morte,
    — Minha morte, pesar
    Que não te escolherei.
    [...]
    Sei que é grande maçada
    Morrer, mas morrerei
    — Quando fores servida —
    Sem maiores saudades
    Desta madrasta vida,
    Que, todavia, amei.


    Mafuá do malungo
    Mafuá do malungo (1948) também utiliza versos simétricos e livres. Possui poemas que homenageiam, por exemplo, o escritor francês Paul Verlaine (1844-1896) ou o brasileiro Vinicius de Moraes (1913-1980), além de ironizar personalidades políticas e fazer um “Autorretrato”, composto por versos octossílabos:

    Provinciano que nunca soube
    Escolher bem uma gravata;
    Pernambucano a quem repugna
    A faca do pernambucano;
    [...]
    Arquiteto falhado, músico
    Falhado (engoliu um dia

    Um piano, mas o teclado
    Ficou de fora); sem família,
    Religião ou filosofia;
    Mal tendo a inquietação de espírito
    Que vem do sobrenatural,
    E em matéria de profissão
    Um tísico profissional.

    Poemas traduzidos
    Por fim, em Poemas traduzidos (1945), Bandeira traduz poemas de escritores como Rainer Maria Rilker (1875-1926), Rubén Darío (1867-1916), Paul Verlaine, entre outros, como Paul Éluard (1895-1952), autor de “Em seu lugar”:

    Raio de sol entre dois límpidos diamantes
    E a lua a se fundir nos trigais obstinados

    Uma imóvel mulher tomou lugar na terra
    No calor ela se ilumina lentamente
    Profundamente como um broto e como um fruto

    Nele a noite floresce o dia amadurece." },

    new Livro { 
      LivroId = 5, 
      Nome = "Grande Sertão: Veredas", 
      Descricao = "conta a história de amor entre Riobaldo e Diadorim (ou Reinaldo). O ex-jagunço Riobaldo relata, para um interlocutor não nomeado na obra, fatos de sua juventude em meio a um bando de jagunços.", 
      Publicacao = "1956 ", 
      AutorId = 4, 
      Avaliacao = "4,9",
      NumeroPaginas= 600,  
      Destaque = true, 
      Foto = "/img/livros/Grande Sertão Veredas.png", 
      Video = "Rfgy_g79ww4",
      Pdf = "/pdf/livros/Grande Sertão_ Veredas.pdf", 
      Resumo = 
    @"O romance Grande sertão: veredas relata a história de Riobaldo. O narrador-personagem conta para um interlocutor não identificado as aventuras e desventuras vividas durante o tempo em que fez parte de um bando de jagunços. Assim, o agora fazendeiro Riobaldo, com sua linguagem peculiar, relembra o seu tempo de juventude.

Ele participou de uma guerra entre jagunços no sertão mineiro. No começo, o protagonista integrava o bando de Zé Bebelo. Depois, se juntou aos jagunços de Joca Ramiro, quando conheceu (ou reencontrou) Diadorim. Unidos contra Zé Bebelo, estavam os chefes Joca Ramiro, Ricardão e Hermógenes.

No entanto, quando Zé Bebelo foi capturado, recebeu o apoio de Joca Ramiro. Então, Joca Ramiro foi morto pela traição por Hermógenes e Ricardão. Diante desse fato, Riobaldo e Diadorim, que era filho do chefe assassinado, decidiram se juntar a Zé Bebelo para, assim, conseguirem a vingança contra “os judas”.

A vingança primeiro atingiria Ricardão, que seria morto antes de Hermógenes. Mas, até lá, os laços de amizade entre Riobaldo e Diadorim se fortaleceram. Desse modo, a travessia do sertão e os combates servem de pano de fundo para uma história de amor entre Riobaldo e Diadorim (também chamado de Reinaldo).

Porém, Riobaldo vive o conflito de estar apaixonado por um homem. Ele não sabe que, Diadorim, na verdade, é uma mulher que se faz passar por homem. A descoberta só acontecerá no fim do romance, de forma que, em grande parte da narrativa, Riobaldo experimenta a paixão por um homem.

É no que acredita também o interlocutor de Riobaldo, que só no final da história vai saber da verdade sobre Diadorim. E foi no que acreditaram os primeiros leitores da obra, pois não sabiam ainda do desfecho do romance. Assim, o livro está mais centrado na dificuldade de Riobaldo lidar com tal desejo do que na ação propriamente dita.

O desejo que Riobaldo sente por Diadorim permanece apenas no campo platônico, pois é impossível de se realizar em um meio violento e machista como o dos jagunços. Aliás, Diadorim só é respeitado porque todos acreditam que ela é um homem. Para fugir do desejo que sente, Riobaldo ocupa sua mente com Nhorinhá e Otacília.

Assim, quando Riobaldo se relaciona sexualmente com a prostituta Nhorinhá, Diadorim sente ciúmes, mas não pode ainda revelar seu segredo. Isso, no entanto, não elimina o forte desejo que Riobaldo sente pelo amigo. Nem Otacília, com quem o jagunço pretendia se casar, tem o poder de desfazer o amor entre os dois amigos.

Além das interdições morais em torno de sua sexualidade, o narrador precisa conviver com outro conflito, também de caráter universal: a luta entre o bem e o mal. Afinal, Riobaldo acreditava ter feito um pacto com o diabo para fechar o corpo e, assim, se proteger das balas de seus inimigos. O protagonista também revela que conheceu Diadorim quando ainda eram crianças.

Diadorim, desde criança, se vestia de homem e já se chamava Reinaldo. Aliás, só a Riobaldo era permitido chamar Reinaldo de Diadorim, na intimidade entre os dois. Mas essa história de amor impossível entre os dois amigos acaba em tragédia, pois Diadorim morre em seu embate final contra Hermógenes. Riobaldo então descobre que o nome verdadeiro de Diadorim é Maria Deodorina da Fé Bettancourt Marins.
" },

    new Livro { 
      LivroId = 6, 
      Nome = "Gabriela Cravo e Canela", 
      Descricao = "A obra narra o caso de amor entre o árabe Nacib e a sertaneja Gabriela, como pano de fundo o período áureo do cacau na região de Ilhéus, descrevendo as alterações profundas da vida social da Bahia da década de 1920.", 
      Publicacao = "1958", 
      AutorId = 1, 
      Avaliacao = "4,8",
      NumeroPaginas= 464,  
      Destaque = true, 
      Foto = "/img/livros/Gabriela,cravo e canela.png", 
      Video = "mKR1Vkqxyjo", 
      Pdf = "/pdf/livros/gabriela-cravo-e-canela.pdf",
      Resumo = 
    @"O romance Gabriela, Cravo e Canela, de Jorge Amado, é ambientado na cidade de Ilhéus, na Bahia, no início dos anos 1920. A cidade está em plena transformação, graças à riqueza que a cultura do cacau está trazendo para a região.

    A história começa quando Nacib, um árabe dono do bar Vesúvio, está desesperado à procura de uma nova cozinheira. Sua cozinheira anterior, Filomena, havia deixado a cidade para viver com o filho.

    Um dia, Nacib encontra Gabriela, uma sertaneja retirante que chega à cidade em busca de trabalho. Gabriela é uma mulher jovem, bonita e de temperamento forte. Ela logo conquista Nacib, que se apaixona por ela.

    Nacib e Gabriela começam a viver juntos. Gabriela se revela uma cozinheira talentosa, e seus pratos logo se tornam famosos em Ilhéus. Ela também se torna uma mulher independente e livre, que não se deixa submeter às normas sociais da época.

    A presença de Gabriela na cidade provoca uma série de mudanças. Ela representa a força e a sensualidade feminina, que começa a se impor em uma sociedade patriarcal.

    Nesse contexto, também ocorre uma disputa política entre dois grupos: os coronéis, que representam o poder tradicional, e os modernistas, que defendem o progresso e a modernização da cidade.

    Nacib, que é um homem progressista, se aproxima dos modernistas. Ele também se torna amigo de Mundinho Falcão, um exportador de cacau que representa o novo poder econômico da cidade.

    Mundinho Falcão se apaixona por Gabriela, e tenta conquistá-la. Gabriela, porém, permanece fiel a Nacib.

    A disputa entre Nacib e Mundinho Falcão por Gabriela reflete as transformações que estão ocorrendo na sociedade de Ilhéus. A cidade está se modernizando, e os velhos valores estão sendo questionados.

    No final do romance, Nacib e Gabriela se casam. Eles representam a vitória do amor e da liberdade sobre as forças do tradicionalismo.
    " },

    new Livro { 
      LivroId = 7, 
      Nome = "Iracema", 
      Descricao = "O romance conta o amor de um branco, Martim Soares Moreno, pela índia Iracema, a virgem dos lábios de mel. A relação do casal serviria de alegoria para a formação da nação brasileira. A índia Iracema representaria a natureza virgem e a inocência enquanto o colonizador Martim representa a cultura (europeia).",
      Publicacao = "1865", 
      AutorId = 5, 
      Avaliacao = "4,6",
      NumeroPaginas= 202,  
      Destaque = true, 
      Foto = "/img/livros/iracema.png", 
      Video = "V1s1a77PnOg", 
      Pdf = "/pdf/livros/Iracema.pdf",
      Resumo = 
    @"Iracema é uma obra que traz como protagonista uma mulher indígena com características físicas e psicológicas muito idealizadas.
    A história tem início quando Martim, português responsável por defender o território brasileiro de outros invasores europeus, perde-se na mata, em localidade que hoje corresponde ao litoral do Ceará. Iracema, índia tabajara que então repousava entre as árvores, assusta-se com a chegada do estranho, e dispara uma flecha contra Martim. Ele não reage à agressão por ter sido alvejado por uma mulher, e Iracema entende que feriu um inocente.

    Em pacto de paz, Iracema leva o estrangeiro ferido para sua aldeia e para ter com seu pai, Araquém, o pajé da tribo. Martim é recebido com grande hospitalidade, mas sua chegada não agrada a todos: Irapuã, guerreiro tabajara apaixonado por Iracema, é o primeiro a desagradar-se.

    Durante sua estadia na aldeia, Iracema e Martim aproximam-se e floresce, entre os dois, forte atração. Contudo, Iracema tem um papel importante na tribo: é uma virgem consagrada a Tupã, guardadora do segredo da jurema, um licor sagrado, que levava ao êxtase os índios tabajaras.

    Entre festejos e batalhas com outras tribos — entre elas, a dos pitiguaras, aliados de Martim — Iracema e o estrangeiro português envolvem-se amorosamente, e a índia quebra o voto de castidade, o que significa uma condenação à morte. Martim, por sua vez, também é perseguido: Irapuã e seus homens querem beber seu sangue. A aliança com os pitiguaras torna-o um inimigo ainda mais indesejado.

    Apaixonados, Iracema e Martim precisam fugir da aldeia tabajara antes que a tribo perceba que a virgem rompeu o voto de castidade. Juntam-se a Poti, índio pitiguara, a quem Martim tratava como irmão. Quando os tabajaras percebem a fuga, partem em perseguição aos amantes liderada por Irapuã e Caiubi, o irmão de Iracema.

    Acabam por encontrar a tribo pitiguara, e uma sangrenta batalha é travada. Caiubi e Irapuã agridem violentamente Martin, e Iracema avança com ferocidade contra os dois, ferindo-os gravemente. Prevendo a derrota, a tribo tabajara bate em retirada.

    O casal, então, refugia-se em uma praia deserta, onde Martim constrói uma cabana. Iracema passa muito tempo sozinha enquanto o amado fiscaliza as costas, em expedições a mando do governo português. Martim é constantemente tomado pela melancolia e nostalgia de sua terra natal, o que entristece Iracema, que passa a pensar que sua morte seria, para ele, uma libertação.

    Não muito tempo depois, Iracema descobre-se grávida, mas Martim precisa partir para defender, junto a Poti, a tribo pitiguara, que está sob ataque. Iracema acaba tendo o filho sozinha, e batiza a criança de Moacir, o nascido de seu sofrimento. Ferida pelo parto e pela tristeza profunda, o leite de Iracema seca; Martim chega a tempo de Iracema entregar-lhe a criança e falecer logo em seguida."
    },
    
    new Livro { 
      LivroId = 8, 
      Nome = "Memórias Póstumas de Brás Cubas", 
      Descricao = "Brás Cubas decide narrar sua própria vida após a morte. A narrativa começa com sua agonia e enterro, e retrocede para sua infância, juventude e vida adulta. O livro é uma crítica à sociedade da época, com seus costumes, valores e hipocrisias.", 
      Publicacao = "1880", 
      AutorId = 2, 
      Avaliacao = "4,8",
      NumeroPaginas= 328, 
      Destaque = true,
      Foto = "/img/livros/Memórias Póstumas de Brás Cubas.png", 
      Video = "GyXglxNR5Ss", 
      Pdf = "/pdf/livros/memoriasBras.pdf",
      Resumo = 
    @"A obra tem início com a declaração da morte de Brás Cubas, cujo narrador e protagonista relata suas memórias após ter sido vítima de pneumonia.

    Pertencente a uma família abastada do século XIX, Brás Cubas narra primeiramente sua morte e enterro onde apareceram onze amigos.

    Por conseguinte, ele relata diversos momentos de sua vida, desde eventos da sua infância, adolescência e fase adulta.

    Ainda no início da obra ele revela suas expectativas com o “emplastro”, um medicamento que contém grande potencial de cura.

    Durante sua infância, Brás Cubas comenta sua relação com seu escravo, o negrinho Prudêncio. Como um menino aristocrata, pertencente à classe alta, Brás Cubas esboça a relação que tinha com o garoto desde suas brincadeiras e caprichos.

    Nessa relação, podemos notar a superioridade de Brás que montava no negrinho. Além disso, ele escreve sobre um amigo da escola Quincas Borba que, por fim, torna-se um filósofo e desenvolve a teoria do humanitismo.

    Quando jovem, conhece Marcela, uma prostituta de luxo por quem se apaixona. Essa relação esteve baseada nos interesses, ainda que Cubas aponta que Marcela o amou “durante quinze meses e onze contos de réis”.

    Preocupado com o envolvimento que Brás tinha com Marcela, seu pai resolve que seu filho deve estudar fora do país por um tempo.

    Sendo assim, ele foi estudar em Coimbra, Portugal, onde se forma em Direito. De volta ao Brasil, apaixona-se por Virgília, no entanto, ela acaba por se casar com Lobo Neves. Isso porque ela pretendia ter mais status e resolve ficar com um político de maior influência.

    Ainda que desolado, o casal se encontra às escondidas numa casa alugada para esse propósito. Nesse momento podemos notar a presença de Dona Plácida, empregada de Virgília que encobre todos os encontros da adúltera.

    Por fim, Brás Cubas entra para a política e mesmo desenvolvendo um trabalho medíocre, essa posição lhe oferece certo status, num mundo onde a aparência era o mais louvável.

    " },
    new Livro { 
      LivroId = 9, 
      Nome = "Sonetos", 
      Descricao = "Os sonetos de Camões abordam uma variedade de temas, com destaque para o amor, a paixão, a saudade, a melancolia, a fé e a reflexão sobre a vida e a morte. Sua poesia é um retrato da alma humana, com suas alegrias, tristezas, esperanças e desilusões.", 
      Publicacao = "1595", 
      AutorId = 6, 
      Avaliacao= "4,7", 
      NumeroPaginas= 144, 
      Destaque = true, 
      Foto = "/img/livros/Sonetos De Camões.png", 
      Video = "Yac_R3PlFeE", 
      Pdf = "/pdf/livros/SONETOS.pdf",
      Resumo = 
    @"'CXLV - Quando os raios do sol, que ao nascer' - Este soneto expressa a saudade que o poeta sente da sua terra natal, Portugal, enquanto está exilado em África. Ele descreve como a beleza da natureza não consegue amenizar a sua tristeza e saudade.

'CLXIII - Quem quiser que o mundo conheça bem' - Este soneto é um hino à beleza da poesia, com o poeta afirmando que é através dela que os homens podem compreender e apreciar a verdadeira beleza do mundo.

'CLXXX - As armas e os barões assinalados' - Este soneto celebra a vitória de Portugal sobre os Mouros em Alcácer-Quibir, e celebra a bravura e coragem dos líderes portugueses que lideraram a batalha.

'LXXI - Tudo passa, e tudo se renova' - Este soneto fala sobre a fugacidade da vida e como tudo passa e se renova, e como a beleza da natureza é uma lembrança constante da passagem do tempo.

'LXVI - Que pena me dá, ó bem posta alma' - Este soneto fala sobre o amor e a dor de amar alguém, com o poeta expressando sua tristeza pelo amor não correspondido e sua esperança de um dia encontrar alguém que o ame de volta.

Outros poemas da coletânea abordam temas como a natureza, a religião e a história. Alguns dos poemas mais importantes incluem Lusíadas, que é considerado uma das mais importantes obras da literatura portuguesa, e As Rimas, que são poemas satíricos que criticam a sociedade da época

Em resumo, Sonetos é uma coletânea de poemas escrita pelo poeta português Luís de Camões, publicada em 1595. A coletânea contém cerca de 200 sonetos que abrangem uma variedade de temas, incluindo amor, natureza, religião, história e política. Os poemas de amor são talvez os mais conhecidos e celebrados, com Camões usando metáforas e imagens poderosas para descrever seus sentimentos. Além disso, os poemas também abordam outros temas importantes como a natureza, a religião e a história, incluindo Lusíadas que é considerado uma das principais obras da literatura portuguesa.
" },
    new Livro { 
      LivroId = 10, 
      Nome = "Quarto de Despejo", 
      Descricao = "O livro é um diário em que Carolina Maria de Jesus narra seu cotidiano, descrevendo as dificuldades que enfrenta como mãe solteira de três filhos, trabalhando como catadora de papel e enfrentando a falta de recursos para suprir as necessidades básicas da família.", 
      Publicacao = "1960", 
      AutorId = 7, 
      Avaliacao = "4,9", 
      NumeroPaginas= 176, 
      Destaque = true, 
      Foto = "/img/livros/Quarto De Despejo.png", 
      Video = "Cv-7AH2wTQQ", 
      Pdf = "/pdf/livros/Quarto de Despejo.pdf",
      Resumo =
    @"Em seu texto, vemos como a autora procura sobreviver como catadora de lixo na metrópole de São Paulo, tentando encontrar naquilo que alguns consideram como sobra o que a mantenha viva.

Os relatos foram escritos entre 15 de julho de 1955 e 1 de janeiro de 1960. As entradas no diário são marcadas com dia, mês e ano e narram aspectos da rotina de Carolina.

Muitas passagens sublinham, por exemplo, a dificuldade de ser mãe solteira nesse contexto de extrema pobreza. Lemos num trecho presente no dia 15 de julho de 1955:

“Aniversário de minha filha Vera Eunice. Eu pretendia comprar um par de sapatos para ela. Mas o custo dos generos alimenticios nos impede a realização dos nossos desejos. Atualmente somos escravos do custo de vida. Eu achei um par de sapatos no lixo, lavei e remendei para ela calçar.”

Carolina Maria é mãe de três filhos e dá conta de tudo sozinha.

Para conseguir alimentar e criar a família ela se desdobra trabalhando como catadora de papelão, metal, e como lavadeira. Apesar de todo o esforço, muitas vezes sente que não dá conta.

Nesse contexto de frustração e extrema pobreza, é importante se sublinhar o papel da religiosidade. Diversas vezes, ao longo do livro, a fé aparece como um fator motivador e impulsionador da protagonista.

Há passagens que deixam bem clara a importância da crença para essa mulher lutadora:

Eu estava indisposta, resolvi benzer-me. Abri a boca duas vezes, certifiquei-me que estava com mau olhado.

Carolina encontra na fé força, mas também muitas vezes explicação para situações cotidianas. O caso acima é bastante ilustrativo de como uma dor de cabeça é justificada por algo da ordem do espiritual.

Quarto de Despejo explora os meandros da vida dessa trabalhadora mulher e transmite a dura realidade de Carolina, o constante esforço contínuo para manter a família de pé sem passar maiores necessidades:

Saí indisposta, com vontade de deitar. Mas, o pobre não repousa. Não tem o previlegio de gosar descanço. Eu estava nervosa interiormente, ia maldizendo a sorte. Catei dois sacos de papel. Depois retornei, catei uns ferros, uma latas, e lenha

Por ser a única a prover o sustento da família, Carolina trabalha dia e noite para dar conta da criação dos filhos.

Os seus meninos, como ela costuma chamar, passam muito tempo sozinhos em casa e vira e mexe são alvo de críticas da vizinhança que dizem que as crianças são mal inducadas.

Embora nunca se diga com todas as letras, a autora atribui a reação das vizinhas com os seus filhos pelo fato de ela não ser casada (Elas alude que eu não sou casada. Mas eu sou mais feliz do que elas. Elas tem marido.)

Ao longo da escrita, Carolina sublinha que sabe a cor da fome - e ela seria amarela. A catadora teria visto o amarelo algumas vezes ao longo dos anos e era daquela sensação que mais tentava fugir:

Eu que antes de comer via o céu, as árvores, as aves, tudo amarelo, depois que comi, tudo normalizou-se aos meus olhos.

Além de trabalhar para conseguir comprar comida, a moradora da favela do Canindé também recebia doações e buscava restos de alimento nas feiras e até no lixo quando era preciso. Em uma das suas entradas no diário, comenta:

A tontura do álcool nos impede de cantar. Mas a da fome nos faz tremer. Percebi que é horrível ter só ar dentro do estômago.

Pior do que a fome dela, a fome que mais doía era aquela que assistia nos filhos. E é assim, tentando escapar da fome, da violência, da miséria e da pobreza, que se constrói o relato de Carolina.

Acima de tudo, Quarto de Despejo é uma história de sofrimento e de resiliência, de como uma mulher lida com todas as dificuldades impostas pela vida e ainda consegue transformar em discurso a situação limite vivida.
"  },
    new Livro { 
      LivroId = 11, 
      Nome = "Poesia Completa", 
      Descricao = "O momento em que o país vivia a Era Vargas é a mais cobrada no ENEM. Isso acontece porque ela reflete o engajamento social e político do poeta, características que costumam ser muito bem aproveitadas", 
      Publicacao = "", 
      AutorId = 8, 
      Avaliacao = "3,8", 
      NumeroPaginas= 1728, 
      Destaque = true, 
      Foto = "/img/livros/Poesia Completa Carlos Drummond De Andrade.png", 
      Video = "CWagtQP7hqw", 
      Pdf = "/pdf/livros/poesia completa.pdf",
      Resumo =
    @"No Meio do Caminho
    Um dos poemas mais conhecidos de Drummond, famoso por sua repetição e reflexão sobre a presença de obstáculos na vida.
    Candidato sobre como lidar com as dificuldades e imprevistos.

    José:
    Poema que retrata a figura de um homem comum, com suas angústias e incertezas.
    Aborda a condição humana e a busca por identidade e sentido na vida.

    Epitáfio:
    Poema curto e reflexivo sobre a brevidade da vida e a importância de viver o presente.
    Enfatiza a necessidade de aproveitar cada momento e a finitude da existência.

    Mãos dadas:
    Poema que exalta a importância da união e da solidariedade entre as pessoas.
    Transmite uma mensagem de esperança e fé na capacidade humana de superar desafios em conjunto.

    A Rosa do Povo:
    Poema que retrata um período histórico conturbado, marcado pela Segunda Guerra Mundial e seus impactos.
    Aborda temas como a guerra, a violência e a necessidade de reconstrução e esperança.
    Além desses, outros poemas de Drummond podem aparecer no ENEM, como:

    Sentimento do Mundo: 
    Explora a relação do indivíduo com o mundo ao seu redor, com suas angústias e desafios.

    Quadrilha: 
    Poema divertido e popular sobre as relações amorosas e seus imprevistos.

    Poema de Sete Faces: 
    Aborda a complexidade da identidade humana e a dificuldade de se definir.
    O POVO BRASILEIRO                                                                                                            .

    O Povo Brasileiro é um livro de antropologia de Darcy Ribeiro, publicado em 1995. A obra é um estudo sobre a formação do povo brasileiro, abordando os aspectos históricos, sociais e culturais que influenciaram na construção da identidade nacional.

    Matrizes culturais do Brasil:
    Esta parte aborda as três matrizes culturais que formaram o povo brasileiro: a indígena, a africana e a europeia. Darcy Ribeiro descreve como essas três culturas se encontraram e se misturaram, dando origem a uma nova cultura, com características próprias.

    A formação étnica e cultural do Brasil:
    Esta parte trata do processo de miscigenação que ocorreu no Brasil, desde a chegada dos portugueses até os dias atuais. Darcy Ribeiro mostra como a miscigenação foi um fator importante na formação da identidade brasileira, mas também como gerou desigualdades sociais e raciais.
    O futuro do Brasil:
    Nesta parte, Darcy Ribeiro faz uma reflexão sobre o futuro do Brasil, propondo um projeto de nação baseado na igualdade social e na valorização da diversidade cultural.
    Principais ideias do livro:
    O povo brasileiro é resultado da mistura de três matrizes culturais: a indígena, a africana e a europeia.
    A miscigenação foi um fator importante na formação da identidade brasileira.
    A formação do povo brasileiro foi marcada por desigualdades sociais e raciais.
    O futuro do Brasil depende da construção de uma sociedade mais justa e igualitária.
 "},

    new Livro { 
      LivroId = 12, 
      Nome = "O povo brasileiro", 
      Descricao = "A obra busca responder à pergunta: quem são os brasileiros? mergulhando na história do Brasil, analisando as matrizes culturais, os mecanismos de formação étnica e cultural, os conflitos e as contradições.", 
      Publicacao = "1995", 
      AutorId = 9,
      Avaliacao = "4,9", 
      NumeroPaginas= 368, 
      Destaque = true, 
      Foto = "/img/livros/O Povo Brasileiro.png", 
      Video = "geSPmerwDmI", 
      Pdf = "/pdf/livros/O Povo Brasileiro.pdf",
      Resumo = 
    @"O Povo Brasileiro é um livro de antropologia de Darcy Ribeiro, publicado em 1995. A obra é um estudo sobre a formação do povo brasileiro, abordando os aspectos históricos, sociais e culturais que influenciaram na construção da identidade nacional.

    Matrizes culturais do Brasil:
    Esta parte aborda as três matrizes culturais que formaram o povo brasileiro: a indígena, a africana e a europeia. Darcy Ribeiro descreve como essas três culturas se encontraram e se misturaram, dando origem a uma nova cultura, com características próprias.

    A formação étnica e cultural do Brasil:
    Esta parte trata do processo de miscigenação que ocorreu no Brasil, desde a chegada dos portugueses até os dias atuais. Darcy Ribeiro mostra como a miscigenação foi um fator importante na formação da identidade brasileira, mas também como gerou desigualdades sociais e raciais.
    O futuro do Brasil:
    Nesta parte, Darcy Ribeiro faz uma reflexão sobre o futuro do Brasil, propondo um projeto de nação baseado na igualdade social e na valorização da diversidade cultural.
    Principais ideias do livro:
    O povo brasileiro é resultado da mistura de três matrizes culturais: a indígena, a africana e a europeia.
    A miscigenação foi um fator importante na formação da identidade brasileira.
    A formação do povo brasileiro foi marcada por desigualdades sociais e raciais.
    O futuro do Brasil depende da construção de uma sociedade mais justa e igualitária." },

    new Livro { 
      LivroId = 13, 
      Nome = "Vidas Secas", 
      Descricao = "A história acompanha a saga de Fabiano, Sinhá Vitória e seus dois filhos, além da cachorra Baleia, em busca de melhores condições de vida. A família enfrenta a seca, a fome, a violência e a injustiça social, sendo constantemente humilhada e explorada pelos proprietários de terra.", 
      Publicacao = "1938", 
      AutorId = 10, 
      Avaliacao = "4,8", 
      NumeroPaginas= 176, 
      Destaque = true,
      Foto = "/img/livros/Vidas Secas.png", 
      Video = "465n-yZqt6I", 
      Pdf = "/pdf/livros/vidas-secas.pdf",
      Resumo =
    @"Vidas Secas é um profundo retrato da sociedade brasileira, sobretudo de seus problemas sociais.
    Dessa forma, Graciliano traça uma crítica social retratando as dificuldades encontradas por uma família pobre de retirantes. Eles têm de conviver constantemente com a miséria e a seca que assola o sertão nordestino.
    Fabiano e Sinhá Vitória é um casal simples que possuem dois filhos: o mais novo e o mais velho. Dos filhos, nenhum nome é mencionado durante toda a estória. Mesmo convivendo constantemente com a miséria, eles são crianças que possuem sonhos. O mais velho é muito curioso, e o mais novo anseia por fazer algo importante, para que todos fiquem orgulhosos dele.
    A Baleia é a cadela que curiosamente tem um nome, e faz referência a um animal aquático, ou seja, uma baleia, em contraste com a seca. Ela é muito adorada pelos meninos e no decorrer da história adoece e por fim, morre. Interessante notar que a baleia é considerada um ser humano.
    Vale lembrar que a obra muitas vezes não possui diálogos. Fabiano, deveras ignorante, tem dificuldade de se expressar e prefere ficar quieto. Sua mulher, Sinhá Vitória, é uma lutadora que busca melhorar a situação, sendo menos ignorante que seu marido, que a admira muito.
    Quando a família encontra um lugar para descansar do sol escaldante, se deparam com o dono da terra, que será o patrão de Fabiano.
    Ele permanece no local com sua família, trabalhado como vaqueiro na fazenda. Fabiano é preso injustamente pelo soldado amarelo, momento em que reflete sobre sua vida e sua condição.
    O romance é repleto de pequenas felicidades na família de retirantes. No entanto, os problemas sociais e animalização das personagens permeiam toda obra.
    Além disso, o sonho do sofrimento acabar, permanece em todos, na esperança de encontrar melhores oportunidades.
    Note que o último capítulo “Fuga” aponta que a seca vem assolar novamente a região, com o verão que se aproxima. Assim, se inicia uma nova fuga sendo a mesma do início: a fuga da seca."  },
    new Livro { 
      LivroId = 14, 
      Nome = "O Cortiço", 
      Descricao = "O Cortiço é um romance naturalista que retrata a vida de pessoas pobres que viviam em cortiços no Rio de Janeiro no final do século XIX. O livro denuncia a exploração e as péssimas condições de vida dos moradores.",
      Publicacao = "1890", 
      AutorId = 11, 
      Avaliacao= "4,7",
      NumeroPaginas= 223,  
      Destaque = true, 
      Foto = "/img/livros/o cortiço.png", 
      Video = "v6rjjpbeNBk", 
      Pdf = "/pdf/livros/o-cortico.pdf",
      Resumo =
    @"Dono do Cortiço, João Romão é um português ambicioso que explora seus empregados. Além de proprietário da habitação coletiva, ele é dono de uma pedreira e uma taverna.
    Ainda que não seja o personagem principal da trama, muitas passagens do romance revelam sua ascensão social.
    Ao mesmo tempo, é demostrada a degradação social dos menos favorecidos que vivem no cortiço.
    Ao lado do cortiço aparece o sobrado aristocrático, em que vive o burguês Miranda, comerciante de tecidos, casado com Estela. Eles vivem um casamento infeliz, e Estela o trai sempre.
    Miranda demostra-se incomodado com o crescimento do cortiço e por esse motivo, entra em rivalidade com João Romão.
    No entanto, com o intuito de ter um status social parecido com o de seu rival, João Romão casa-se com a filha de Miranda e Estela: Zulmira. A partir daí, ele consegue alcançar melhores condições sociais.
    João Romão, tem uma escrava chamada Bertoleza. Ele forjou uma carta de alforria para ela, que por fim, torna-se sua amante e passa a trabalhar para ele.
    Entretanto, após seu casamento, Romão entrega sua escrava fugitiva. Desiludida com essa ação, Bertoleza se mata.
    No cortiço, a vida é simples e dura. Grande parte do enredo retrata a vida de seus moradores e de seus envolvimentos. Rita baiana é uma mulata de grande carisma e que conhece todos os moradores da habitação coletiva.
    De natureza sedutora, teve um envolvimento com Firmo e mais tarde, com o português Jerônimo. Esse envolvimento, levou ao assassinato de Firmo.
    Jerônimo é um homem honesto que trabalha na pedreira de João Romão. É casado com a portuguesa Piedade e juntos tem uma filha.
    Após se envolver com a sedutora Rita Baiana, sua esposa descobre a relação e começa a beber.
    Enciumado pelo envolvimento anterior que Rita teve com Firmo, Jerônimo resolve assassinar seu rival. Por fim, Jerônimo abandona sua família para ficar com Rita.
    O incêndio no cortiço foi um dos fatores principais para que muitos moradores se transferissem para outro cortiço, o “cabeça-de-gato”. Com isso, o local foi reformado e a avenida recebeu o nome de Avenida São Romão.
        "  },


    // UNICAMP
    new Livro { 
      LivroId = 15, 
      Nome = "Prosas seguidas de odes mínimas", 
      Descricao = "é um livro composto por: Prosas: Vinte textos em prosa poética que abordam temas diversos marcados pela concisão, pela ironia e pelo humor, e Odes Mínimas: Treze poemas curtos, concisos e minimalistas, que exploram os temas das prosas,com uma linguagem depurada e essencial. Os poemas são marcados pela reflexão, pela ironia e pela brevidade.", 
      Publicacao = "1992", 
      AutorId = 12,
      Avaliacao = "4,8", 
      NumeroPaginas= 88, 
      Destaque = true, 
      Foto = "/img/livros/Prosas seguidas de odes mínimas.png", 
      Video = "3iX2kdVHvUI", 
      Pdf = "/pdf/livros/Prosas-seguidas-de-Odes.pdf",
      Resumo = 
      @"Em Prosas seguidas de Odes mínimas, José Paulo Paes entrega uma obra que se equilibra entre a prosa e a poesia, explorando a concisão como meio de provocar reflexões profundas. As prosas curtas são carregadas de observações sutis sobre a vida cotidiana, os relacionamentos e a natureza humana, enquanto as odes mínimas são pequenos poemas que se concentram na essência das coisas, evitando qualquer forma de excesso ou ostentação linguística.
      O autor brinca com a linguagem de maneira direta e objetiva, transformando o trivial em matéria de reflexão filosófica. A economia de palavras e a precisão das imagens criam uma obra em que cada frase ou verso é significativo, tornando a leitura uma experiência densa, mesmo em sua brevidade.
      A escolha do autor por uma estética minimalista não diminui o impacto emocional das suas palavras, mas, ao contrário, permite que o leitor se concentre nos significados sutis escondidos nas entrelinhas. A obra é uma meditação sobre a simplicidade e a beleza que se pode encontrar em todos os aspectos da vida, por mais comuns que pareçam à primeira vista.
      " },  
    new Livro { 
      LivroId = 16, 
    Nome = "Olhos d’água", 
    Descricao = "Olhos d'água é um livro de contos da escritora Conceição Evaristo que aborda a vida de pessoas negras e afro-brasileiras.A metáfora dos olhos d'água simboliza a união estabelecida entre passado, presente e futuro", 
    Publicacao = "2014", 
    AutorId = 13, 
    Avaliacao = "4,8", 
    NumeroPaginas= 116, 
    Destaque = true, 
    Foto = "/img/livros/Olhos d'água.png", 
    Video= "aj9XnRAyG6Y", 
    Pdf = "/pdf/livros/Olhos dagua.pdf",
    Resumo = 
    @"Olhos d’água, Duzu-Querença, Luamanda, Lumbiá, Di Lixão, são alguns dos títulos dos 15 contos que compõem o livro Olhos d'água, de Conceição Evaristo. Neles e nos tantos outros, a autora aborda questões que perpassam a vivência de personagens negros marginalizados e violentados pela sociedade.  

    -Havia anos que eu estava fora de minha cidade natal. Saíra de minha casa em busca de melhor condição de vida para mim e para minha família: ela e minhas irmãs tinham ficado para trás. Mas eu nunca esquecera a minha mãe.- (trecho de Olhos d’água).

    Em sua grande maioria as personagens dos contos são mulheres; outra característica encontrada com regularidade é muitas delas serem mães. Entretanto, na obra aparecem protagonistas homens, filhas, avós, que retratam em suas vidas temas sociais, sexuais, emocionais, todos eles atravessados por suas narrativas complexas e bastante densas, marcadas por uma condição racial.

    -Davenga mordeu o lábio, contendo o riso. Olhou o político bem no fundo dos olhos, mandou então que ele tirasse a roupa e foi recolhendo tudo.

    — Não, doutor, a cueca não! Sua cueca não! Sei lá se o senhor tem alguma doença ou se tá com o cu sujo!-. 

    (trecho do conto Ana Davenga). 

    Histórias de realidades brasileiras, em grande parte de mulheres negras, em quase todos os títulos temos o nome das personagens principais dos contos. Apesar de não serem histórias superficiais e virem bastante carregadas de violências e absurdos vividos cotidianamente por esses grupos, Evaristo também traz em alguns momentos humor, e, para além disso, muito afeto. 

    -Um dia, aos treze anos, a cama do gozo foi arrumada em pleno terreno baldio. A lua espiava no céu denunciando com a sua luz um corpo confuso de uma quase menina, de uma quase mulher. Corpo-coração espetado por um falo, também estreante. Um menino que se fazia homem ali, a inaugurar em Luamanda o primeiro jorro, fora de suas próprias masturbantes mãos. E ambos se lambuzavam festivamente um no corpo do outro. Luamanda chorando de prazer. O gozo-dor entre as suas pernas lacrimevaginava no falo intumescido do macho menino, em sua vez primeira no corpo de uma mulher. O amor é terremoto?-  (trecho do conto Luamanda).

    A riqueza da obra está justamente na maneira em que a autora se aprofunda na pluralidade de temas e sentimentos que constituem a condição humana. A sexualidade também é abordada e não só de maneira heteronormativa, um ponto bastante sensível e que muitas vezes é apagado em meio às outras problemáticas relacionadas a sujeitos marginalizados.

    A prosa de Conceição Evaristo é guiada por uma linguagem poética, marca da autora, assim como os neologismos, que fazem parte de seu estilo. A esse modo de narrar dos personagens e de contar suas histórias e visões de mundo, a autora dá o nome de “escrevivências”, que marca a realidade, a vivência daquelas pessoas contada a partir da escrita.
    A esse modo de narrar dos personagens e de contar suas histórias e visões de mundo, a autora dá o nome de escrevivências, que marca a realidade, a vivência daquelas pessoas contada a partir da escrita."},

    new Livro { 
      LivroId = 17, 
      Nome = "A vida não é útil", 
      Descricao = "é um livro que questiona o sistema capitalista, o consumismo e a destruição ambiental. Composto por cinco textos: Não se come dinheiro, Sonhos para adiar o fim do mundo, A máquina de fazer coisas, O amanhã não está à venda, A vida não é útil.", 
      Publicacao = "2020", 
      AutorId = 14, 
      Avaliacao= "4,8", 
      NumeroPaginas= 128, 
      Destaque = true, 
      Foto = "/img/livros/A vida não é útil.png", 
      Video= "y0m1i-dHtT8", 
      Pdf = "/pdf/livros/A vida não é útil.pdf",
      Resumo = 
      @"“Essa dor talvez ajude as pessoas a responder se somos de fato uma humanidade. Nós nos acostumamos com essa ideia, que foi naturalizada, mas ninguém mais presta atenção no verdadeiro sentido do que é ser humano. É como se tivéssemos várias crianças brincando e, por imaginar essa fantasia da infância, continuassem a brincar por tempo indeterminado. Só que viramos adultos, estamos devastando o planeta, cavando um fosso gigantesco de desigualdades entre povos e sociedades. De modo que há uma sub-humanidade que vive numa grande miséria, sem chance de sair dela – e isso também foi naturalizado.
      Uma poderosa crítica a nossa concepção de civilização e vida. É assim que descrevemos a obra -A Vida não é Útil-, de Ailton Krenak. Considerado um expoente da literatura indígena, Ailton é membro da comunidade Krenak, localizada no Vale do Rio Doce. A comunidade, que hoje sofre com a contaminação dos rios e os efeitos da atividade predatória brasileira, possui uma cosmovisão completamente diferente da nossa.
      O autor escreveu o livro durante a pandemia e exprime um sentimento comum de uma ala progressista da sociedade, em que a pandemia seria uma boa oportunidade para revermos nossos padrões de vida e repensarmos o nosso modo de viver, uma vez que, para Ailton, não sabemos nem como viver, tema de seu último ensaio do livro.
      A obra é um compilado de ensaios escritos durante o período da pandemia, que colocam em xeque concepções estabelecidas em nossa visão de mundo. No primeiro ensaio, -Não se come dinheiro-, Krenak questiona a nossa concepção de humanidade, dentro da qual criamos uma sub-humanidade, que inclui não apenas populações historicamente marginalizadas, mas também os animais e a natureza. Aliás, a natureza é elemento central em seu livro, ao mostrar que ela é um SER em si, não apenas um acessório para o progresso.
      No segundo ensaio, -Sonhos para adiar o fim do mundo-, o autor se debruça a entender mais sobre os sonhos, que tem tanto a dimensão de linguagem como de afeto. Sonhamos não apenas individualmente, mas coletivamente. Para Krenak, a pandemia seria uma oportunidade de transformação. Entretanto, isso teria que se dar diante de outra matriz que não o capitalismo.
      Já no terceiro ensaio, intitulado -A máquina de fazer coisas-, Krenak vai falar do terrorismo da modernidade e do consumismo, como se a Terra fosse um acessório substituível. -Convoquemos a experiência de estarmos harmoniosamente habitando o cosmos: é possível experimentar isso na nossa vida cotidiana sem se render a todo esse terrorismo da modernidade-: é assim que o autor nos faz repensar as nossas possibilidades de relação com o planeta que habitamos.
      No penúltimo ensaio, -O amanhã não está a venda-, Krenak abraça uma concepção idealista de que a pandemia seria como um anzol nos puxando para a consciência. É interessante pensar como muitas pessoas se debruçaram sobre esta visão, no sentido de que a crise sanitária nos levaria a pensar e repensar nossos padrões de vida, caminhando para uma vida mais harmoniosa. Entretanto, sabemos, que não foi bem isso que aconteceu.
      Por fim, o ensaio que dá título ao livro é um convite formidável para repensarmos nosso modo de viver, que sempre acaba sendo utilitário. Krenak vai falar que estamos aqui para fruir a vida.
      O livro é relativamente curto, embora seja denso e, para ser devidamente saboreado, precisa de calma, para não o ler de forma utilitária. Os questionamentos e visões ali presentes podem ser pautas de discussões longas e profundas com o nosso coletivo.
      A Vida Não é Útil é uma obra esplendorosa, que retoma a tradição indígena de transmissão de conhecimento através da oralidade. O livro é composto por textos ensaísticos elaborados a partir de lives e entrevistas cedidas por Ailton e organizadas por Rita Carelli. A editora é a Companhia das Letras.
      " },
   
    new Livro { 
      LivroId = 18, 
      Nome = "Casa Velha", 
      Descricao = "Casa Velha é um romance de Machado de Assis que aborda temas como o poder das normas sociais, a ascensão social e as relações de poder entre as classes sociais", 
      Publicacao = "1886", 
      AutorId = 2, 
      Avaliacao = "4,6",
      NumeroPaginas= 64,  
      Destaque = true, 
      Foto = "/img/livros/Casa Velha.png", 
      Pdf = "/pdf/livros/casaVelha.pdf",
      Resumo = 
      @"Ele era um padre e resolvera escrever um livro contando a história do Imperador Pedro I, mas logo desistiu, ficando apenas a escrever poemas. Entretanto, o chamado padre Luís Gonçalves dos Santos havia escrito memórias sobre a época do rei. Então quando viu a falta de qualidade do texto, decidiu escrever ele mesmo a história do imperador e assim mostrar o talento do clero ao redigir.
      Foi nessas circunstâncias que deu início à sua freqüência na chamada Casa Velha, após o padre Mascarenhas, pregador da capelinha da casa, insistir muito. Ali vivera um ministro que trabalhara para o Imperador. Agora na casa viviam apenas seu filho, Félix, sua viúva, D. Antônia e os empregados.
      Ele, com a permissão da viúva, logo deu início ao estudo dos papéis e livros que estavam na biblioteca do ex-ministro. Em pouco tempo já se tornara amigo da família. Félix mostrava nutrir uma grande amizade pelo padre e vice-versa. Ele geralmente só voltava à sua casa ao anoitecer e passava ali o dia tomando notas na biblioteca, tendo conversas com Félix e almoçando com a família.
      Sendo amigo da família, D. Antônia veio pedir-lhe que convencesse Félix de ir a Europa, e que o padre acompanhasse o rapaz. Enquanto isso, o rapaz confiava ao padre a vontade de ser deputado. O padre dava apoio à idéia dele e quando o inquiriu sobre a Europa ouviu de Félix que não podia ir.
      Nesses dias chegou à Casa Velha uma mocinha com cerca de dezessete anos, chamavam-na de Lalau, tinha lindos olhos e aparentava ter uma linda alma também. Ela era agregada na casa, ficou órfã muito cedo e fora criada pela tia. Estando o padre na biblioteca, certa vez recebeu a visita de Lalau, ocasião em que ficaram um bom tempo conversando e ela lhe falou como trocaria tudo para ter a companhia de sua mãe de volta.
      Ele já estava encantado pela menina, chegou a ver nela certo interesse por Félix, mas notou que parecia que ela o estimava mais. Depois observando o rapaz acreditou que ele, na verdade, fazia uma linha de sedutor. Entretanto, essa idéia se mostrou errada. Estando em sua casa, recebeu a visita de Félix e conversando com ele falou que Lalau devia se casar, ele citou que a mãe já pensara em um noivo para a menina, Silvirino – filho do segeiro. O padre então disse que ele não era um bom noivo para ela, visto que ela tinha recebido da melhor educação por parte de D. Antônia, e que o noivo ideal para ela era o próprio Félix.
      Depois dessa conversa ele soube que os dois se amavam e ficou encarregado de interceder a favor do casamento dos dois com D. Antônia que era uma mulher orgulhosa e queria fazer do casamento do filho uma aliança entre famílias. Ele conversou muito com ela, mas o casamento não fazia a sua vontade e chegou até a confessar que Lalau era o motivo pelo qual queria que o filho fosse a Europa.
      Alguns dias depois chegaram à Casa Velha alguns hóspedes para assistir as missas e participar da festa da Glória. Nesse episódio, ele pôde ver o interesse que D. Antônia tinha em ligar o filho a Sinhazinha, filha de um coronel que lhe ajudara com os relatos sobre o Imperador.
      No dia seguinte à partida de todos, inclusive Lalau, que tinha voltado para a casa da tia, o padre chegou à casa de D. Antônia e notou sua preocupação. Questionada, ela deixou claro que acreditava que o casamento de seu filho e Lalau era impossível porque ela era filha do ministro, que teve seus romances fora do casamento. Ficou na responsabilidade dele contar que aos dois que eram irmãos.
      Primeiro falou a Félix. Este ficou demasiadamente triste e passou a noite fora de casa, caminhando e refletindo. No outro dia confidenciou ao padre que agora o amor que tinha por Lalau se convertera em amor de irmão. Já Lalau, quando voltou à Casa Velha e encontrou os ares diferentes e a frieza de Félix, se entristeceu profundamente. Acreditava ter sido motivo de escárnio para Félix e afirmava não merecer nada diferente já que era pobre. Até que finalmente lhe contou o que se passava e a moça, tomada de tristeza, voltou para a casa da tia.
      Lalau agora desejava apenas viver do trabalho que pudesse fazer para se sustentar e nunca iria se casar. Na Casa Velha, D. Antônia trabalhava para casar o filho com Sinhazinha e assim curá-lo totalmente da antiga paixão e também poder retomar a presença de Lalau em sua casa. A este ponto o padre já havia terminado seus estudos na biblioteca do ex-ministro.
      Era seu último dia ali quando encontrou um bilhete que o fez procurar a tia de Lalau, Mafalda. Ele finalmente contou a ela o motivo do rompimento de Lalau com os moradores da Casa Velha. Sabendo da verdade, ela pode esclarecer os fatos. Era verdade que o ministro teve um caso com sua cunhada, mas nesse tempo Lalau já era nascida. O anjinho a que o ministro fazia menção no bilhete encontrado era o bebê, fruto de sua infidelidade, que morrera aos quatro meses de idade.
      Alegremente, o padre foi procurar D. Antônia e contou-lhe toda a verdade. E ela também lhe contou toda a verdade. Ela criara a história sobre Félix e Lalau serem irmãos como último pretexto para impedir o casamento, e agora sabia que supusera corretamente, mas estava arrependida e aceitava o casamento do filho.
      Félix se alegrou intensamente com a notícia, mas Lalau não. Esta não aceitou o casamento e disse que seria uma vergonha casar-se com o filho do homem que envergonhara sua família. Assim ela fez sua recusa e não cedeu às insistências do padre, da tia e até mesmo de Félix. Ao final ela se casou com Silvirino e Félix com Sinhazinha. Foram honestos, felizes não se sabe.
      " },
        
    new Livro { 
      LivroId = 19, 
      Nome = "Vida e morte de M.J Gonzaga de Sá", 
      Descricao = "Vida e morte de M.J Gonzaga de Sá é um livro que conta a história de um jornalista negro que vive no Rio de Janeiro no início do século XX, o qual aborda temas como: Desigualdade social, Racismo, Corrupção política, Abandono das populações periféricas, Burocratização do Estado.", 
      Publicacao = "1919", 
      AutorId = 15, 
      Avaliacao = "4,5", 
      NumeroPaginas= 108, 
      Destaque = true, 
      Foto = "/img/livros/Vida e morte de M.J Gonzaga de Sá.png", 
      Video= "8CMzr9D8_xc", 
      Pdf = "/pdf/livros/vida-e-morte-de-m-j-gonzaga-de-sa.pdf",
      Resumo = 
      @"Narrado por Augusto Machado, um funcionário público negro, o livro tece a biografia do personagem Gonzaga de Sá. Por meio dela, transparece o comportamento da alta sociedade do Rio de Janeiro do começo do século XX, além dos diversos problemas sociais que afligiam o próprio Lima Barreto.
      O Lima Barreto é e sempre foi um autor considerado periférico. Um homem que viveu nos subúrbios do Rio de Janeiro [RJ], que sempre se sentiu vítima de preconceito étnico, sempre se achou desprezado pelos seus colegas e sempre lutou muito contra o privilégio de determinados autores brancos, muitas vezes no julgamento dele, sem tanto talento, sem tanta coisa a dizer. Sendo assim, é compreensível que o principal tema de sua obra seja a denúncia do preconceito racial e a luta por um consequente reconhecimento social, resume o professor de literatura brasileira do Sistema Anglo de Ensino Maurício Soares Filho.
      Nesse podcast, Soares Filho traz dicas para quem está se preparando para o vestibular e aponta possíveis abordagens que podem ser feitas no exame.
      O que me parece que o Lima Barreto contribui muito claramente na leitura, na formação de um jovem leitor, num processo de desmontar as origens dos preconceitos. Ao investigarmos e compreendermos os movimentos em torno desse processo, que aqui nesse caso envolvem principalmente uma esperada modernização do Rio de Janeiro nessa passagem do Império para a República. E a abolição da escravatura, quer dizer, olhar para isso numa tentativa de compreender como chegamos até aqui, como chegamos nesse Brasil racista, machista, classista, em que ainda estamos no século XXI, explica.

" },
    new Livro { 
      LivroId = 20, 
      Nome = "No Seu Pescoço", 
      Descricao = "No seu pescoço é um livro que aborda temas  sobre injustiça social, desigualdade de gênero, sonho, nostalgia, racismo e preconceito contra imigrantes de forma combativa, sem ser abusiva", 
      Publicacao = "2017", 
      AutorId = 16, 
      Avaliacao = "4,2", 
      NumeroPaginas= 256, 
      Destaque = true, 
      Foto = "/img/livros/No seu pescoço.png",  
      Video= "EOZn3Ns07SE", 
      Pdf = "/pdf/livros/no seu pescoço.pdf",
      Resumo = 
      @"Não são muitos os autores que transitam com tanta facilidade do romance para o conto, do conto para o ensaio, do ensaio para os manifestos. Não importa o formato, a nigeriana Chimamanda Ngozi Adichie mostra completo domínio do seu ofício. Uma das melhores escritoras de sua geração, Adichie expõe nossa vulnerabilidade perante o desconhecido nos doze contos que compõem No Seu Pescoço, lançado originalmente em 2009, mas só agora traduzido para o português pela Companhia das Letras.
      As histórias contidas nessa coletânea são joias raras. Há ali a mesma potência de escrita que já conhecíamos dos romances da escritora, como Americanah e Hibisco Roxo, mas com mais espaço para experimentação de estilos, pontos de vista, narradores.
      Em No Seu Pescoço, o conto que dá título ao livro, a história é narrada em segunda pessoa, uma inversão estilística que nos coloca diretamente no lugar da personagem, uma recém-chegada aos Estados Unidos que tenta se adaptar aos cheiros, comportamentos e hábitos fora do seu lugar.
      À noite, algo se enroscava no seu pescoço, algo que por muito pouco não lhe sufocava antes de você cair no sono.
      Talvez o grande apelo de Chimamanda Ngozi Adichie, além da qualidade  e da força de sua escrita, seja sua capacidade de escrever sobre injustiça social, desigualdade de gênero, racismo e preconceito contra imigrantes de forma combativa, mas nunca panfletária. São as angústias que nos tornam humanos que formam a base de sua literatura, sem poupar nem distinguir ninguém.
      Se ela expõe as contradições de uma América que se julga superior e predominante em alguns contos, também não se furta a criticar o deslumbramento de muito dos imigrantes, que preferem esquecer suas raízes em nome de uma suposta integração. Em Os Casamenteiros, Chinaze chega à América após um casamento arranjado por seus tios com um médico nigeriano, há quase uma década radicado nos EUA.
      A vida com a qual ela sonhava nada tem a ver com a realidade que a espera nos Estados Unidos. A entrada da casa é simples e mal acabada, sem nenhuma semelhança com os pórticos dos filmes água com açúcar que ela costumava ver. Ofodile, o marido, nega todas suas raízes em nome da normalidade. Em vez de seu nome verdadeiro, ele prefere ser chamado de Dave Bell, mais palatável. No lugar do arroz de coco, ele demanda que Chinaze (agora Agatha) cozinhe frango empanado e gorduroso.
      Essas substituições vão se acumulando, para desespero da mulher. Mas embora reconheça que tenha caído numa armadilha, Chinaze sabe também que não lhe restam muitos outros caminhos. Ela também vai ter que esperar pelo sonho americano que nem sempre é real.
      Adichie escreve com conhecimento de causa. Ainda bastante jovem, ela emigrou para os Estados Unidos com uma bolsa de estudos e aprendeu muito sobre preconceito e invisibilidade, assunto constante de seus livros. É o retrato desses embates – com o Estado, com a cultura, com o outro e com nós mesmos –  que enfrentamos cotidianamente que dão sabor para sua literatura.
      " },
  

    new Livro { 
      LivroId = 21, 
      Nome = "Morangos mofados", 
      Descricao = "Morangos Mofados é um livro de contos que retratam a angústia, a solidão, a repressão e a busca por liberdade de jovens na década de 1970, durante a ditadura militar no Brasil.", 
      Publicacao = "1982", 
      AutorId = 17, 
      Avaliacao = "4,6", 
      NumeroPaginas= 192, 
      Destaque = true, 
      Foto = "/img/livros/Morangos mofados.png", 
      Video= "AvoP4aOb_fw", 
      Pdf = "/pdf/livros/morangos mofados.pdf",
      Resumo = 
      @"Parte I – O Mofo
      Duas personagens desconhecidas conversam. O diálogo começa com a primeira afirmando que a segunda é sua companheira. Toda a conversa se desenrola com a segunda personagem inquirindo se havia um significado oculto por trás dessa afirmação. A primeira personagem nega durante toda a conversa. A discussão perdura e parece não ter fim, estendendo-se até mesmo depois do final do conto.
      Os sobreviventes (Para ler ao som de Ângela Ro-Ro)
      O segundo conto relata a despedida de um casal em crise. É escrito em fluxo de consciência, misturando os pensamentos dos personagens. Após mais uma tentativa de sexo frustrada, eles recordam toda sua vida a dois, tentando ver onde erraram. Ela chega à conclusão que foi por excesso. Excesso de cultura. Excesso de experiências, ditas edificantes, que gradualmente foram minando o desejo de um pelo outro.
      O texto dá a entender que ambos levam uma vida confortável, morando em uma casa bem aparelhada e tendo realizado muitas viagens pelo mundo. O homem cogita deixar a parceira para ir morar no Sri Lanka, ela o apoia e vê como possível solução para os problemas deles, porém, ele parece se arrepender e fica o tempo todo tentando reverter o que disse.
      A mulher diz que o desejo arrefeceu, mas não foi por falta de esforço. Eles tentaram de tudo. Todas as crenças, terapias e soluções propostas. Desde simpatias até relacionar-se com outras pessoas de ambos os sexos. Nada funcionou. Ela pede que ele coloque Ângela Ro-Ro para tocar e ambos partem para o banheiro para vomitar a vodka barata que tomaram, depois, coloca o homem para fora do apartamento, desejando que ele vá para o Sri Lanka e encontre algum sentido na viagem. Ela mergulha nos próprios sentimentos e a música continua.

      O dia em que urano entrou em escorpião
      O conto se passa em um apartamento, dividido por quatro amigos que se conheciam há muito tempo. Os quatro haviam desistido de sair devido à falta de dinheiro. Um deles, identificado como rapaz de blusa vermelha, entra na sala alardeando que Urano havia entrado em Escorpião.  Nenhum dos outros três esboça reação. Um deles alterna entre a janela e a coleção de discos, que escutam no volume baixo para não atrair a atenção do síndico.
      A personagem descrita como moça com o livro nas mãos menciona diversas vezes sua leitura na conversa. Outro, foca sua atenção nos restos da galinha que sobrou do almoço. O rapaz de blusa vermelha cita diversas referências de astrologia para mostrar a importância do evento, mas, como seus amigos seguem não lhe dando atenção, o rapaz tenta se jogar da janela.
      Seus amigos o acolhem e resolvem fazer algo para acalmá-lo. Deitam-no na cama e preparam um chá. Desta vez, colocam o disco que o rapaz de blusa vermelha gosta em volume alto. Enquanto os quatro dividem um cigarro de maconha, o síndico berra à porta, mandando abaixar o som. Nisso, a moça retruca, dizendo que não poderá abaixar porque é um dia especial: Urano tinha entrado na casa de Escorpião.
      Pela passagem de uma grande dor (Ao som de Erick Satie)
      Lui está sozinho em seu apartamento, experimentando os efeitos estuporantes que sucedem após usar droga. Ele recebe a ligação de uma velha amiga. Ela tenta a todo custo convidá-lo para sair ou, de alguma forma, juntar-se a ela. Lui desconversa e muda de assunto o tempo todo. Por fim, ela, frustrada, desliga e Lui experimenta o arrependimento por não ter aceitado o convite.

      Além do ponto
      Este conto é narrado em uma espécie de fluxo de consciência organizado. O protagonista havia sido chamado por outro homem para ir à sua casa. Na narrativa, o protagonista está andando na chuva, portando uma garrafa de conhaque e um maço de cigarros. Segundo ele, não chamou um táxi porque, se o tivesse feito, não teria como comprar o maço ou a garrafa. Também não levava um guarda-chuva, pois tinha o hábito de perder.
      Enquanto andava, seus pensamentos se separavam em duas direções. Em uma delas, imaginava como seria sua chegada, recebido com jazz, uma mesa posta e um ambiente agradável. Na outra, fazia uma autoimagem que ele teimava em esconder. Não queria demonstrar sua falta de sono e de dinheiro ou seu descuido com a própria saúde.
      Durante a caminhada, cai e quebra a garrafa, encharcando-se de conhaque e se sujando de lama. Chega na casa do outro homem, bate por diversas vezes na porta e não é atendido. Tenta chamar pelo dono da casa, mas se esquece do nome.

      Os companheiros (uma história embaçada)
      A história inicia em suspenso e o próprio narrador esclarece que ir direto aos fatos faria com eles perdessem o sentido. As coisas acontecem em uma casa rodeada por morcegos, apesar de ninguém saber porque eles a rodeiam. Somos apresentados aos personagens: De Camisa Xadrez, Moreninha Brejeira, Médica Curandeira, Jornalista Cartomante e Ator Bufão.
      O texto passa boa parte do tempo narrando os encontros destes personagens, cada vez mais distantes e desinteressantes uns para os outros. Junta-se a eles o Marinheiro Frustrado. A narrativa vai listando alguns dos pequenos orgulhos pessoais de cada personagem. Essas descrições transcorrem até o momento em que, em pleno verão, um vento frio sopra e todos parecem se preparar para algum tipo de ação que está por vir.

      Terça-feira gorda
      A história se inicia em uma terça-feira de Carnaval, em que o personagem principal encontra outro homem durante as comemorações. Ele tem a impressão de conhecê-lo de algum lugar. Envolvem-se, beijam-se e tomam algum entorpecente sintético.
      Em meio à hostilidade das outras pessoas, resolvem sair de onde estão e ir à praia. Lá, retomam a ação. Porém, durante o sexo, são surpreendidos por uma turba enfurecida. Talvez formada pelas mesmas pessoas de antes. O protagonista consegue fugir, mas seu par não tem a mesma sorte.

      Eu, tu, ele
      A história começa em uma espécie de despedida, narrando o encontro de uma segunda e terceira pessoa com outro homem, que parece sentir inveja ou ciúmes dessas duas pessoas. Conforme o conto avança, percebemos que, na verdade, elas são duas facetas dele mesmo.


      Durante a despedida, notamos que a primeira pessoa é a personalidade que ele mantém para si. Já a segunda, a que usa dentro de sua casa, ele mantém com as pessoas com as quais consegue ser mais honesto. E a terceira, mais dura, é empregada na rua. Ele é um ator e sua partida é para disputar um papel em uma peça.

      Luz e sombra
      No último conto da primeira parte, o narrador parece estar em uma espécie de prisão. Não conseguimos decifrar se ele está narrando acontecimentos reais ou se são apenas delírios. Ele escreve uma espécie de súplica em forma de carta para alguém que não identificamos. Talvez seja um apelo do inconsciente para a consciência o libertar daquela existência sem sentido.
      Para ele, são fornecidos cigarros, pão e água diariamente. Por vezes, vomita sobre os suprimentos e não os consome. Existem três cenários: a sala-prisão, onde está no momento; uma escadaria, onde ele se sentava quando era adolescente; e um quarto, onde dormia quando ainda é bebê. O conto termina com a mesma súplica por libertação, dessa vez misturada com um pouco de esperança.

      Parte II – Os morangos
      Transformações (Uma fábula)
      A fábula parece toda uma alegoria para a depressão. O personagem está lá, mas não está. Em seu lugar, encontra-se a Grande Falta, com seus olhos verdes. Ele mantém uma casca, mas sabe que as pessoas conseguem ver a Falta.
      Existem momentos em que a esperança retorna, mesmo assim, ele sabe que a Falta vai perdurar por toda a sua vida. O narrador tenta dar vários nomes para a Grande Falta, na tentativa de controlá-la. Não consegue, mas aprende que pode estabelecer uma convivência complexa com ela.

      Sargento Garcia
      Este conto começa em uma sala de quartel, onde está o protagonista Hermes. Ele e outros homens estão nus para realizar um exame médico. No entanto, quem realiza o exame não é um médico, mas sim o sargento Garcia. Sua figura é aterrorizante para Hermes, que possui apenas 17 anos. Após uma sessão de abuso psicológico, o garoto é dispensado por conta de um atestado médico (que foi forjado), além do fato de sustentar a família (também mentira) e estudar para entrar em uma faculdade de Filosofia (essa, sim, uma verdade).
      Após sair do quartel e antes de tomar o bonde para ir para casa, é alcançado pelo sargento. Este oferece carona e Hermes aceita. No caminho, começam a conversar e Garcia fala que Hermes difere dos demais garotos. Hermes não entende e o sargento começa a acariciá-lo, o garoto corresponde e Garcia o convida para ir a outro lugar.
      Tendo aceitado o convite, ao chegarem, Hermes conhece Isadora, gerente do lugar — um hotel da pior qualidade, usado habitualmente pelo sargento. Os dois se dirigem a um quarto cheirando a mofo, onde fazem sexo apressadamente. Depois, vestem-se e se separam. Hermes toma o primeiro bonde que vê e se dá conta, no caminho, de que não sentiu dor ou desconforto no encontro, pelo contrário, está mais seguro de si.

      Fotografias
      O texto é dividido em duas partes, 18 x 24: Gladys e 3 x 4: Liége. Cada parte é o relato e descrição de duas mulheres muito diferentes entre si. Gladys tem 30 anos e é uma mulher experiente, que frequenta, quase diariamente, coquetéis em busca de homens para satisfazê-la. Liége, mais jovem e inexperiente, só havia tido uma experiência sexual, traumática. Em algum ponto de ambos os relatos, as duas se consultam com uma cigana.
      A mulher revela, para cada uma, em momentos diferentes, que em suas vidas existem dois amores. Gladys se lembra de um rapaz inexperiente que tivera e deixara partir, reacendendo nela o desejo por reencontrá-lo. Liége, por sua vez, recorda-se de sua experiência traumática e espera, pacientemente, por um príncipe encantado.

      Pêra, uva ou maçã?
      Este conto é narrado por um analista, que conta a sessão que teve com uma paciente. Esta, assim que entra, diz que acreditar que o psicólogo estava com as meias trocadas. Fato que ela afirma não ser importante, mas que não sai dos pensamentos dele por nenhum minuto.
      Ela conta que, quando estava vindo para a sessão, resolve comprar ameixas maduras e comê-las durante o trajeto. Na esquina do consultório, esbarra em um caixão saindo de um velório e derruba as ameixas. As recolhe, uma a uma, e então o cortejo pôde prosseguir. Ela tenta despertar no analista a gravidade do acontecido, o que não consegue.
      A moça sai e se despede, sem que o analista dê a sessão por encerrada. Deposita uma ameixa madura na escrivaninha e deseja um feliz ano novo a ele, em pleno setembro. Ele corre para encontrá-la, mas ela já estava fora do prédio. Percebendo que sua condição se deteriorara, decidiu ligar para os pais, no intuito de interná-la novamente, mas isso teria de esperar, pois o outro cliente logo chegaria.

      Natureza viva
      O conto é um ensaio sobre a ansiedade. Ele relata, em detalhes, como os seres humanos se distanciam por não saberem o que se passa no íntimo uns dos outros. Ainda diz que as pessoas seriam muito mais próximas se não tivessem nenhuma emoção, pois elas são a raiz de toda a ansiedade e escondê-las nos distancia. O ensaio termina dando a certeza de que, um dia, essa ansiedade passará, mas esse dia é incerto.

      Caixinha de música
      A história começa com a protagonista acordando de um sonho e vendo seu companheiro pondo uma caixinha de música para tocar. Ela pergunta o que há de errado e ele, após certa insistência, relata haver tido um sonho, dividido em três atos.
      No primeiro ato, ele viu uma árvore muito bela, de flores roxas e amarelas. Se aproximou e entrou por um vão no tronco. Dentro da árvore. Tudo era escuro, espinhoso e podre. Quando saiu, viu novamente a beleza. Entendeu isso como uma referência às angústias internas que liberam belezas.
      No segundo ato, retorna no dia seguinte e vê que eram duas árvores. Uma primavera e um salgueiro. Lado a lado. O homem diz à mulher que talvez fosse um caso de amor entre as árvores. Nesse momento, ele avança sobre a mulher e os dois quase começam a fazer sexo, mas ele para e inicia o terceiro ato.
      Na última parte, ele vê o salgueiro morto. Foi a primavera que o matou e sugou toda a sua vida para ser bela e florida. A mulher, então pergunta se ele se sentia sugado. Não teve resposta. O homem avançou mais uma vez sobre ela, dessa vez, para sufocá-la até a morte.

      O dia que Júpiter encontrou Saturno (nova história colorida)
      A narrativa começa do ponto de vista de uma moça, que resolveu ir a uma festa em um sábado à noite, em São Paulo. Lá, encontra um rapaz e passa a olhar tímida para ele. Senta-se na janela para admirar o céu e vê uma conjunção entre os planetas Júpiter e Saturno.
      O rapaz se senta ao seu lado para também contemplar e pergunta se ela gosta de olhar as estrelas. Ela aquiesce, ambos passam a travar um diálogo, que se inicia com astrologia. Entre vários assuntos e silêncios contemplativos, o leitor é levado por várias linhas de pensamento.
      Os dois parecem estar loucos, entorpecidos ou mesmo mortos que se encontram em uma pós-vida. A narrativa se encerra do ponto de vista do rapaz, que se mostra tão tímido quanto a moça. Ele se despede dela e vai embora.

      Aqueles dois
      Conta a história de dois colegas de trabalho, Raul e Saul. Ambos passaram para o mesmo concurso público, na mesma repartição, tinham idades próximas e nomes parecidos. Gostavam de cinema e tinham frustrações semelhantes. Raul terminou um casamento de três anos e não teve nenhum filho. Saul terminou um noivado muito longo e não concluiu a faculdade de arquitetura.
      Apesar de se distanciarem no início, o fato de se sentirem deslocados do resto da repartição (que chamavam “deserto de almas”) os aproximou. O texto continua descrevendo os colegas e suas vidas. Nenhum deles era da cidade onde trabalhavam, além disso, não tinham parentes morando perto. Raul tinha paixão por música e suas poucas posses realçavam esse interesse. Da mesma forma se comportava Saul com o desenho.
      Eles são descritos pelo narrador como bonitos. Belezas opostas, porém, complementares. Todas as mulheres da repartição parecem concordar com a descrição. Em seguida, nos é mostrado como eles se aproximaram. Saul chegou atrasado, porque ficou assistindo a um filme até tarde. Raul pergunta a história do filme e ambos começam a conversar sobre o assunto. O diálogo fica mais constante e os temas mais pessoais.
      Eles eram sempre convidados para reuniões sociais. Compareciam, mas ficavam conversando apenas entre si sobre os problemas que estavam enfrentando com as mulheres e de como a amizade de ambos parecia mais simples. Percebiam, toda segunda-feira, que sentiam falta um do outro. Sem, contudo, falarem sobre isso. Um dia, Saul faltou, e Raul parecia perdido. Tudo isso gerava burburinhos maldosos na repartição.
      Eles, agora, estavam mais próximos. Trocaram telefones e passaram a frequentar a casa um do outro nos finais de semana. Almoçavam ou jantavam juntos. Bebiam, fumavam, assistiam a filmes, cantavam, discutiam arte, jogavam. Os comentários e piadas maldosas aumentaram, sobretudo no dia em que chegaram juntos na repartição, com os cabelos molhados, pois Saul havia dormido no sofá de Raul devido à chuva.
      A mãe de Raul faleceu e este tirou a semana de folga. Desta vez, Saul quem se sentiu perdido. Quando Raul voltou, ambos passaram a noite juntos. Ficaram abraçados por bastante tempo, o que confundiu os sentimentos dos dois. Saul se despediu e, quando chegou em casa, chorou por conta de sua solidão.
      No Natal e Ano-Novo, ambos trocaram presentes e passaram a virada juntos. Dormiram nus, sem se importar, e trocando elogios sobre a beleza um do outro. Chegou janeiro e eles planejavam tirar férias juntos. O chefe os chamou e os mandou embora. A alegação foi de que o relacionamento de ambos era considerado imoral. Juntaram suas coisas e partiram no mesmo táxi, com os olhares de todos sobre eles.

      Pelas tardes poeirentas daquele resto de janeiro, quando o sol parecia a gema de um enorme ovo frito no azul sem nuvens no céu, ninguém mais conseguiu trabalhar em paz na repartição. Quase todos ali dentro tinham a nítida sensação de que seriam infelizes para sempre. E foram.
      Parte III – Morangos mofados
      Prelúdio
      Uma narrativa curta, também em fluxo de consciência, em que  o protagonista se sente angustiado com alguma coisa. O passar do tempo apenas aumenta a sensação, a falta, o gosto de morango mofado na boca.

      Allegro Agitato
      O personagem se consulta com o médico. Em seu consultório impecável, o bom doutor atesta a perfeita saúde do rapaz, mas este se queixa de uma sensação estranha: o estranho gosto na boca. O médico suspeita de ansiedade e lhe receita um tranquilizante.

      Adagio Sostenuto
      O remédio faz efeito, bem até demais, e a letargia toma conta dele. Vê-se perdido em um fim de semana, tomado pelo tédio. Lembra-se de sua ex. e tenta se masturbar, sem sucesso. Vomita por conta do remédio. Sabe ser bem-sucedido na carreira, mas a sensação de estar comendo morangos mofados persiste.

      Andante Ostinato
      Seus sonhos se tornam febris e alucinados. Acorda com a mesma sensação na boca e a realidade começa a se misturar com as lembranças e os sonhos. A casa começa a ficar descuidada, a sensação na boca persiste e ele cogita o suicídio.

      Minueto e Rondó
      Senta-se no parapeito da janela, olhando para a calçada logo abaixo. Pensa já ter morrido, vítima de uma hecatombe nuclear. Afasta a ideia e questiona a própria veracidade do mundo. Sente-se melhor, esperançoso. O gosto ruim na boca havia passado. Talvez o remédio estivesse fazendo efeito. Desiste da ideia de suicídio e passa a fazer planos: resolve plantar morangos." },  
    new Livro { 
      LivroId = 22, 
      Nome = "Canções Escolhidas", 
      Descricao = "As canções escolhidas de Cartola são Alvorada, As rosas não falam, Cordas de aço, Disfarça e chora, O inverno do meu tempo, O mundo é um moinho, Que é feito de você?, Sala de recepção, Silêncio de um cipreste e Sim", 
      Publicacao = "", 
      AutorId = 18, 
      Avaliacao = null,
      NumeroPaginas= 10, 
      Destaque = true, 
      Foto = "/img/livros/Canções Escolhida - Cartola.png", 
      Video= "3X6tRqEgqLY", 
      Resumo = 
      @"Alvorada:
    
      Alvorada:
      A canção descreve a beleza do amanhecer, com seus raios de sol que iluminam a cidade e trazem esperança.
      A letra fala sobre a importância de aproveitar cada novo dia e de ter fé em um futuro melhor.
      É uma canção alegre e inspiradora, que nos convida a celebrar a vida.

      As Rosas Não Falam:
      A canção reflete sobre a natureza e a beleza das coisas simples da vida, como as rosas.
      A letra nos ensina que devemos apreciar a beleza das flores e de tudo que nos rodeia, pois a vida é um presente.
      É uma canção poética e emocionante, que nos faz refletir sobre o valor da vida.

      Cordas de Aço:
      A canção fala sobre a força e a resistência do povo brasileiro, que apesar das dificuldades, não se curva.
      A letra nos mostra que o povo brasileiro é forte e corajoso, e que não desiste nunca.
      É uma canção emocionante e inspiradora, que nos faz sentir orgulho de ser brasileiro.

      Disfarça e Chora:
      A canção fala sobre a importância de disfarçar a tristeza e seguir em frente, mesmo quando a dor é grande.
      A letra nos ensina que não devemos nos entregar à tristeza, e que devemos sempre ter esperança.
      É uma canção emocionante e inspiradora, que nos ajuda a superar os momentos difíceis.

      O Inverno do Meu Tempo:
      A canção reflete sobre a velhice e a sabedoria que vem com o tempo.
      A letra nos mostra que a velhice pode ser uma fase da vida muito bonita, e que devemos aproveitar cada momento.
      É uma canção emocionante e reflexiva, que nos faz pensar sobre o sentido da vida.

      O Mundo é um Moinho:
      A canção reflete sobre a vida e a inevitabilidade do tempo, que tudo transforma e leva.
      A letra nos mostra que a vida é um ciclo, e que devemos aproveitar cada momento antes que ele se vá.
      É uma canção emocionante e reflexiva, que nos faz pensar sobre a nossa própria existência.

      Que é Feito de Você?:
      A canção fala sobre o amor e a saudade de alguém que se foi.
      A letra nos mostra que o amor é eterno, e que mesmo que a pessoa amada não esteja mais presente, ela sempre estará em nossos corações.
      É uma canção emocionante e triste, que nos faz lembrar de quem já se foi.

      Sala de Recepção:
      A canção fala sobre a importância de mantermos a nossa essência, mesmo quando somos julgados pela sociedade.
      A letra nos ensina que não devemos nos importar com a opinião dos outros, e que devemos ser sempre nós mesmos.
      É uma canção forte e inspiradora, que nos ajuda a ter coragem de ser quem somos.

      Silêncio de um Cipreste:
      A canção fala sobre a morte e a importância de valorizar cada momento da vida.
      A letra nos mostra que a morte faz parte da vida, e que devemos aproveitar cada instante como se fosse o último.
      É uma canção triste e reflexiva, que nos faz pensar sobre o sentido da vida.

      Sim:
      A canção fala sobre a fé e a esperança em um futuro melhor.
      A letra nos mostra que devemos ter fé em Deus e acreditar que dias melhores virão.
      É uma canção alegre e inspiradora, que nos enche de esperança.
      " },
   
    new Livro { 
      LivroId = 23, 
      Nome = "Alice no país das maravilhas", 
      Descricao = "é uma história sobre uma menina que sonha que cai numa toca de coelho e acaba num mundo mágico. Lá, ela vive aventuras e se depara com o absurdo, o impossível e questiona tudo o que aprendeu até ali", 
      Publicacao = "1865 ", 
      AutorId = 19, 
      Avaliacao = "4,8", 
      NumeroPaginas= 136, 
      Destaque = true, 
      Foto = "/img/livros/Alice no país das maravilhas.png",
      Video="Q6DQDyejPF4", 
      Pdf = "/pdf/livros/alice.pdf",
      Resumo =
      @"Alice no País das Maravilhas é um livro de fantasia escrito pelo autor britânico Lewis Carroll e publicado em 1865. A história começa com Alice, uma jovem curiosa que segue um coelho branco falante e acaba caindo em um buraco no chão.
Logo após cair no buraco, Alice encontra uma garrafa contendo um líquido que a faz crescer até um tamanho gigantesco, e em seguida encontra um bolo que a faz diminuir a um tamanho muito pequeno. Nessa nova escala, ela interage com animais e objetos inusitados, como o Gato de Cheshire, um gato sorridente que aparece e desaparece misteriosamente, o Lagarto que ensina a escrever poesia, e o Chapeleiro Maluco, que está sempre preso no tempo do chá das cinco. 
Alice conhece a Rainha de Copas, uma figura autoritária que governa o país com mão de ferro e tem um péssimo temperamento. Alice é convocada para um jogo de croquet bizarro, onde os equipamentos são flamingos e os jogadores são ouriços. Durante a partida, Alice tenta entender as regras estranhas, enquanto a Rainha de Copas muda as regras ao seu bel-prazer. 
Em seguida, Alice testemunha um julgamento na corte da Rainha de Copas, onde um sapato é o objeto de disputa. A Rainha de Copas faz acusações sem sentido e exige que o júri declare o réu culpado, independentemente das evidências apresentadas. Alice tenta interceder e argumenta com a Rainha, mas é impedida pelos soldados da Rainha. 
Enquanto explora esse mundo mágico, Alice enfrenta uma série de desafios e situações absurdas. Ela participa de um jogo de croquet com flamingos e ouriços, encontra um lagarto que ensina a escrever poesia sem sentido, e testemunha um julgamento na corte da Rainha de Copas.
Ao longo da história, Alice tenta entender as regras e lógicas desse mundo estranho e muitas vezes se vê frustrada por não conseguir compreendê-lo completamente. No final, ela acorda de um sonho e percebe que tudo não passou de uma fantasia.
Alice no País das Maravilhas é uma história clássica da literatura infantil e tem sido adaptada para diversas mídias, incluindo filmes, animações e peças teatrais. A obra é conhecida por sua atmosfera surreal, personagens excêntricos e pela capacidade de despertar a imaginação e a curiosidade das crianças.
" },


     // FUVEST
 
    new Livro { 
      LivroId = 24, 
      Nome = "A visão das plantas", 
      Descricao = "A obra conta a história de Celestino, homem cujo passado de brutalidade e violência assombrosas é substituído, no crepúsculo da vida, por um amor delicado e cuidadoso pelas plantas de seu jardim.",
      Publicacao = "2019",
      AutorId = 20, 
      Avaliacao = "3,5", 
      NumeroPaginas= 88, 
      Destaque = true, 
      Foto = "/img/livros/A visão das plantas.png", 
      Video = "Ad7fQCYXiIo", 
      Pdf = "/pdf/livros/A visão das plantas.pdf",
      Resumo = 
      @"No coração de uma Lisboa antiga, reside Celestino, um homem de passado sombrio. Ex-capitão de navio negreiro, ele carregou o peso de seus crimes por décadas. Mas, nos anos de outono da vida, encontra redenção em um lugar inesperado: um jardim.
Ali, entre roseiras e cactos, Celestino se transforma. Suas mãos, antes manchadas de sangue, agora cuidam com ternura de cada folha, de cada flor. O jardim se torna seu refúgio, um oásis de paz em meio à tempestade de sua consciência.
As plantas, com sua beleza silenciosa, ensinam a Celestino sobre a fragilidade da vida e a força da natureza. Ele aprende a observar, a escutar, a sentir a energia que emana de cada ser vivo. E, assim, encontra a paz que tanto buscava.
A visão das plantas é um livro sobre redenção, sobre a capacidade de transformação do ser humano. É uma história que nos convida a refletir sobre nossos próprios atos e sobre o poder da natureza para nos curar.
" },
   
    new Livro { 
      LivroId = 25, 
      Nome = "As meninas", 
      Descricao = "O livro acompanha a jornada de três jovens mulheres universitárias no início da década de 70. Lorena, Ana Clara e Lia são de mundos distantes, vivendo impasses, cada qual com seu próprio drama durante o período turbulento da ditadura.", 
      Publicacao = "1973", 
      AutorId = 21, 
      Avaliacao = "4,2",
      NumeroPaginas= 304, 
      Destaque = true, 
      Foto = "/img/livros/As meninas.png",  
      Video = "eSV-EIZxpU4", 
      Pdf = "/pdf/livros/asmeninas.pdf",
      Resumo = 
      @"Capítulo: Um
Lorena está em seu quarto divagando sobre o seu gato, que fugiu. Depois sobre Ana Clara, a quem vai bancar uma cirurgia restauradora da virgindade, pois a amiga estava noiva e possuía um amante traficante de quem gostava. E ainda sobre Marcus Nemesius, seu amor platônico.
Quando Lia aparece, conversam sobre greve na faculdade, prisão do namorado de Lia (militante), alienação da burguesia e repressão militar (prisão e tortura). 
Lorena ainda se lembra da morte de Rômulo, seu irmão, vítima de um tiro acidental dado pelo outro irmão, Remo. Por este motivo, Remo fugiu para o exterior e vivia mandando presentes para Lorena, que nunca superou o caso.

Capítulo: Dois
Ana Clara e Max se drogam e começam a delirar. As memórias de Ana Clara são um dentista que abusava sexualmente das duas, pensa no quanto ama Max e que em janeiro se casará com um homem normal e rico.
Sente ódio de Deus, de negros e do analista, reconhece a carência pelo fato de a mãe, prostituta, nunca lhe ter dado atenção e possuir uma infância pobre.
Já Max, também delirou e logo depois foi rezar. Lembra-se de sua educação fina mas empobreceu e tornou-se traficante. Tem uma irmã que sumiu com as joias da família e está internada em sanatório. Ana e Max se amam, mas o relacionamento é complicado.

Capítulo: Três
Lorena reflete sobre a violência no mundo ao seu redor e na dinâmica familiar. Ela gostaria de poder alienar-se da ‘máquina desse mundo’, onde intertextualiza com ‘A Máquina do mundo’, de Carlos Drummond de Andrade.
Rememora a chegada de Lia e Ana Clara, que perturbou sua vida privada. Embora sinta inveja da beleza de Ana Clara, ela reconhece suas crises pessoais, recordando o aborto que Ana Clara fez, resgatando a fábula da formiga e da cigarra, com quem compara a amiga.
A morte de Rômulo e as falhas nas relações humanas a inquietam, assim como sua relação com Fabrízio, interrompida por Lia. Posteriormente, conhece o Dr. M.N., por quem começa a sonhar em encontrar segurança e proteção.

Capítulo: Quatro
Max delira, pensando sobre música clássica. Conversa com Ana Clara sobre riquezas e viagens. Ana compara suas realidades, seu passado de miséria, e reclama de estar lúcida, lembrando do suicídio. Ela está grávida e quer abortar, embora ele deseje o filho.

Capítulo: Cinco
Lorena recebe a visita de uma freira e desconfia que ela é a responsável por escrever cartas anônimas.
Ela gostaria de poder sair de moto com Fabrízio mas acha que ele deve estar com outra mulher. Novamente, divaga sobre: a morte de Rômulo, as manchetes nos jornais, Lia, Simone de Beauvoir, Che Guevara, morrer e renascer, cita Gonçalves Dias e logo despede-se da freira, acreditando que sua velhice é sem sentido.
.
Capítulo: Seis
Na sala onde a militância está ativa, Lia e Pedro discutem temas variados, como experiências homossexuais e política, enquanto organizam um jornal. Durante uma operação, Lia descobre que Miguel será deportado para a Argélia. Ao voltar ao pensionato, desabafa com Madre Alix, que, apesar de querer ajudar, se sente impotente. 

Capítulo: Sete
Irmã Clotilde em um momento de conexão com Lorena, fala sobre diversos temas e critica a alimentação das três amigas.
Lorena quer ficar só e esperar pelo telefonema, até que Lia chega e a freira se vai. Lia pede roupas para os revolucionários, conta sobre a viagem à Argélia, brinca de entrevistar Lorena e mostram-se preocupadas com a gravidez de Ana e sua dependência. Lorena fica pensando na iniciação sexual das amigas e imagina como será sua primeira vez com o M.N, que é ginecologista.

Capítulo: Oito
Ana Clara e Max acordam e conversam. Logo após, Ana pensa na desculpa que vai inventar para o noivo aceitar seus contínuos sumiços, se arruma e sai. 
À noite, ela aceita uma carona, mas acaba se refugiando em um bar, onde aparece um velho estranho que a convida para seu apartamento e ela aceita, achando que era como ‘um pai’ que nunca teve. 

Capítulo: Nove
Na banheira, Lorena reflete sobre a existência e o papel das profissões na sociedade, ela sente todos os sintomas de todas as doenças mentais. 
Guga, um colega de Lorena, revela que abandonou sua família, está vivendo em um porão e se sente atraído por Lorena enquanto ela o alerta sobre suas escolhas e a sujeira em sua vida. Embora ela quase ceda, acaba expulsando-o. Lia quer provar que M.N. está mais para pai que para namorado, mas Lorena não admite. Falam ainda sobre a promessa de ajuda em dinheiro para a viagem de Lia à Argélia.

Capítulo: Dez
Lia pega uma carona com o motorista da mãe de Lorena para visitá-la. Ao chegar, observa o luxo, fuma e sonha com uma viagem para Argélia, escrevendo em um diário sobre sua pátria e a desunião da esquerda.
Encontra a mãe de Lorena chorando a morte do psiquiatra Dr. Francis, então tenta consolar a mulher, ouvindo suas reclamações sobre envelhecer e aceitar a morte. Depois, a mãe pergunta sobre os namoros e admite querer trazer a filha de volta para casa e contou uma versão totalmente diferente sobre a morte de Rômulo. 

Capítulo: Onze
Tarde da noite, Ana Clara chega transtornada ao quarto de Lorena, cheia de dor no peito e imunda. Lia chega para preparar as malas e Lorena vai até seu quarto, deixando Ana descansar. Ao voltar para o quarto, Lorena vê que Ana Clara está morta.

Capítulo: Doze
Lia corre aos ver o aceno de Lorena e vê-la massageando o peito de Clara, tentando revivê-la. Lorena encomenda o corpo, reza em latim, veste e pinta Ana Clara como se fosse a uma festa. Depois, elimina todas as pistas que comprometesse-os, então as duas amigas carregam o corpo e o abandonam em uma praça do bairro.
Voltando para o pensionato, separam-se definitivamente. Lia segue para o exílio junto ao namorado e Lorena de volta para a casa da mãe.
" },

    new Livro {
      LivroId = 26, 
      Nome = "Balada de amor ao vento", 
      Descricao = "A obra conta a história de amor entre Sarnau e Mwando, na qual faz uma crítica à poligamia e às tradições machistas e patriarcais que afetam a vida das mulheres.", 
      Publicacao = "1990", 
      AutorId = 22, 
      Avaliacao = "4", 
      NumeroPaginas= 176, 
      Destaque = true, 
      Foto = "/img/livros/Balada de amor ao vento.png",  
      Video = "2RFTqeLOYws", 
      Pdf = "/pdf/livros/Balada de Amor ao Vento.pdf",
      Resumo = 
      @"A base da narrativa apresentada são os personagens Sarnau, Mwando e o rei de Mambone. A narração é feita em primeira pessoa e Sarnau conta-nos a história de sua vida. Ela é a mulher que se apaixona perdidamente por Mwando quando o vê pela primeira vez. ”
Eles tentam um relacionamento, mas nem toda a beleza descrita na imagem de quando se conheceram permanece ao longo do tempo. O “coração virgem” de Sarnau estremeceu quando o viu e seus olhos ficaram hipnotizados, mas apesar da tentativa de se relacionarem ela é surpreendida quando Mwando a abandona.
Diante do afastamento que há com o homem pelo qual ela se via seduzida, Sarnau acaba se casando com o rei de Mambone. No casamento poligâmico ela é a primeira esposa.
Num reencontro com Mwando, Sarnau acaba engravidando e tendo um filho. A traição pode ser punida com morte e ela se vê absurdamente envolvida com o seu amor do passado. Resolve então fugir com ele, deixando para trás o filho e toda sua vida.
Verificamos na história que há uma interferência da religião na vida dos personagens. Em dado momento Mwando se vê em conflito entre o amor que tem por Sarnau e o desejo de se tornar um membro da Igreja Católica. Notadamente, Chiziane aponta a interferência da religião na cultura local, vez que essas interferências levam o personagem a tomar uma decisão que altera os valores sociais. A partir da religião há, portanto, uma modificação do costume.
Na obra está exposto também o casamento poligâmico e o papel da mulher como objeto de troca entre as famílias, sendo trocadas por uma quantidade acordada de vacas. Isto posto, nota-se que se trata de uma sociedade patriarcal, em que a mulher é considerada um ser inferior e submisso. Dessa forma, a mulher não tem vontade própria e não possui direitos.
Por lá a palavra do homem é superior e contestá-la pode ser um crime imperdoável. Todas as mulheres da família devem se submeter ao pátrio poder e o homem é quem decide sobre a vida dos que estão a eles subordinados. Vemos que a poligamia ao longo do romance se apresenta como uma característica cultural marcante daquele povo. É ela quem determina como os personagens vão se comportar e como vão agir diante de conflitos e de decisões que tomam ao longo da história. Ao homem é dado o direito de ser supremo,  de ter quantas mulheres quiser.
A mulher vive num mundo de opressão, tendo que ser subjugada aos mandos e desmandos do homem. De certa forma, é como se ela fosse escravizada pelo marido. Isso se nota quando a autora utiliza o termo “escravatura”. Quando Sarnau vai se casar com o futuro rei uma personagem diz a ela: “[...] Sarnau, em breve partirás para a escravatura. Chamar-te-ão preguiçosa, estúpida, feiticeira [...]”. Ou seja, a mulher tem que aceitar esse tipo de escravidão como se fora uma dádiva, pois estes são os costumes.
Sarnau exemplifica a mulher que o tempo todo precisa se demonstrar forte para suportar tudo que lhe é imposto, mas é considerada inferior e devedora de obediência.
Quando Sarnau casa, enquanto se prepara, ela recebe conselhos de mulheres mais velhas. Vemos nitidamente o contraponto que a autora faz. De um lado tem a ingenuidade da noiva que se encontra em estado de encantamento pelo casamento e de outro a triste realidade que a aguarda por ser mulher.
Mwando, por quem Sarnau se apaixona, é um homem que tem uma visão diferente das dos demais homens. Ele não aceita a poligamia, como mencionado anteriormente. Ele vê no casamento a necessidade de ter apenas uma mulher. Isso advém do contato que ele tem com a religião católica.  Ele declara-se cristão, estudou para ser padre, todavia acaba sendo punido por não ter seguido a reclusão e ter se envolvido com Sarnau.
Como ele advém de uma família católica, o que Sarnau não é, há motivação suficiente para que ela não seja aceita pela família como esposa. E os entes de Mwando escolhem uma jovem chamada Sumbi para com ele casar. Sumbi é católica.
De modo bastante claro, fica a interferência da sociedade na vida conjugal. Quando Mwando casa, a esposa não cumpre o papel que era esperado pela sociedade, e a tribo intervém no relacionamento.
Sarnau é uma mulher que se submete a muitas questões que nos faz refletir sobre como muitas culturas enxergam as mulheres, pois em grande parte de sua vida experimenta diversos traumas, como as agressões físicas impostas pelo marido; os abandonos do amado Mwando; o aborto nas águas do rio Save; o abandono dos filhos; a doença da filha Phati; a prostituição e a decadência social.
Mas, não podemos deixar de mencionar, que essas fissuras que acontecem ao longo da sua história e que são problemas que a personagem enfrenta, são também fatores que fomentam a sua formação.
Mesmo que muitas vezes suas vivências sejam percebidas apenas como sofrimento, na verdade vão além disso, pois é através dessa dor que a protagonista consegue se reconstruir, sobreviver a todas as agruras impostas pela vida e seguir adiante, transformando-se.
Sarnau é uma mulher que busca o tempo todo se descobrir. Ela procura seu lugar no mundo e há muitas passagens de sua história em que ela se perde nessa trajetória. Esses percalços pelos quais a personagem passa, a faz seguir adiante rumo ao aprendizado, ao amadurecimento. A jornada da personagem é um claro exemplo de bildungsroman, ou seja, de romance de formação.
O leitor acompanha Sarnau desde a adolescência, passando por sua paixão e abandono pelo jovem Mwando, passa pelo casamento com Nguila, o retorno de Mwando para sua vida, a maternidade, os dramas vividos nessa fase, e seu caminho como vendeira em um bairro de Moçambique.

Portanto, Balada de amor ao vento é um romance que destaca as dificuldades da jovem Sarnau e como ela ultrapassou tais obstáculos para sobreviver, e não só para ser feliz. O sofrimento é constantemente assinalado como símbolo de superação e a história da personagem é marcada por opostos, tais como o sofrimento versus a busca pela felicidade.
O título do livro, Balada de amor ao vento, reflete o que há na história. É como se todo o amor buscado e tentado por Sarnau fosse levado pelo vento. O passado que ela tem provoca marcas profundas naquilo que ela é no presente. O amor que ela deposita em Mwando pode ser leve como uma brisa ou cortante como uma rajada forte de vento.
" },

    new Livro {
      LivroId = 27, 
      Nome = "Caminho de pedras", 
      Descricao = "Na Fortaleza dos anos 1930, durante a Era Vargas, Roberto tem a missão de recrutar operários para uma nova célula de esquerda. Uma das pessoas que se interessam é Noemi: mãe de Guri e casada com um homem que não ama mais, ela está em busca de algo que a faça se sentir viva.", 
      Publicacao = "1937", 
      AutorId = 23, 
      Avaliacao = "3,5",
      NumeroPaginas= 176, 
      Destaque = true, 
      Foto = "/img/livros/Caminho de Pedras.png", 
      Video = "KF8nspT8Y00", 
      Pdf = "/pdf/livros/caminhos de pedra.pdf",
      Resumo = 
      @"Há uma idéia matriz neste romance e em torno dessa idéia é que vai gravitar toda a sua ação: a da desigualdade social da mulher.
      João Jacques é o marido de Noemi e ambos tem um filho, o Guri. Jacques não é borracho, nem libertino e nem portanto espanca a mulher. É ótimo pai e um bom marido vivendo em paz com a mulher. Mas a paz matrimonial é mais fecunda em paz do que em amor. Porém o espírito era diferente, o espírito da mulher de João Jacques do espírito dele.
      Com isso, Noemi conhece um homem, o Roberto, que reflete um espírito como o dela, de idéias e gostos que se completam. Simpatizam-se e atrás da simpatia veio o amor entre eles.
      Noemi, no entanto, não detesta o marido e vacila na separação. Ela sente, a mulher de João Jacques que não tem o direito de sacrificar ao egoísmo do seu prazer a alegria e a paz do momento. Portanto Noemi cometia o adultério se envolvendo escondida com Roberto.
      Mulher de vontade própria, firme, acostumada a lutar como um homem pela vida e não querendo fazer do adultério uma traição, ela não sabe como ir a João Jacques e propor a separação, que depois se tornaria inevitável.
      João Jacques, então, foi embora e Noemi passa a viver com Roberto e o filho. A sociedade a reprovava e até seu chefe a demitiu.
      Um dia, o Guri, o filho de Noemi adoeceu e acabou morrendo por uma febre que lhe dava convulsões. Noemi ficou desesperada. Chorou muito!
      No final do romance todos foram embora, um a um: João Jacques, o Guri, os seus amigos como Felipe e Angelita, e o Roberto. Sim, o Roberto. Ele foi preso e levado para longe pois quis dar proteção à Noemi que se encarregara de entregar o maço de boletins nos quarteirões. (Relaciona-se a propagandas subservivas por fazerem parte de uma organização trabalhista).
      Roberto que foi junto com ela para protegê-la, acabou sendo preso e levado embora, para o Sul ou para uma  ilha, não se tinha certeza. E Noemi foi solta porque estava grávida de Roberto. Então acabou ficando sozinha.
      Assim termina o livro, com Noemi pisando em falso em uma pedra solta e subindo a ladeira, conversando com o filho no ventre:
      - Mais devagar, companheiro!
      " },
   
  
    new Livro {
      LivroId = 28,
      Nome = "Canção para ninar menino grande", 
      Descricao = "A obra questiona o patriarcado e as construções sociais da masculinidade, é um retrato de um homem através dos relacionamentos que ele coleciona com várias mulheres negras.", 
      Publicacao = "2018", 
      AutorId = 24, 
      Avaliacao = "4,2", 
      NumeroPaginas= 136, 
      Destaque = true, 
      Foto = "/img/livros/Canção para Ninar Menino grande.png",  
      Video = "D2zip80MGhU", 
      Pdf = "/pdf/livros/cançao para ninar menino grande.pdf",
      Resumo = 
      @"Embora o protagonista seja um homem, ele só ocupa o centro da narrativa por causa das mulheres que as contam. Fio Jasmin, um homem negro, jovem e belíssimo, trabalha como assistente de maquinista e a cada parada que o trem faz ao longo do percurso, desce para explorar a cidade e também para explorar as mulheres daquele local.
      É assim quase o livro todo. Mesmo casado e pai de quase uma dezena de filhos com Pérola Maria, Fio Jasmin aproveita as paradas do trem para encantar alguma mulher de cada
      cidade. Isso acontece, por exemplo, com uma enfermeira “solteirona”, uma jovem que nada pelada no rio, uma virgem de família nobre, uma dona de joalheria, entre outras. As histórias foram se acumulando até chegarem à escrevivência de Conceição Evaristo.
      Mas por que esse homem parece viver apenas em busca de procriar e de encantar mulheres? Talvez porque ele foi ensinado que é esse o seu único papel como homem negro.
      Durante a história tomamos ciência de um episódio na infância de Fio Jasmin que o marcou: em uma peça na escola, Fio foi impedido de atuar como príncipe, papel, segundo sua professora, mais adequado a um menino branco e loiro.
      Esse trauma de quando criança, declaradamente uma rejeição, muitas vezes nos marca e faz com que exista uma compensação quando nos tornamos adultos. Se quando criança Fio Jasmim não conseguiu ser o príncipe, agora adulto ele irá empilhar mulheres, as dilacerar, fazê-las implorarem pela sua companhia e pelo seu gozo.
      E cabe a essas mulheres, solitárias e negras, esperá-lo, acariciá-lo e serem punidas pela rejeição desse homem, mesmo que elas não possuam culpa alguma.
      Tão acostumado a colocar seu corpo como objeto de prazer, Fio Jasmin tem uma surpresa ao encontrar uma mulher lésbica, que o oferece não o gozo, mas uma amizade e um aconchego que ele até então não conhecia.
      " },
   
    new Livro { 
      LivroId = 29, 
      Nome = "Memórias de Martha", 
      Descricao = "A obra narra a história de uma jovem chamada Marta, que viveu no Rio de Janeiro no final do século XIX, é uma autobiografia ficcional que retrata as dificuldades enfrentadas por Marta e sua mãe, viúva.", 
      Publicacao = "1899", 
      AutorId = 25, 
      Avaliacao = "3,5", 
      NumeroPaginas= 118, 
      Destaque = true, 
      Foto = "/img/livros/Memórias de Martha.png",  
      Video = "4lroyIb6mdM", 
      Pdf = "/pdf/livros/memoriasdemartha.pdf",
      Resumo = 
      @"Martha e sua mãe, viúva, enfrentam dificuldades financeiras e moram em um cortiço, um ambiente insalubre e degradante. A narrativa detalha as dificuldades da vida na pobreza, como a falta de comida, as condições precárias de moradia e a violência presente no cotidiano. Martha testemunha a luta da mãe para sustentar a família, trabalhando como costureira e enfrentando humilhações.
    Mas apesar das dificuldades, Martha valoriza a educação e busca oportunidades para aprender, ela frequenta a escola pública e demonstra interesse pelos estudos, buscando conhecimento como forma de ascensão social. Na obra, educação é apresentada como uma ferramenta fundamental para a emancipação da mulher e a superação da pobreza.
    Martha sonha em ter uma vida independente e desafia as expectativas da sociedade sobre o papel da mulher, ela busca um trabalho que lhe permita ter autonomia financeira e tomar suas próprias decisões, no entanto questiona os padrões da época, que limitavam as mulheres ao papel de esposa e mãe.:
    Ao longo da história, Martha vivencia diferentes relacionamentos e experiências amorosas, ela se apaixona por homens que representam diferentes classes sociais e ideais de vida.
    Os relacionamentos de Martha contribuem para seu crescimento pessoal e para a
    compreensão da complexidade das relações humanas.
    A personagem enfrenta diversos desafios ao longo da vida, como a morte da mãe, a pobreza extrema e a violência de gênero, mas sua força e determinação a ajudam a superar as dificuldades e a construir seu próprio caminho, ela demonstra resiliência e capacidade de adaptação, buscando sempre novas oportunidades de crescimento.

    O livro aborda as limitações impostas às mulheres na sociedade do século XIX, como a falta de acesso à educação e ao mercado de trabalho.
    A obra retrata a luta pela emancipação feminina e a busca por igualdade de direitos, Martha é uma personagem que desafia os padrões da época e representa a força e a capacidade das mulheres." },
   
    new Livro {
      LivroId = 30, 
    Nome = "Nebulosas", 
    Descricao = "Seus poemas revelam uma voz lírica única, que aborda temas íntimos, femininos e ligados à natureza, ao mesmo tempo em que expressam uma preocupação social evidente, especialmente em relação à abolição da escravatura, uma questão presente na sociedade brasileira do século XIX.", 
    Publicacao = "2024", 
    AutorId = 26, 
    Avaliacao = "3", 
    NumeroPaginas= 224, 
    Destaque = true, 
    Foto = "/img/livros/Nebulosas.png", 
    Video = "hyRk4grRmK8", 
    Pdf = "/pdf/livros/Nebulosas.pdf",
    Resumo = 
    @"A obra nos convida a embarcar em uma viagem poética que explora temas como a natureza, o amor, a saudade e a liberdade. Com uma linguagem rica e expressiva, a autora nos transporta para um universo de sentimentos e reflexões.

A natureza exuberante do Brasil é um tema central na obra de Narcisa Amália. Seus poemas descrevem paisagens verdejantes, rios sinuosos e o céu estrelado, revelando um profundo amor pela terra natal. A beleza natural se entrelaça com o sentimento de patriotismo, expressando o orgulho de ser brasileira e a esperança de um futuro promissor para o país.

O amor, em suas diversas formas, é outro tema recorrente em Nebulosas. Narcisa Amália expressa o amor romântico, o amor materno e o amor fraterno com intensidade e delicadeza. A saudade, sentimento melancólico que permeia muitos poemas, surge como uma lembrança de momentos felizes ou de pessoas queridas que se foram.

Em seus versos, Narcisa Amália se revela uma mulher à frente de seu tempo, quebrando barreiras e desafiando convenções sociais. A defesa da liberdade, especialmente a abolição da escravidão, é um tema presente em sua obra. Além disso, a autora se destaca como uma voz feminina forte e corajosa, expressando seus sentimentos e ideias em uma sociedade conservadora.
" },
   
    new Livro { 
    LivroId = 31, 
    Nome = "O cristo cigano", 
    Descricao = "O livro é composto por uma série de poemas que contam a história de uma lenda sobre o assassinato de um cigano e a construção de uma imagem de Cristo.", 
    Publicacao = "1961", 
    AutorId = 27, 
    Avaliacao = "3,7", 
    NumeroPaginas= 112, 
    Destaque = true, 
    Foto = "/img/livros/O cristo cigano.png", 
    Video = "5AmVcO5VqK8", 
    Pdf = "/pdf/livros/ocristocigano.pdf",
    Resumo = 
    @"O livro narra a história de um personagem que é uma representação de um Cristo alternativo, diferente do tradicional apresentado pela religião cristã. Esse Cristo Cigano é uma figura que se distorce das normas e dogmas tradicionais da religião e da sociedade, refletindo mais uma busca individual, a libertação pessoal e a reinterpretação do ser humano como um ente livre, sem amarras impostas pela fé ou pelas estruturas sociais.

No enredo, a personagem principal busca um caminho de transformação e transcendência. O romance está inserido dentro de uma crítica à sociedade da época e coloca o Cristo Cigano como alguém marginalizado, sendo uma espécie de questionador das normas estabelecidas, como se fosse um messias fora dos padrões conhecidos, um rebelde.

O termo Cigano é usado aqui não apenas de forma literal, mas como uma metáfora para o estigma e o caráter nômade. Os ciganos, ao longo da história, foram muitas vezes marginalizados e rejeitados pela sociedade convencional. Raul Seixas utiliza essa figura para questionar e desafiar a rigidez das instituições e das crenças que limitam a liberdade do indivíduo. 

Ao explorar a figura do Cristo, Raul Seixas coloca a divindade em uma posição que vai além da religião cristã convencional. O Cristo cigano é visto como alguém que transita entre o sagrado e o profano, entre a sacralidade do divino e a realidade terrena, conectando a espiritualidade com uma busca genuína de liberdade e identidade.

A obra é um manifesto contra a opressão, a moralidade rígida e as estruturas autoritárias que dominam a vida humana. O autor sugere, por meio da figura desse Cristo marginalizado, que a verdadeira liberdade espiritual é encontrada fora das normas e convenções tradicionais. 
 "},
   
    new Livro { 
      LivroId = 32, 
      Nome = "Opúsculo Humanitário", 
      Descricao = "A obra traça a evolução das condições femininas e mostram a experiência da autora tanto em leitura, quanto em vivências em suas viagens.", 
      Publicacao = "1853", 
      AutorId = 28, 
      Avaliacao = "3,6", 
      NumeroPaginas= 216, 
      Destaque = true, 
      Foto = "/img/livros/Opúsculo Humanitário.png", 
      Video = "XB0LwvUjIlM", 
      Pdf = "/pdf/livros/Opusculo_humanitario.pdf",
      Resumo = 
      @"O livro contém a síntese do pensamento de Nísia Floresta sobre a educação formal e informal de meninas, seu vasto conhecimento de Filosofia e História.
A autora recupera, neste livro, parte da história da condição feminina em diversas civilizações – da Antiguidade clássica ao seu tempo –relacionando o desenvolvimento intelectual e material do país (ou seu atraso) com o lugar ocupado pelas mulheres naquela sociedade. Ao final, trata do Brasil, da mulher brasileira e da educação para meninas. Aliás, este parece ser o motivo mesmo de toda a reflexão anterior. 
Nísia Floresta defende a tese de que o progresso de uma sociedade depende da educação que é oferecida à mulher, e que só a educação moral e a religiosa, incutida desde cedo na menina, fariam dela melhor esposa e melhor mãe. … 
Mas atenção: ao fazer a leitura deste especial momento da vida brasileira, é preciso ter em mente o alcance que deve ter tido, naquela época, a repentina valorização da figura feminina e da sua função biológica exclusiva. Para quem até então ocupava um papel obscuro em consequência de uma estratificação social rígida que privilegiava só o masculino, transformar-se em centro das atenções e receber homenagens, devia realmente significar muita coisa – como naturalmente significou. Essa foi uma etapa obrigatória na história da liberação da mulher que precisava ser cumprida.
"}};

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
              
              (Amado, J. Dona Flor e seus dois maridos. São Paulo: Companhia das Letras, 1992.)
              
              No trecho citado, o autor representa uma situação desencantada da mulher brasileira dos anos
              1940, tratando com humor a sensualidade e os conflitos sociais que envolvem essa época."},
        
        new Pergunta { PerguntaId = 2, FaculdadeId = 1, Enunciado =
            @"(Livro: Dona Flor e Seus Dois Maridos)
            
            Sobre a personagem Dona Flor, é correto afirmar que:"},

        new Pergunta { PerguntaId = 3, FaculdadeId = 1, Enunciado =
         @"(Dom Casmurro)
         
         (ESPCEx/2019)
         Retórica dos namorados, dá-me uma comparação exata e poética para dizer o que foram aqueles olhos de Capitu.
         Não me acode imagem capaz de dizer, sem quebra da dignidade do estilo, o que eles foram e me fizeram. 
         Olhos de ressaca? Vá, de ressaca. É o que me dá idéia daquela feição nova. Traziam não sei que fluido misterioso 
         e enérgico, uma força que arrastava para dentro, como a vaga que se retira da praia, nos dias de ressaca.
         Para não ser arrastado, agarrei-me às outras partes vizinhas, às orelhas, aos braços, aos cabelos espalhados pelos ombros; 
         mas tão depressa buscava as pupilas, a onda que saía delas vinha crescendo, cava e escura, ameaçando envolver-me, 
         puxar-me e tragar-me.
        (ASSIS. Machado de. Dom Casmurro. São Paulo: Ática,1999. p.55 (fragmento))
        
        Com Dom Casmurro, obra publicada em 1899, depois de Memórias Póstumas de Brás Cubas (1881) e de Quincas Borba (1891),
        Machado de Assis deixa marcas indeléveis de que a Literatura Brasileira vivia um novo período literário, bem diferente
        do Romantismo. Nessas obras, nota-se uma forma diferente de sentir e de ver a realidade, menos idealizada, mais verdadeira
        e crítica: uma perspectiva realista. O trecho apresentado acima representa essa perspectiva porque o narrador:"
        },

         new Pergunta { PerguntaId = 4, FaculdadeId = 2, Enunciado =
         @"Morro da Babilônia
         
         À noite, do morro    
        descem vozes que criam o terror    
        (terror urbano, cinquenta por cento de cinema,     
        e o resto que veio de Luanda ou se perdeu na língua     
        Geral).

        Quando houve revolução, os soldados     
        espalharam no morro,    
        O quartel pegou fogo, eles não voltaram.   
        Alguns, chumbados, morreram.    
        O morro ficou mais encantado.   

        Mas as vozes do morro   
        não são propriamente lúgubres.   
        Há mesmo um cavaquinho bem afinado     
        que domina os ruídos de pedra e da folhagem   
        e desce até nós modesto e recreativo,   
        como uma gentileza no morro   

        (Carlos Drummond de Andrade Sentimento do mundo. São Paulo: Companhia das Letras, 2012, p. 19.)

        No poema “Morro da Babilônia”, de Carlos Drummond de Andrade,"
      },

       new Pergunta { PerguntaId = 5, FaculdadeId = 2, Enunciado =
         @"Para driblar a censura imposta pela ditadura militar, compositores 
         de música popular brasileira (MPB) valiam-se do que Gilberto Vasconcelos 
         chamou de “linguagem da fresta”, expressão inspirada na canção “Festa imodesta”, de Caetano Veloso.
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
       (Gilberto de Vasconcelos, Música popular: de olho na fresta. Rio de Janeiro: Graal, 1977.)

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
        Fernando Pessoa. In: “A Coroa”, Parte I, Mensagem.

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
        O Manifesto Futurista, de autoria do poeta italiano Filippo Tommaso Marinetti (1876-1944), foi publicado em Paris em 1909. Nesse manifesto, Marinetti declara a raiz italiana da nova estética: “queremos libertar esse país (a Itália) de sua fétida gangrena de professores, arqueólogos, cicerones e antiquários”. Falando da Itália para o mundo, o Futurismo coloca-se contra o “passadismo” burguês e o tradicionalismo cultural. A exaltação da máquina e da “beleza da velocidade”, associada ao elogio da técnica e da ciência, torna-se emblemática da nova atitude estética e política.

        (https://enciclopedia.itaucultural.org.br. Adaptado.)

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
        (Mamede Mustafa Jarouche. “Galhofa sem melancolia”, 2003. Adaptado.)

         O comentário refere-se ao romance"
      },
    };
    builder.Entity<Pergunta>().HasData(perguntas);

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
    builder.Entity<PerguntaAlternativa>().HasData(perguntasAlternativas);


        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
            Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
            Name = "Administrador",
            NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
            Id = "2",
            Name = "Moderador",
            NormalizedName = "MODERADOR"
            },
            new IdentityRole() {
            Id = "3",
            Name = "Usuário",
            NormalizedName = "USUÁRIO"
            },
        };

        builder.Entity<IdentityRole>().HasData(roles);
        #endregion



        #region Populate Usuário
        var usuario = new Usuario()
        {
            Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
            Email = "admin@vestbooks.com",
            NormalizedEmail = "ADMIN@VESTBOOKS.COM",
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            LockoutEnabled = true,
            EmailConfirmed = true,
            Nome = "Administrador",
            Foto = "/img/usuarios/ddf093a6-6cb5-4ff7-9a64-83da34aee005.png"
        };

        PasswordHasher<Usuario> pass = new();
        usuario.PasswordHash = pass.HashPassword(usuario, "123456");

        builder.Entity<Usuario>().HasData(usuario);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = roles[0].Id },
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = roles[1].Id },
            new IdentityUserRole<string>() { UserId = usuario.Id, RoleId = roles[2].Id }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}