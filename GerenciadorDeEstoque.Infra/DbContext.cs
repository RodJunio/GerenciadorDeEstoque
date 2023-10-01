using GerenciadorDeEstoque.Domain.Entities.Categoria;
using GerenciadorDeEstoque.Domain.Entities.Fornecedor;
using GerenciadorDeEstoque.Domain.Entities.Produto;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeEstoque.Infra;

public class EstoqueContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Fornecedor> Forcenecedores { get; set; }
}
