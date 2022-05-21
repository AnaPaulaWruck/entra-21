using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio04
    {
        public void Executar()
        {
            Console.Clear();
            /*
                4. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
                conter 4 notas.
                Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
                vetor, realize a média destas notas e apresente.
            */

            Console.Write("Nome da disciplina: ");
            string disciplina = Console.ReadLine();

            double[] notas = new double[4];
            double somaNotas = 0;

            for (var i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                somaNotas += notas[i];
            }

            Console.WriteLine($"Média final em {disciplina}: {(somaNotas / notas.Length)}");
        }
    }
}
