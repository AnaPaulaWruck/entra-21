using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.Clear();
            // 2.Crie um vetor para guardar 10 nomes e apresente os dez nomes.

            string[] nomes = new string[3];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine().Trim();
                while (nomes[i].Length < 6)
                {
                    Console.WriteLine("Nome deve ter mais de 5 caracteres.");
                    Console.Write("Nome: ");
                    nomes[i] = Console.ReadLine().Trim();
                }
            }

            Console.Clear();
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome {i + 1}: {nomes[i]}");
            }
        }
    }
}
