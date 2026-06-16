namespace OrientacaoAObjeto
{
    internal class Cachorro(string nome, string raca, DateOnly dataNascimento, string status, bool adestrado, bool vacinado)
    {
        public string Nome { get; private set; } = nome;
        public string Raca { get; private set; } = raca;
        public DateOnly DataNascimento { get; private set; } = dataNascimento;
        public int Idade { get; private set; } = DateTime.Now.Year - dataNascimento.Year;
        public string Status { get; private set; } = status;
        public bool IsAdestrado { get; private set; } = adestrado;
        public bool IsVacinado { get; private set; } = vacinado;
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au Au!");
        }
    }
}
