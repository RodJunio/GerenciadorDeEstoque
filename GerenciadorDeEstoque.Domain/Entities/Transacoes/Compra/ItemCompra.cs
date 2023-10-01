namespace GerenciadorDeEstoque.Domain.Entities.Transacoes.Compra;
using Produto;

public class ItemCompra
{
    public int ID { get; set; }
    public Produto Produto { get; set; } // Use a classe Produto para representar o produto adquirido
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }


    public decimal TotalItem => Quantidade * PrecoUnitario;
}

