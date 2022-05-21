using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Clear();
            // 5.Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.

            double[] pesos = new double[5];
            double soma = 0;

            for (var i = 0; i < pesos.Length; i++)
            {
                Console.Write($"Digite o peso {i + 1}: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
                soma += pesos[i];
            }

            Console.Clear();
            Console.WriteLine($"Soma total dos pesos = {soma}\nMédia dos pesos = {soma / pesos.Length}");
        }
    }
}
