using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

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
                Descricao = @"texto", // "@" --> para ter certeza que tudo dentro é texto
                ValorCusto = 1,
                ValorVenda = 379.99m, // "m" --> monetário (para números decimais)
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 26/27",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 379.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 3,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 25/26",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 249.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 4,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 25/26",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 249.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 5,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma III 25/26",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 429.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 6,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma I 24/25",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 249.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 7,
                CategoriaId = 1,
                Nome = "Camisa Palmeiras Puma II 24/25",
                Descricao = @"texto",
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
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

            // ========= RETRÔ ==========

            new() {
                Id = 9,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1959",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 10,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1959",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 11,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Retrô 1972",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 12,
                CategoriaId = 2,
                Nome = "Camiseta Palmeiras Retrô 1994 Juvenil",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 13,
                CategoriaId = 2,
                Nome = "Camiseta Masculina Palmeiras Flame Retrô 1959",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 14,
                CategoriaId = 2,
                Nome = "Camisa Palmeiras Retrô 1999 Masculina",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 15,
                CategoriaId = 2,
                Nome = "Camiseta Palmeiras Marcos Retrô 1999 Masculina",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 16,
                CategoriaId = 2,
                Nome = "Camisa Palmeiras Retrô 1989 Masculina",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

            // ========= JAQUETAS E CASACOS ==========

            new() {
                Id = 17,
                CategoriaId = 3,
                Nome = "Agasalho Palmeiras Alive Masculino",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 18,
                CategoriaId = 3,
                Nome = "Agasalho Palmeiras Savoia Masculino",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 19,
                CategoriaId = 3,
                Nome = "Quebra Vento Palmeiras Torcedor Masculino",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 20,
                CategoriaId = 3,
                Nome = "Jaqueta Palmeiras Puma",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 21,
                CategoriaId = 3,
                Nome = "Quebra Vento Palmeiras Premium Masculino",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 22,
                CategoriaId = 3,
                Nome = "Jaqueta Palmeiras Puma 24/25",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 23,
                CategoriaId = 3,
                Nome = "Blusa Corta Vento Palmeiras Puma 25/26",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 24,
                CategoriaId = 3,
                Nome = "Jaqueta Palmeiras Casual Hoody 23/24",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

            // ========= ACESSÓRIOS ==========

            new() {
                Id = 25,
                CategoriaId = 4,
                Nome = "Boné Treino Verde Palmeiras Puma 24/25",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 26,
                CategoriaId = 4,
                Nome = "Boné Casual Palmeiras Puma",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 27,
                CategoriaId = 4,
                Nome = "Mochila Palmeiras Puma 24/25",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 28,
                CategoriaId = 4,
                Nome = "Bolsa Palmeiras Puma 24/25",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 29,
                CategoriaId = 4,
                Nome = "Mochila Porta Notebook Tradicional do Palmeiras",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 30,
                CategoriaId = 4,
                Nome = "Bolsa Sport do Palmeiras",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 31,
                CategoriaId = 4,
                Nome = "Bolsa Média de Viagem Esportiva do Palmeiras",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            new() {
                Id = 32,
                CategoriaId = 4,
                Nome = "Mala Bordo 360 Vega Palmeiras 20 - Verde",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
        ];
        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}