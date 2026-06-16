namespace LacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Exemplo FOR ---");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Número: {i}");
            }

            Console.WriteLine("");
            Console.WriteLine("--- Exemplo WHILE ---");
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            Console.WriteLine("");
            Console.WriteLine("--- Exemplo DO WHILE ---");
            int contadorDoWhile = 1;
            do
            {
                Console.WriteLine($"Contador: {contadorDoWhile}");
                contadorDoWhile++;
            }
            while (contadorDoWhile <= 15);

            Console.WriteLine("");
            Console.WriteLine("--- Exemplo FOR EACH ---");
            string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };
            foreach (var item in frutas)
            {
                Console.WriteLine($"Fruta: {item}");
            }

            Console.WriteLine("");
            Console.WriteLine("--- Exemplo BREAK e CONTINUE ---");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                if (i > 8)
                {
                    break;
                }
                Console.WriteLine($"i: {i}");
            }
        }
    }
}
