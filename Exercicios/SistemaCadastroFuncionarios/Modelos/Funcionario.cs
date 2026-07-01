using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios.Modelos
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Tipo { get; set; }

        public virtual double CalcularSalario()
        {
            return 0;
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Salário: R${CalcularSalario():F2}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
        }
    }
}
