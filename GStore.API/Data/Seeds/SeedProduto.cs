namespace GStore.API.Data.Seeds;

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
                Descrição = @"texto", // "@" --> para ter certeza que tudo dentro é texto
                ValorCusto = 1,
                ValorVenda = 1.99m, // "m" --> monetário (para números decimais)
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 26/27",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 3,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 25/26",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 4,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 25/26",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 5,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma III 25/26",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 6,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 24/25",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 7,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 24/25",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 8,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma III 24/25",
                Descrição = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            // ========= RETRÔ ==========

            // ========= JAQUETAS E CASACOS ==========

            // ========= ACESSÓRIOS ==========
        ];
        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}