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
            int fatorialNumero = numero;

            while (numero != 0)
            {
                fatorialNumero = fatorialNumero * (numero - 1);
                numero = numero - 1;
            }
            Console.WriteLine("Valor valor");
        }
    }
}
