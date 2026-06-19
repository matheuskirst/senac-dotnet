namespace Calculadora
{
    internal class Calcular
    {
        public static float Somar(float numeroUm, float numeroDois)
        {
            return numeroUm + numeroDois;
        }
        public static float Subtrair(float numeroUm, float numeroDois)
        {
            return numeroUm - numeroDois;
        }
        public static float Multiplicar(float numeroUm, float numeroDois)
        {
            return numeroUm * numeroDois;
        }
        public static float Dividir(float numeroUm, float numeroDois)
        {
            if (numeroUm == 0 || numeroDois == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return numeroUm / numeroDois;
        }
    }
}
