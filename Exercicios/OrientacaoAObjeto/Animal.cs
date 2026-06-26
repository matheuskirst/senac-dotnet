namespace OrientacaoAObjeto
{
    public class Animal
    {
        public string Nome { get; protected set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        public void CalcularIdade()
        {
            Idade = DateTime.Now.Year - DataDeNascimento.Year;
        }
        public double? Altura { get; set; }
        public double Peso { get; set; }
        public bool IsAtivo {  get; set; }

        public virtual void SeComunicar()
        {
            Console.WriteLine("Fala genérica...");
        }
        public virtual void Caminhar()
        {
            Console.WriteLine("Animal caminhando...");
        }
        public virtual void SeAlimentar()
        {
            Console.WriteLine("Animal se alimentando...");
        }
    }
}
