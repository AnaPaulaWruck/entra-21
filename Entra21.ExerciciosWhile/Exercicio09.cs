using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            // Solicite um número e faça o fatorial deste número, utilizando while.
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int auxNumero = numero - 1;
            int contador = numero;
            int fatorialNumero = numero;

            if (numero == 0)
            {
                Console.WriteLine("Fatorial de " + numero + " = 1");
            }
            else
            {
                while ((contador > 0) && (auxNumero != 1))
                {
                    fatorialNumero = fatorialNumero * auxNumero;
                    auxNumero = auxNumero - 1;
                    contador = contador - 1;
                }
                Console.WriteLine("Fatorial de " + numero + " = " + fatorialNumero);
            }
        }
    }
}
