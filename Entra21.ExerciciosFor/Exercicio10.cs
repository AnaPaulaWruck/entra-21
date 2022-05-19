using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            /*
            10.Solicite um número e apresente:
            ● Os 50 números antecessores pares;
            ● Os 50 números sucessores ímpares
            */
            Console.Clear();

            var numeroValido = false;
            while (numeroValido == false)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    var numero = Convert.ToInt32(Console.ReadLine());
                    numeroValido = true;
                    int indicePar = numero - 1, indiceImpar = numero + 1;

                    Console.WriteLine("Lista dos 50 sucessores ímpares: ");
                    for (var i = 0; i < 100; i++)
                    {
                        if (indiceImpar % 2 != 0)
                        {
                            Console.WriteLine(indiceImpar);
                        }
                        indiceImpar++;
                    }

                    Console.WriteLine("Lista dos 50 antecessores pares: ");
                    for (var j = 0; j < 100; j++)
                    {
                        if (indicePar % 2 == 0)
                        {
                            Console.WriteLine(indicePar);
                        }
                        indicePar--;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor digitado não é um inteiro válido.");
                }
            }
        }
    }
}
