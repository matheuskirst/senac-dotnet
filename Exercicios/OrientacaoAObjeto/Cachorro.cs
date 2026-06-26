namespace OrientacaoAObjeto
{
    public class Cachorro : Animal
    {
        public Cachorro (
            string nome,
            DateTime dataNascimento,
            string raca,
            string status,
            bool adestrado,
            bool vacinado
            )
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CalcularIdade();
            Raca = raca;
            Status = status;
            IsAdestrado = adestrado;
            IsVacinado = vacinado;
        }
        public string Raca { get; private set; }
        public string Status { get; private set; }
        public bool IsAdestrado { get; private set; }
        public bool IsVacinado { get; private set; }
        public override void SeComunicar()
        {
            Console.WriteLine($"{Nome}: Au Au!");
        }
    }
}
