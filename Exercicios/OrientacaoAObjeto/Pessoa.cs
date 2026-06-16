namespace OrientacaoAObjeto
{
    internal class Pessoa(
            string nome,
            DateOnly dataNascimento,
            string cpf,
            double? altura = null,
            string? rg = null,
            string? telefone = null,
            string? email = null,
            bool ativo = true
        )
    {
        public string Nome { get; private set; } = nome;
        public DateOnly DataDeNascimento { get; private set; } = dataNascimento;
        public int Idade { get; private set; } = DateTime.Now.Year - dataNascimento.Year;
        public double? Altura { get; private set; } = altura;
        public string? Cpf { get; private set; } = cpf;
        public string? Rg { get; private set; } = rg;
        public string? Telefone { get; private set; } = telefone;
        public string? Email { get; private set; } = email;
        public bool isAtivo { get; private set; } = ativo;

        public void SeComunicar()
        {
            Console.WriteLine($"Ola! Meu nome é {Nome}!");
        }
    }
}
