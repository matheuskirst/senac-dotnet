namespace OrientacaoAObjeto
{
    internal class Pedido
    {
        public Pedido(Pessoa cliente, IList<Produto> produtos, DateTime dataDoServico)
    {
            Cliente = cliente;
            DataDoServico = dataDoServico;
            Produtos = produtos;
            ValorTotal = CalcularValorTotal(produtos);
        }

        public Pedido(Pessoa cliente,
            DateTime dataDoServico,
            IList<Produto> produtos,
            string observacao = "Nenhuma",
            bool isPago = false
            )
    {
            Cliente = cliente;
            DataDoServico = dataDoServico;
            Produtos = produtos;
            ValorTotal = CalcularValorTotal(produtos);
            Observacao = observacao;
            IsPago = isPago;
    }

        public Pessoa Cliente { get; private set; }
        public DateTime DataDoServico { get; private set; }
        public IList<Produto> Produtos { get; private set; }
        public double? ValorTotal { get; private set; }
        public string? Observacao { get; set; }
        public bool IsPago { get; set; }
        
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
