using SistemaCadastroFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroFuncionarios
{
    internal class ListarFuncionarios
    {
        public static void ListarTodos(List<Funcionario> cadastrados)
        {
            Console.WriteLine("-- Lista de Funcionários --");
            Console.WriteLine("");
            if (cadastrados.Count > 0)
            {
                foreach (Funcionario funcionario in cadastrados)
                {
                    funcionario.ExibirDados();
                }
            }
            else
            {
                Console.WriteLine("Não há funcionários cadastrados.");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
