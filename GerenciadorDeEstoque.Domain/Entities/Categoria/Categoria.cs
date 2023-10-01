namespace GerenciadorDeEstoque.Domain.Entities.Categoria;

using GerenciadorDeEstoque.Domain.Entities.Produto;
using Produto;
public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string UrlImagem { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public List<Produto> ProdutosRelacionados { get; set; }
}
