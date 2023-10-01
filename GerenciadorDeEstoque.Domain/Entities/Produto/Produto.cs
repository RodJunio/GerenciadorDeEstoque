namespace GerenciadorDeEstoque.Domain.Entities.Produto;

public class Produto
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string CodigoDeBarras { get; set; }
    public decimal PrecoVenda { get; set; }
    public decimal PrecoCusto { get; set; }
    public int EstoqueQtd { get; set; }
    public int QtdMinimaEstoque { get; set; }
    public int Categoria { get; set; } //incluir Enum
    public string Fornecedor { get; set; }
    public string Lote { get; set; }
    public string UrlImagem { get; set; }
    public DateTime DataInclusao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
