using static GerenciadorDeEstoque.Domain.Entities.ContatosEnderecos.ContatosEnderecos;

namespace GerenciadorDeEstoque.Domain.Entities.Transacoes.Compra;
using Fornecedor;
public class Compra
{
    public int ID { get; set; }
    public Fornecedor Fornecedor { get; set; }
    public DateTime DataCompra { get; set; }
    public string NumeroFatura { get; set; }
    public List<ItemCompra> ProdutosComprados { get; set; } // Lista de produtos adquiridos
    public decimal TotalCompa { get; set; }
    public string TipoPagamento { get; set; }
    public string StatusCompra { get; set; }
    public Endereco InformacoesEntrega { get; set; }
    public string Observacoes { get; set; }
}
