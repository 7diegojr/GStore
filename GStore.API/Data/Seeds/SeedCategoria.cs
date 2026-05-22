using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = [
            new() {id = 1, Nome = "Camisas"},
            new() {id = 2, Nome = "Retrô"},
            new() {id = 3, Nome = "Jaquetas e Casacos"},
            new() {id = 4, Nome = "Acessórios"},
        ];
        modelBuilder.Entity<Categoria>().HasData(categorias);
    }
}