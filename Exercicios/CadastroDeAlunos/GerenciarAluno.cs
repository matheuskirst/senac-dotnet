using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeAlunos.Modelos;

namespace CadastroDeAlunos
{
    public class GerenciarAluno
    {
        public static void Cadastrar()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("-- Cadastrar Aluno --");
                Console.WriteLine("");
                
                Console.WriteLine("Nome:");
                Console.WriteLine("");
                string? nome;
                while (true)
                {
                    nome = Console.ReadLine();
                    if (nome != null && nome != "") break;
                    else
                    {

                        Console.Write(new string(' ', Console.WindowWidth));

                        Console.CursorTop--;

                        Console.Write("\rNome inválido! Tente novamente...");

                        Thread.Sleep(1500);

                        Console.Write("\r                                                     \r");
                    }
                }

                Console.WriteLine("Data de nascimento:");
                Console.WriteLine("");
                string? data = Console.ReadLine();

                DateTime dataNascimento = DateTime.Parse(data);

                Console.WriteLine("CPF:");
                Console.WriteLine("");
                string? cpf = Console.ReadLine();

                Guid matricula = new Guid();

                var aluno = new Aluno(
                    nome: nome,
                    dataNascimento: dataNascimento,
                    cpf: cpf,
                    matricula: matricula
                    );
                AlunosCadastrados.adicionarAluno(aluno);
            }
        }
        public static void Remover()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Remover Aluno --");
                Console.WriteLine("");

                string cpf = "";
                AlunosCadastrados.removerAluno(cpf);
            }
        }
    }
}
