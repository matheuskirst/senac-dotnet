namespace SistemaDeLogin.utils
{
    internal class DataHora
    {
        public static string Saudacoes()
        {
            DateTime dataAtual = DateTime.Now;
            string periodo = dataAtual.Hour switch
            {
                >= 5 and < 12 => "Bom dia",
                >= 12 and < 17 => "Boa tarde",
                >= 17 and < 21 => "Boa noite",
                _ => "Boa noite",
            };
            return periodo;
        }
    }
}
