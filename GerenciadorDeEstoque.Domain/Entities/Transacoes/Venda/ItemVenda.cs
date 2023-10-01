namespace GerenciadorDeEstoque.Domain.Entities.Transacoes.Venda;
using Produto;
public class ItemVenda
{
    public int ID { get; set; }
    public Produto Produto { get; set; } // Use a classe Produto para representar o produto vendido
    public int QuantidadeVendida { get; set; }
    public decimal PrecoUnitario { get; set; }

   
    public decimal TotalItem => QuantidadeVendida * PrecoUnitario;
}

