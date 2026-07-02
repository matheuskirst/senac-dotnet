using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeAlunos.Modelos;

namespace CadastroDeAlunos
{
    public class AlunosCadastrados
    {
        static List<Aluno> alunosCadastrados = [];
        public static void adicionarAluno(Aluno aluno)
        {
            alunosCadastrados.Add(aluno);
        }
        public static void removerAluno(string cpf)
        {

        }
    }
}
