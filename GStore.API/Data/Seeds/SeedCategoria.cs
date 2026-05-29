using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nome = "Camisas" },
            new Categoria { Id = 2, Nome = "Retrô" },
            new Categoria { Id = 3, Nome = "Jaquetas e Casacos" },
            new Categoria { Id = 4, Nome = "Acessórios" }
        };

        modelBuilder.Entity<Categoria>().HasData(categorias);
    }
}