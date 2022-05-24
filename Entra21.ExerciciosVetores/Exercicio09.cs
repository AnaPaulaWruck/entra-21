using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.Clear();
            // 1 - Criar um vetor para armazenar 10 números, solicite os números e armazene. Será aceito
            // neste vetor somente números pares.

            int[] numeros = new int[3];

            for (var i = 0; i < numeros.Length; i++)
            {
                bool numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Digite um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        numeroValido = true;
                        if (numeros[i] % 2 != 0)
                        {
                            Console.WriteLine("Número digitado deve ser par.");
                            Console.Write("Digite um número: ");
                            numeros[i] = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite um valor válido para número.");
                    }
                }
            }

            // Apresentar o vetor com números pares
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i + 1}º número par: {numeros[i]}");
            }
        }
    }
}
