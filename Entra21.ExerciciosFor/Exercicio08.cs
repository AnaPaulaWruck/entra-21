using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            // 8. Solicite um número e apresentar a tabuada do mesmo até 1000.
            Console.Clear();
            var numero = 0;
            while (numero <= 0)
            {
                try
                {
                    Console.Write("Digite o número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero == 0)
                    {
                        Console.WriteLine("Qualquer valor multiplicado por zero será igual a zero. Digite outro valor.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("Digite um número positivo.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor deve ser um número válido.");
                }
            }
            for (var contador = 0; contador <= 1000; contador++)
            {
                var resultado = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + resultado);
            }
        }
    }
}
