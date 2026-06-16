namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Guilherme";
            string sobrenome = "Walter";
            int idade = 28;
            bool ehProfessor = true;
            double altura = 1.75;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sobrenome: {sobrenome}");
            Console.WriteLine($"Idade: {idade}");
            ExibirEhProfessorEAltura(ehProfessor, altura);

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Nome Completo: {nomeCompleto}");
        }

        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static void ExibirEhProfessorEAltura(bool ehProfessor, double altura)
        {
            Console.WriteLine($"É Professor?: {ehProfessor}");
            Console.WriteLine($"Altura: {altura}");
        }
    }
}