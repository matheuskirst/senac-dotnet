using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios.Modelos
{
    internal class FuncionarioEstagiario : Funcionario
    {
        public FuncionarioEstagiario(string nome, string cpf, string tipo, double bolsaAuxilio, double valeTransporte)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            BolsaAuxilio = bolsaAuxilio;
            ValeTransporte = valeTransporte;
        }
        public double BolsaAuxilio { get; set; }
        public double ValeTransporte { get; set; }
        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
        }
    }
}
