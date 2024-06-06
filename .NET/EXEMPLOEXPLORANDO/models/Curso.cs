using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOEXPLORANDO.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;

            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }


            // convertendo strings 
            // for (int count = 0; count < Alunos.Count; count++)
            // {
            //     string texto = "Numero " + count + " - " + Alunos[count].NomeCompleto;
            //     Console.WriteLine(texto);
            // }


            // interpolaçao de strings --- a vantagem dela pra concatencao esta no uso de uma unica string para construir a sentença
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Numero {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}