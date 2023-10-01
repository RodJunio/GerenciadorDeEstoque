using static GerenciadorDeEstoque.Domain.Entities.ContatosEnderecos.ContatosEnderecos;

namespace GerenciadorDeEstoque.Domain.Entities.Transacoes.Venda;
using Cliente;
public class Venda
{
    public int ID { get; set; }
    public Cliente Cliente { get; set; } // Use a classe Cliente para representar o cliente que fez a compra
    public DateTime DataVenda { get; set; }
    public string NumeroFatura { get; set; }
    public List<ItemVenda> ProdutosVendidos { get; set; } // Lista de produtos vendidos
    public decimal TotalVenda { get; set; }
    public string MetodoPagamento { get; set; }
    public string StatusVenda { get; set; }
    public Endereco EnderecoEntrega { get; set; } // Use a classe Endereco para representar o endereço de entrega
    public string Observacoes { get; set; }
}

