using SistemaCadastroFuncionarios.Modelos;

namespace SistemaCadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> cadastrados = [];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Sistema de Cadastro de Funcionários-- ");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1: Cadastrar funcionário");
                Console.WriteLine("2: Listar funcionários");
                Console.WriteLine("3: Sair");
                Console.WriteLine("");
                string? opcao = Console.ReadLine();

                if (opcao != null)
                {
                    Console.Clear();
                    if (int.TryParse(opcao, out int value)){
                        switch (value)
                        {
                            case 1: CadastrarFuncionario.Cadastrar(cadastrados); break;
                            case 2: ListarFuncionarios.ListarTodos(cadastrados); break;
                            default: return;
                        }
                    }
                }
            }
        }
    }
}
