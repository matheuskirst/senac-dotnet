namespace OrientacaoAObjeto
{
    internal class MostrarInformacoes
    {
        public static string FormatarCpf(string cpf)
        {
            try
            {
                if (cpf != null && cpf.Length == 11)
                {
                    return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                return "Inválido!";
            }
        }

        public static void Pessoa(Pessoa pessoa)
        {
            Console.WriteLine("--- Informações da Pessoa ---");
            if (pessoa is Pessoa)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Data de nascimento: {pessoa.DataDeNascimento}");
                Console.WriteLine($"Idade: {pessoa.Idade} anos");
                Console.WriteLine($"CPF: {FormatarCpf(pessoa.Cpf)}");
                Console.WriteLine($"É ativo: {(pessoa.isAtivo ? "Sim" : "Não")}");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!");
            }
        }

        public static void Cachorro(Cachorro cachorro)
        {
            Console.WriteLine("--- Informações do Cachorro ---");
            if (cachorro is Cachorro)
            {
                Console.WriteLine($"Nome: {cachorro.Nome}");
                Console.WriteLine($"Raça: {cachorro.Raca}");
                Console.WriteLine($"Data de nascimento: {cachorro.DataNascimento}");
                Console.WriteLine($"Idade: {cachorro.Idade} anos");
                Console.WriteLine($"Status: {cachorro.Status}");
                Console.WriteLine($"Adestrado: {(cachorro.IsAdestrado ? "Sim" : "Não")}");
                Console.WriteLine($"Vacinado: {(cachorro.IsVacinado ? "Sim" : "Não")}");
            }
            else
            {
                Console.WriteLine("Cachorro não encontrado!");
            }
        }

        public static void Produto(Produto produto)
        {
            Console.WriteLine("--- Informações do Produto ---");
            if (produto is Produto)
            {
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Marca: {produto.Marca}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Descrição: {produto.Decricao}");
                Console.WriteLine($"Em estoque?: {(produto.EmEstoque ? "Sim" : "Não")}");
                Console.WriteLine($"Quantidade em estoque: {produto.QuantidadeEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public static void Pedido(Pedido pedido)
        {
            Console.WriteLine("--- Informações do Pedido ---");
            if (pedido is Pedido)
            {
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                string pedidoProdutos = "";
                foreach (Produto produto in pedido.Produtos)
                {
                    pedidoProdutos += $"{produto.Nome} (R$ {produto.Preco:F2})";
                    if (pedido.Produtos.IndexOf(produto) != pedido.Produtos.Count -1)
                    {
                        pedidoProdutos += ", ";
                    }
                }
                Console.WriteLine($"Produtos: {pedidoProdutos}");
                Console.WriteLine($"Data do serviço: {pedido.DataDoServico}");
                Console.WriteLine($"ValorTotal: R$ {pedido.ValorTotal:F2}");
                Console.WriteLine($"Observação: {pedido.Observacao}");
                Console.WriteLine($"Pago?: {(pedido.IsPago ? "Sim" : "Não")}");
            }
            else
            {
                Console.WriteLine("Pedido não encontrado!");
            }
        }
    }
}
