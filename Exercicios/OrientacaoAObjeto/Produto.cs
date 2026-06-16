namespace OrientacaoAObjeto
{
    internal class Produto(
        string nome,
        string marca,
        double preco,
        string descricao,
        bool emEstoque,
        int quantidadeEstoque
        )
    {
        public string Nome { get; set; } = nome;
        public string Marca { get; set; } = marca;
        public double Preco { get; set; } = preco;
        public string Decricao { get; set; } = descricao;
        public bool EmEstoque { get; set;} = emEstoque;
        public int QuantidadeEstoque { get; set; } = quantidadeEstoque;
    }
}
