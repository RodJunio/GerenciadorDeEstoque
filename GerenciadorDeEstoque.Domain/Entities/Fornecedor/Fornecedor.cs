using static GerenciadorDeEstoque.Domain.Entities.ContatosEnderecos.ContatosEnderecos;

namespace GerenciadorDeEstoque.Domain.Entities.Fornecedor;

using Produto;

public class Fornecedor
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Endereco Endereco { get; set; } // Pode ser outra classe que representa o endereço
    public Contato Contato { get; set; } // Pode ser outra classe que representa informações de contato
    public DateTime DataContrato { get; set; }
    public List<Produto> ProdutosFornecidos { get; set; }
}
