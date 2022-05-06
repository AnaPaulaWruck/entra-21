using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            // Solicite um número e apresentar a tabuada do mesmo até 1000.
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int multiplicadorTabuada = 0;
            
            while (multiplicadorTabuada <= 1000)
            {
                int resultado = numero * multiplicadorTabuada;
                Console.WriteLine(numero + " x " + multiplicadorTabuada + " = " + resultado);
                multiplicadorTabuada = multiplicadorTabuada + 1;
            }
        }
    }
}
