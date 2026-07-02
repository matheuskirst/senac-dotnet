using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Modelos
{
    public class Aluno
    {
        public Aluno(string nome, DateTime dataNascimento, string cpf, Guid matricula)
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            Cpf = cpf;
            Matricula = matricula;
        }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public Guid Matricula { get; set; }
        public void exibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataDeNascimento}");
            Console.WriteLine($"CPF: {Cpf}");
        }
    }
}
