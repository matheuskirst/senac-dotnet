namespace CadastroDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine("");
                Console.WriteLine("1. Adicionar um aluno");
                Console.WriteLine("2. Remover um aluno");
                Console.WriteLine("3. Listar todos alunos");
                Console.WriteLine("4. Encerrar programa");
                Console.WriteLine("");
                string? opcao = Console.ReadLine();

                if (opcao != null && int.TryParse(opcao, out int valorEscolhido))
                {
                    switch (valorEscolhido)
                    {
                        case 1:
                            GerenciarAluno.Cadastrar();
                            break;

                        case 2:
                            GerenciarAluno.Remover();
                            break;

                        case 3:
                            ListarAlunos.Menu();
                            break;
                        default:
                            return;
                    }
                }
            }
        }
    }
}
