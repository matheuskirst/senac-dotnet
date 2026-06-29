namespace ImparOuPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App();
        }
        public static void App()
        {
            while (true)
            {
                Console.WriteLine("--- Impar ou Par ---");
                Console.WriteLine("Digite um número:");
                string? inputNumero = Console.ReadLine();

                if (inputNumero != null)
                {
                    try
                    {
                        int numero = int.Parse(inputNumero);
                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("O número é par.");
                        }
                        else
                        {
                            Console.WriteLine("O número é ímpar.");
                        }
                    }
                    catch {
                        Console.WriteLine("Valor inválido.");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
