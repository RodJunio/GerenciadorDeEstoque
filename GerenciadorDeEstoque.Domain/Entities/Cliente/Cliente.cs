using GerenciadorDeEstoque.Domain.Entities.Transacoes.Compra;
using static GerenciadorDeEstoque.Domain.Entities.ContatosEnderecos.ContatosEnderecos;

namespace GerenciadorDeEstoque.Domain.Entities.Cliente;

public class Cliente
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public Endereco Endereco { get; set; } // Pode ser outra classe que representa o endereço
    public Contato Contato { get; set; } // Pode ser outra classe que representa informações de contato
    public DateTime DataRegistro { get; set; }
    public List<Compra> HistoricoCompras { get; set; }
}

