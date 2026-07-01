using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios.Modelos
{
    internal class FuncionarioClt : Funcionario
    {
        public FuncionarioClt(
            string nome,
            string cpf,
            string tipo,
            double salarioBase=1621.00
            )
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            SalarioBase = salarioBase;
        }
        public double SalarioBase { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
