namespace OrientacaoAObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar pessoas
            Pessoa pessoa1 = new Pessoa(
                nome:"Guilherme",
                dataNascimento:new DateOnly(2004, 7, 16),
                cpf: "12345678901",
                altura: 1.75,
                ativo:true
                );

            MostrarInformacoes.Pessoa(pessoa1);
            pessoa1.SeComunicar();
            Console.WriteLine("");

            Pessoa pessoa2 = new Pessoa(
                nome: "João",
                dataNascimento: new DateOnly(1990, 4, 22),
                cpf: "adpowdmao",
                altura: 1.80,
                ativo: false
                );

            MostrarInformacoes.Pessoa(pessoa2);
            pessoa2.SeComunicar();
            Console.WriteLine("");


            // Criar cachorros
            Cachorro cachorro1 = new Cachorro(
                nome: "Rex",
                raca: "Buldogue",
                dataNascimento: new DateOnly(2023, 3, 12),
                status: "Saudável",
                adestrado: false,
                vacinado: false
                );

            MostrarInformacoes.Cachorro(cachorro1);
            cachorro1.Latir();
            Console.WriteLine("");

            Cachorro cachorro2 = new Cachorro(
                nome: "Max",
                raca: "Pastor-alemão",
                dataNascimento: new DateOnly(2021, 2, 25),
                status: "Saudável",
                adestrado: true,
                vacinado: true
                );

            MostrarInformacoes.Cachorro(cachorro2);
            Console.WriteLine("");


            // Criar produtos
            Produto produto1 = new Produto(
                nome: "Mouse Logitech G203",
                marca: "Logitech",
                preco: 98.99,
                descricao: "Sensor de 8.000 DPI - O sensor de nível avançado para jogos responde com precisão aos seus movimentos. Personalize as configurações para se adequar à sensibilidade que você gosta com o software de jogos Logitech G HUB e alterne facilmente até 5 configurações de DPI.",
                emEstoque: true,
                quantidadeEstoque: 120
                );

            MostrarInformacoes.Produto(produto1);
            Console.WriteLine("");

            Produto produto2 = new Produto(
                nome: "Air Cooler DeepCool AG620",
                marca: "DeepCool",
                preco: 299.99,
                descricao: "Double tower air cooler",
                emEstoque: true,
                quantidadeEstoque: 59
                );

            MostrarInformacoes.Produto(produto2);
            Console.WriteLine("");

            // Criar pedidos
            Pedido pedido1 = new Pedido(
                cliente: pessoa1,
                produtos: [produto1, produto2],
                dataDoServico: DateTime.Now
                );

            MostrarInformacoes.Pedido(pedido1);
            Console.WriteLine("");
        }
    }
}
