using SistemaCadastroFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios
{
    internal class CadastrarFuncionario
    {
        public static void Cadastrar(List<Funcionario> cadastrados)
        {
            Console.Clear();
            Console.WriteLine("-- Cadastrar Funcionário --");
            Console.WriteLine("");
            Console.WriteLine("Selecione o tipo de funcionário:");
            Console.WriteLine("1: CLT");
            Console.WriteLine("2: Estagiário");
            Console.WriteLine("3: Terceirizado");
            string? tipoFuncionario = Console.ReadLine();
            if (int.TryParse(tipoFuncionario, out var tipo))
            {
                switch (tipo)
                {
                    case 1:
                        var funcionarioClt = CadastrarClt();
                        if (funcionarioClt != null)
                        {
                            cadastrados.Add(funcionarioClt);
                        }
                        break;
                    case 2:
                        var funcionarioEstagiario = CadastrarEstagiario();
                        if (funcionarioEstagiario != null)
                        {
                            cadastrados.Add(funcionarioEstagiario);
                        }
                        break;
                    case 3:
                        var funcionarioTerceirizado = CadastrarTerceirizado();
                        if (funcionarioTerceirizado != null)
                        {
                            cadastrados.Add(funcionarioTerceirizado);
                        }
                        break;
                }
            }
        }
        public static FuncionarioClt? CadastrarClt()
        {
            try
            {
                string tipoContrato = "CLT";
                Console.Clear();
                Console.WriteLine("-- Cadastrar Funcionário CLT --");
                Console.WriteLine("Digite o nome do funcionário:");
                string? nomeFuncionario = Console.ReadLine();
                if (nomeFuncionario == null)
                {
                    throw new Exception();
                }

                Console.WriteLine("Digite o CPF do funcionário:");
                string? cpfFuncionario = Console.ReadLine();
                if (cpfFuncionario == null || cpfFuncionario.Length != 11)
                {
                    throw new Exception();
                }

                Console.WriteLine("Salário:");
                string? salarioFuncionario = Console.ReadLine();

                double salario = double.Parse(salarioFuncionario);

                var funcionarioClt = new FuncionarioClt(
                    nome: nomeFuncionario,
                    cpf: cpfFuncionario,
                    salarioBase: salario,
                    tipo: tipoContrato
                    );
                return funcionarioClt;
            }
            catch
            {
                Console.WriteLine("Erro ao cadastrar funcionário.");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                return null;
            }
        }
        public static FuncionarioEstagiario? CadastrarEstagiario()
        {
            try
            {
                string tipoContrato = "Estagiário";
                Console.Clear();
                Console.WriteLine("-- Cadastrar Estagiário --");
                Console.WriteLine("Digite o nome do estagiário:");
                string? nomeEstagiario = Console.ReadLine();
                if (nomeEstagiario == null)
                {
                    throw new Exception();
                }
                Console.WriteLine("Digite o CPF do estagiário:");
                string? cpfEstagiario = Console.ReadLine();
                if (cpfEstagiario == null || cpfEstagiario.Length != 11)
                {
                    throw new Exception();
                }

                Console.WriteLine("Valor da bolsa auxílio:");
                string? bolsaEstagiario = Console.ReadLine();

                double bolsa = double.Parse(bolsaEstagiario);

                Console.WriteLine("Valor do vale transporte:");
                string? valeEstagiario = Console.ReadLine();

                double vale = double.Parse(valeEstagiario);

                var funcionarioEstagiario = new FuncionarioEstagiario(
                    nome: nomeEstagiario,
                    cpf: cpfEstagiario,
                    bolsaAuxilio: bolsa,
                    valeTransporte: vale,
                    tipo: tipoContrato
                    );
                return funcionarioEstagiario;
            }
            catch
            {
                Console.WriteLine("Erro ao cadastrar estagiário.");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                return null;
            }
        }
        public static FuncionarioTerceirizado? CadastrarTerceirizado()
        {
            try
            {
                string tipoContrato = "Terceirizado";
                Console.Clear();
                Console.WriteLine("-- Cadastrar Funcionário Terceirizado --");
                Console.WriteLine("Digite o nome do funcionário:");
                string? nomeFuncionario = Console.ReadLine();
                if (nomeFuncionario == null)
                {
                    throw new Exception();
                }

                Console.WriteLine("Digite o CPF do funcionário:");
                string? cpfFuncionario = Console.ReadLine();
                if (cpfFuncionario == null || cpfFuncionario.Length != 11)
                {
                    throw new Exception();
                }

                Console.WriteLine("Valor por hora:");
                string? valor = Console.ReadLine();

                double valorHora = double.Parse(valor);

                Console.WriteLine("Quantidade de horas trabalhadas:");
                string? horas = Console.ReadLine();

                double horasTrabalhadas = double.Parse(horas);

                var funcionarioClt = new FuncionarioTerceirizado(
                    nome: nomeFuncionario,
                    cpf: cpfFuncionario,
                    valorHora: valorHora,
                    horasTrabalhadas: horasTrabalhadas,
                    tipo: tipoContrato
                    );
                return funcionarioClt;
            }
            catch
            {
                Console.WriteLine("Erro ao cadastrar funcionário");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                return null;
            }
        }
    }
}
