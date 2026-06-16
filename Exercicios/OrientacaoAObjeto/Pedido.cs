namespace OrientacaoAObjeto
{
    internal class Pedido(
        Pessoa cliente,
        IList<Produto> produtos,
        DateTime dataDoServico,
        string observacao = "Nenhuma.",
        bool pago = false
        )
    {
        public Pessoa Cliente { get; private set; } = cliente;
        public IList<Produto> Produtos { get; private set; } = produtos;
        public double? ValorTotal { get; private set; } = CalcularValorTotal(produtos);
        public DateTime DataDoServico { get; private set; } = dataDoServico;
        public string Observacao { get; private set; } = observacao;
        public bool IsPago { get; private set; } = pago;
        
        public static double CalcularValorTotal(IList<Produto> produtos)
        {
            double valorTotal = 0.00;
            foreach (var item in produtos)
            {
                valorTotal += item.Preco;
            }
            return valorTotal;
        }
    }
}
