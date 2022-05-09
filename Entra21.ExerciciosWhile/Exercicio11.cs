using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            Console.Clear();
            Console.Write("Digite o 1º número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int opcaoSelecionada = 0;

            Console.WriteLine("\nEscolha a operação desejada:");
            Console.WriteLine(@"
    OPÇÃO | OPERAÇÃO
      1   | Somar
      2   | Subtrair
      3   | Multiplicar
      4   | Dividir
      5   | Sair");

            while (opcaoSelecionada != 5)
            {
                Console.Write("\nOpção selecionada: ");
                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
                if (opcaoSelecionada == 1)
                {
                    Console.WriteLine("\n" + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                }
                if (opcaoSelecionada == 2)
                {
                    Console.WriteLine("\n" + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                }
                if (opcaoSelecionada == 3)
                {
                    Console.WriteLine("\n" + numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                }
                if (opcaoSelecionada == 4)
                {
                    Console.WriteLine("\n" + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                }
            }
        }
    }
}
