using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            // Solicite um número e apresente:
            // - Os 50 números antecessores pares;
            // - Os 50 números sucessores ímpares.

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indicePar = numero - 1, indiceImpar = numero + 1;
            int contadorPar = 0, contadorImpar = 0;

            while (contadorPar < 10)
            {
                if (indicePar % 2 == 0)
                {
                    Console.WriteLine("Numero Par: " + indicePar);
                }
                indicePar = indicePar - 1;
                contadorPar = contadorPar + 1;
            }
            while (contadorImpar < 10)
            {
                if (indiceImpar % 2 != 0)
                {
                    Console.WriteLine("Numero Impar: " + indiceImpar);
                }
                indiceImpar = indiceImpar + 1;
                contadorImpar = contadorImpar + 1;
            }
        }
    }
}
