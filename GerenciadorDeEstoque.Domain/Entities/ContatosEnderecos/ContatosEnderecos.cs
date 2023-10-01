namespace GerenciadorDeEstoque.Domain.Entities.ContatosEnderecos;

public class ContatosEnderecos
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
    }

    public class Contato
    {
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
    }
}
