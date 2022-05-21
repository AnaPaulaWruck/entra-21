using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.Clear();
            // 1.Crie um vetor para guardar 16 números inteiros.
            // Preencha todas as posições com números e apresente a soma destes números.

            int[] numeros = new int[16];
            int soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                bool numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Digite um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        soma += numeros[i];
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite um número inteiro válido.");
                    }
                }
            }

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Número {(i + 1)} = {numeros[i]}");
            }

            Console.WriteLine($"\nSoma = {soma}");
        }
    }
}
