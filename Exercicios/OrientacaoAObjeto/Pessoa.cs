namespace OrientacaoAObjeto
{
    public class Pessoa : Animal
    {
        public Pessoa (
            string nome,
            DateTime dataNascimento,
            string cpf,
            double? altura = null,
            string? rg = null,
            string? telefone = null,
            string? email = null,
            bool ativo = true
            )
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CalcularIdade();
            Altura = altura;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            IsAtivo = ativo;
        }
        public string? Cpf { get; private set; }
        public string? Rg { get; private set; }
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }

        public override void SeComunicar()
        {
            Console.WriteLine($"Ola! Meu nome é {Nome}!");
        }
    }
}
