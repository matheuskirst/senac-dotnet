using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios.Modelos
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public FuncionarioTerceirizado(
            string nome,
            string cpf,
            string tipo,
            double horasTrabalhadas,
            double valorHora
            )
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }
        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }
    }
}
