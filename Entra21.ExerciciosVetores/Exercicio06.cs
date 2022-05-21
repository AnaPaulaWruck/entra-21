using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.Clear();
            // 6. Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade.

            int[] idades = new int[9];
            int maiorIdade = int.MinValue;
            string pessoaMaiorIdade = "";

            for (var i = 0; i < idades.Length; i++)
            {
                Console.Write($"Digite a idade da pessoa {i + 1}: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    pessoaMaiorIdade = "Pessoa " + (i + 1);
                }
            }

            Console.Clear();
            Console.WriteLine($"A pessoa com a maior idade é a {pessoaMaiorIdade} com {maiorIdade} anos.");
        }
    }
}
