namespace ExercicioContador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contador de 1 a 10
            // - Exibir na tela um contador de 1 a 10 e a raiz quadrada de cada número com 2 casas decimais
            for (int i = 1; i <= 10; i++)
            {
                double raiz = Math.Sqrt(i);
                double raizFormatada = Math.Round(raiz, 2);
                Console.WriteLine($"Número: {i}, Raiz: {raizFormatada:F2}"); // Ou raizFormatada.ToString("0.00")
            }
        }
    }
}
