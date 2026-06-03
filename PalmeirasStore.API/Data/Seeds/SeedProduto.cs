using PalmeirasStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace PalmeirasStore.API.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder modelBuilder)
    {
        List<Produto> produtos = [
            // ========= CAMISAS ==========
            new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 26/27",
                Descricao = @"Mais do que uma camisa, é um símbolo de pertencimento. A camisa titular do Palmeiras traz o verde tradicional que carrega história, conquistas e a força de uma torcida apaixonada. Com visual que equilibra tradição e modernidade, é uma peça confortável e versátil, ideal para acompanhar jogos, momentos de lazer ou o dia a dia com estilo.", // "@" --> para ter certeza que tudo dentro é texto
                ValorCusto = 189.95m,
                ValorVenda = 379.90m, // "m" --> monetário (para números decimais)
                Qtde = 120,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/1.png"
            },
            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 26/27",
                Descricao = @"Elegante e marcante, a camisa II do Palmeiras traz o branco como protagonista, destacando a tradição do clube com um visual moderno e sofisticado. Inspirada no modelo usado em campo, é feita para quem busca autenticidade e conexão com o jogo. Os detalhes em contraste valorizam o design, enquanto o escudo do Palmeiras reforçam a identidade do clube.",
                ValorCusto = 189.95m,
                ValorVenda = 379.90m,
                Qtde = 110,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/2.png"
            },
            new() {
                Id = 3,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 25/26",
                Descricao = @"O verde alviverde em sua forma mais clássica. A camisa titular da temporada 25/26 carrega o DNA do clube em cada detalhe, unindo tecnologia de desempenho a um design que toda a Nação reconhece. Perfeita para vestir no estádio, em casa ou na rua, é a peça que conecta o torcedor ao time em qualquer momento.",
                ValorCusto = 124.95m,
                ValorVenda = 249.90m,
                Qtde = 65,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/3.png"
            },
            new() {
                Id = 4,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 25/26",
                Descricao = @"Alternativa ao verde, mas sem abrir mão da identidade. A segunda camisa da temporada 25/26 aposta em um visual diferenciado que mantém toda a essência do clube. Com acabamento impecável e tecido de alta performance, é ideal para quem quer demonstrar paixão pelo Verdão com um toque de sofisticação.",
                ValorCusto = 124.95m,
                ValorVenda = 249.90m,
                Qtde = 55,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/4.png"
            },
            new() {
                Id = 5,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma III 25/26",
                Descricao = @"Ousada e exclusiva, a terceira camisa da temporada 25/26 é para quem não tem medo de se destacar. Com uma paleta de cores inédita e detalhes que remetem à história do clube, essa peça une atrevimento e tradição em um único uniforme. Uma colecionável que vai muito além das quatro linhas.",
                ValorCusto = 214.95m,
                ValorVenda = 429.90m,
                Qtde = 30,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/5.png"
            },
            new() {
                Id = 6,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 24/25",
                Descricao = @"Registrada em campo com grandes conquistas, a camisa titular da temporada 24/25 é um pedaço vivo da história recente do Palmeiras. O verde vibrante e o escudo estampado com orgulho fazem desta peça uma lembrança permanente de uma era vitoriosa. Ideal para quem quer guardar um capítulo especial do clube.",
                ValorCusto = 124.95m,
                ValorVenda = 249.90m,
                Qtde = 25,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/6.png"
            },
            new() {
                Id = 7,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 24/25",
                Descricao = @"Com uma proposta visual que contrasta com o uniforme principal, a segunda camisa da temporada 24/25 ganhou destaque tanto dentro quanto fora dos gramados. O design limpo e moderno agrada aos torcedores que valorizam estética sem perder a essência alviverde. Uma peça versátil para o dia a dia do palmeirense.",
                ValorCusto = 124.95m,
                ValorVenda = 249.90m,
                Qtde = 20,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/7.png"
            },
            new() {
                Id = 8,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma III 24/25",
                Descricao = @"Diferente, marcante e cobiçada. A terceira camisa da temporada 24/25 foi uma das mais comentadas pelos torcedores, com uma identidade visual única que mistura ousadia e pertencimento. Usada em partidas memoráveis, tornou-se uma das peças mais desejadas da coleção e um símbolo de orgulho para quem acompanhou de perto aquela campanha.",
                ValorCusto = 184.95m,
                ValorVenda = 369.90m,
                Qtde = 15,
                Destaque = true,
                Foto = "/img/Produtos/Camisas/8.png"
            },

            // ========= RETRÔ ==========

            new() {
                Id = 9,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1959",
                Descricao = @"Uma viagem ao passado glorioso do clube. Inspirada no uniforme que o Palmeiras usava em 1959, esta peça resgata a essência de uma época que moldou a identidade alviverde. Com detalhes fiéis ao original e acabamento moderno, é a escolha perfeita para o torcedor que valoriza a história e quer carregá-la no peito.",
                ValorCusto = 139.95m,
                ValorVenda = 279.90m,
                Qtde = 22,
                Destaque = true,
                Foto = "/img/Produtos/Retro/1.png"
            },
            new() {
                Id = 10,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Flame Retrô 1959",
                Descricao = @"A versão Flame traz uma releitura ainda mais expressiva do clássico uniforme de 1959, com elementos gráficos que amplificam a energia daquela geração histórica. O resultado é uma peça que une nostalgia e estilo contemporâneo, ideal para quem quer homenagear as raízes do Verdão com personalidade.",
                ValorCusto = 139.95m,
                ValorVenda = 279.90m,
                Qtde = 18,
                Destaque = true,
                Foto = "/img/Produtos/Retro/2.png"
            },
            new() {
                Id = 11,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1972",
                Descricao = @"1972 foi um ano inesquecível para a história do Palmeiras, e esta camiseta é uma forma de reviver cada momento daquela conquista. Com design inspirado no uniforme original da época, combina nostalgia autêntica com conforto atual. Para o torcedor que sabe de onde o clube veio e tem orgulho de cada capítulo dessa trajetória.",
                ValorCusto = 144.95m,
                ValorVenda = 289.90m,
                Qtde = 20,
                Destaque = true,
                Foto = "/img/Produtos/Retro/3.png"
            },
            new() {
                Id = 12,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1973",
                Descricao = @"Homenagem a uma das páginas mais brilhantes do futebol brasileiro, esta camiseta reproduz o espírito do uniforme alviverde de 1973. As linhas clássicas e o escudo em estilo retrô fazem desta peça um item de colecionador que vai muito além da moda — é um tributo à grandeza de uma era dourada do clube.",
                ValorCusto = 144.95m,
                ValorVenda = 289.90m,
                Qtde = 17,
                Destaque = true,
                Foto = "/img/Produtos/Retro/4.png"
            },
            new() {
                Id = 13,
                CategoriaId = 2,
                Nome = "Camisa Palmeiras Retrô 1989 Masculina",
                Descricao = @"1989 ficou marcado na memória da torcida como o ano do Brasileiro conquistado com garra e coletividade. Esta peça resgata o visual daquele time com fidelidade e afeto, trazendo de volta a estética de uma época que encantou gerações. Uma forma bonita de carregar consigo um dos títulos mais queridos da história alviverde.",
                ValorCusto = 129.95m,
                ValorVenda = 259.90m,
                Qtde = 24,
                Destaque = true,
                Foto = "/img/Produtos/Retro/5.png"
            },
            new() {
                Id = 14,
                CategoriaId = 2,
                Nome = "Camiseta Palmeiras Retrô 1994",
                Descricao = @"O ano em que o Palmeiras voltou a reinar. Esta camiseta presta tributo ao uniforme da conquista do Campeonato Brasileiro de 1994, com um visual que remete diretamente àquela campanha histórica. Para quem viveu aquela emoção ou quer conhecer de perto esse capítulo fundamental da trajetória do clube.",
                ValorCusto = 124.95m,
                ValorVenda = 249.90m,
                Qtde = 28,
                Destaque = true,
                Foto = "/img/Produtos/Retro/6.png"
            },
            new() {
                Id = 15,
                CategoriaId = 2,
                Nome = "Camisa Palmeiras Retrô 1999 Masculina",
                Descricao = @"O Palmeiras que encantou o mundo em 1999 merece ser lembrado com respeito e emoção. Esta camisa revisita o uniforme daquela temporada inesquecível, com detalhes que capturam a energia de um elenco que entrou para sempre na história do clube e do futebol sul-americano. Uma peça para guardar com carinho.",
                ValorCusto = 134.95m,
                ValorVenda = 269.90m,
                Qtde = 19,
                Destaque = true,
                Foto = "/img/Produtos/Retro/7.png"
            },
            new() {
                Id = 16,
                CategoriaId = 2,
                Nome = "Camiseta Palmeiras Marcos Retrô 1999 Masculina",
                Descricao = @"Um ícone homenageando outro ícone. Esta camiseta une o uniforme histórico de 1999 ao nome de Marcos, o goleiro que se tornou um dos maiores símbolos do clube e da Libertadores conquistada naquele ano. Uma peça rara que celebra ao mesmo tempo um momento e um ídolo, essencial para qualquer colecionador alviverde.",
                ValorCusto = 159.95m,
                ValorVenda = 319.90m,
                Qtde = 12,
                Destaque = true,
                Foto = "/img/Produtos/Retro/8.png"
            },

            // ========= JAQUETAS E CASACOS ==========

            new() {
                Id = 17,
                CategoriaId = 3,
                Nome = "Agasalho Palmeiras Alive Masculino",
                Descricao = @"Conforto e identidade em uma peça só. O agasalho Alive combina tecido de qualidade com um design moderno que carrega as cores e o escudo do Palmeiras com orgulho. Ideal para os dias mais frios, treinos ou momentos de lazer, é a escolha certa para o torcedor que quer estar sempre bem vestido e identificado com o Verdão.",
                ValorCusto = 214.95m,
                ValorVenda = 429.90m,
                Qtde = 45,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/1.png"
            },
            new() {
                Id = 18,
                CategoriaId = 3,
                Nome = "Agasalho Palmeiras Savoia Masculino",
                Descricao = @"Sofisticação ao estilo alviverde. O agasalho Savoia foi desenvolvido para quem valoriza acabamento premium e identidade clube em cada detalhe. Com modelagem moderna e materiais de alta qualidade, protege do frio sem abrir mão do estilo. Uma peça que vai do aquecimento pré-jogo ao cotidiano com elegância.",
                ValorCusto = 224.95m,
                ValorVenda = 449.90m,
                Qtde = 38,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/2.png"
            },
            new() {
                Id = 19,
                CategoriaId = 3,
                Nome = "Quebra Vento Palmeiras Torcedor Masculino",
                Descricao = @"Feito para o torcedor que está sempre presente, seja no estádio ou na rua. O quebra-vento do Palmeiras oferece proteção contra o vento e o frio com leveza e praticidade, sem abrir mão das cores que representam o clube. Uma peça funcional que demonstra paixão em qualquer situação.",
                ValorCusto = 179.95m,
                ValorVenda = 359.90m,
                Qtde = 50,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/3.png"
            },
            new() {
                Id = 20,
                CategoriaId = 3,
                Nome = "Quebra Vento Palmeiras Premium Masculino",
                Descricao = @"A versão Premium eleva o conceito de proteção e estilo. Com materiais de maior durabilidade e detalhes exclusivos, este quebra-vento foi desenvolvido para o torcedor que exige o melhor em tudo, inclusive na forma de mostrar amor pelo Palmeiras. Leve, resistente e com identidade alviverde em cada costura.",
                ValorCusto = 184.95m,
                ValorVenda = 369.90m,
                Qtde = 42,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/4.png"
            },
            new() {
                Id = 21,
                CategoriaId = 3,
                Nome = "Blusa Corta Vento Palmeiras Puma 25/26",
                Descricao = @"Tecnologia de ponta aliada ao escudo mais vitorioso do Brasil. Desenvolvida pela Puma para a temporada 25/26, esta blusa corta-vento combina desempenho técnico com visual arrojado, sendo utilizada pelo próprio elenco nos aquecimentos e na entrada em campo. Para quem quer sentir de perto o que os atletas vestem.",
                ValorCusto = 474.95m,
                ValorVenda = 949.90m,
                Qtde = 10,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/5.png"
            },
            new() {
                Id = 22,
                CategoriaId = 3,
                Nome = "Jaqueta Palmeiras Puma",
                Descricao = @"Clássica e atemporal, esta jaqueta Puma com os símbolos do Palmeiras é uma das peças mais versáteis da coleção. Com corte limpo e acabamento impecável, acompanha qualquer look e transmite paixão pelo clube de forma elegante. Do casual ao esportivo, é a companheira ideal para os dias que pedem mais proteção.",
                ValorCusto = 209.95m,
                ValorVenda = 419.90m,
                Qtde = 48,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/6.png"
            },
            new() {
                Id = 23,
                CategoriaId = 3,
                Nome = "Jaqueta Casual Palmeiras Puma 24/25",
                Descricao = @"Desenvolvida para a temporada 24/25, esta jaqueta casual une o estilo urbano ao universo do futebol com muita personalidade. Com design contemporâneo e detalhes que remetem ao clube, é a peça certa para o torcedor que não quer escolher entre moda e paixão pelo Verdão. Confortável, estilosa e inconfundível.",
                ValorCusto = 239.95m,
                ValorVenda = 479.90m,
                Qtde = 35,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/7.png"
            },
            new() {
                Id = 24,
                CategoriaId = 3,
                Nome = "Jaqueta Palmeiras Casual Hoody 23/24",
                Descricao = @"Com capuz e visual urbano, esta jaqueta da temporada 23/24 é para quem quer levar o Palmeiras para qualquer lugar com estilo. O design hoodie garante conforto e proteção, enquanto os detalhes alviverde afirmam a identidade do torcedor onde quer que ele esteja. Uma peça premium que mistura streetwear e paixão pelo clube.",
                ValorCusto = 299.95m,
                ValorVenda = 599.90m,
                Qtde = 22,
                Destaque = true,
                Foto = "/img/Produtos/Jaquetas-Casacos/8.png"
            },

            // ========= ACESSÓRIOS ==========

            new() {
                Id = 25,
                CategoriaId = 4,
                Nome = "Mochila Palmeiras Puma 24/25",
                Descricao = @"Funcional e com a cara do Verdão. A mochila da temporada 24/25 foi desenvolvida para atender às demandas do dia a dia sem abrir mão do estilo. Com compartimentos organizados, alças ergonômicas e os símbolos do Palmeiras estampados com orgulho, é a companheira ideal para treinos, viagens ou a rotina do torcedor apaixonado.",
                ValorCusto = 164.95m,
                ValorVenda = 329.90m,
                Qtde = 60,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/1.png"
            },
            new() {
                Id = 26,
                CategoriaId = 4,
                Nome = "Mochila Porta Notebook Tradicional do Palmeiras",
                Descricao = @"Proteção para o que importa, com a identidade de quem você torce. Esta mochila com compartimento exclusivo para notebook une praticidade profissional e amor pelo Palmeiras em um único produto. Com acabamento resistente e design clean, é a escolha perfeita para quem quer carregar o clube até o ambiente de trabalho.",
                ValorCusto = 144.95m,
                ValorVenda = 289.90m,
                Qtde = 52,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/2.png"
            },
            new() {
                Id = 27,
                CategoriaId = 4,
                Nome = "Bolsa Palmeiras Puma 24/25",
                Descricao = @"Leve, prática e perfeita para a rotina. A bolsa Palmeiras Puma 24/25 foi criada para acompanhar o torcedor em atividades do dia a dia, treinos e deslocamentos rápidos. Seu formato compacto facilita o transporte dos itens essenciais, enquanto os detalhes oficiais do clube reforçam a paixão pelo Verdão em qualquer ocasião.",
                ValorCusto = 74.95m,
                ValorVenda = 149.99m,
                Qtde = 90,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/3.png"
            },
            new() {
                Id = 28,
                CategoriaId = 4,
                Nome = "Bolsa Saco Palmeiras Puma 26/27",
                Descricao = @"Versátil e moderna, a bolsa saco Palmeiras Puma 26/27 é ideal para quem busca praticidade sem abrir mão do estilo. Leve e fácil de transportar, ela oferece espaço suficiente para itens essenciais de treinos, caminhadas ou atividades cotidianas. O design esportivo e os detalhes oficiais do Palmeiras transformam este acessório em uma demonstração de orgulho alviverde.",
                ValorCusto = 74.95m,
                ValorVenda = 149.99m,
                Qtde = 85,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/6.png"
            },
            new() {
                Id = 29,
                CategoriaId = 4,
                Nome = "Bolsa Sport do Palmeiras",
                Descricao = @"Desenvolvida para acompanhar o ritmo do torcedor ativo. A Bolsa Sport combina espaço generoso com leveza e resistência, sendo perfeita para treinos, academias ou passeios. Com alças confortáveis e o símbolo do Verdão estampado, é uma peça que comunica paixão pelo clube em qualquer situação.",
                ValorCusto = 113.95m,
                ValorVenda = 227.90m,
                Qtde = 70,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/4.png"
            },
            new() {
                Id = 30,
                CategoriaId = 4,
                Nome = "Bolsa Média de Viagem Esportiva do Palmeiras",
                Descricao = @"Para o torcedor que viaja com o clube no coração. Esta bolsa média de viagem foi pensada para acomodar o necessário de forma organizada, com compartimentos práticos e estrutura robusta. O visual esportivo aliado aos elementos do Palmeiras fazem dela a companheira perfeita para quem não quer deixar o Verdão em casa.",
                ValorCusto = 134.95m,
                ValorVenda = 269.90m,
                Qtde = 45,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/5.png"
            },
            new() {
                Id = 31,
                CategoriaId = 4,
                Nome = "Mala Palmeiras Puma 26/27",
                Descricao = @"Espaço, resistência e identidade em uma única peça. A mala Palmeiras Puma 26/27 foi desenvolvida para acompanhar viagens, treinos e compromissos esportivos com total praticidade. Com amplo compartimento interno e acabamento de qualidade, oferece organização e conforto para transportar seus pertences enquanto demonstra sua paixão pelo Verdão.",
                ValorCusto = 274.95m,
                ValorVenda = 549.99m,
                Qtde = 25,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/7.png"
            },
            new() {
                Id = 32,
                CategoriaId = 4,
                Nome = "Mala Bordo 360 Vega Palmeiras 20",
                Descricao = @"Viajar com o Palmeiras onde quer que você vá. A mala Bordo 360 Vega é a escolha premium para o torcedor que combina qualidade e identidade até nas viagens mais longas. Com rodas 360° para máxima mobilidade, estrutura rígida e capacidade generosa, ela é tão resistente e confiável quanto o clube que representa.",
                ValorCusto = 329.95m,
                ValorVenda = 659.90m,
                Qtde = 8,
                Destaque = true,
                Foto = "/img/Produtos/Mochilas-Bagagens/8.png"
            },
        ];
        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}