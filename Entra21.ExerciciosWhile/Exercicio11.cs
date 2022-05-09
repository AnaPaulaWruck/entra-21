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
            int numero1 = 0, numero2 = 0;
            int opcaoSelecionada = 0;

            while (opcaoSelecionada != 5)
            {
                Console.Write("\nDigite o 1º número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o 2º número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEscolha a operação desejada:");
                Console.WriteLine(@"
    OPÇÃO | OPERAÇÃO
      1   | Somar
      2   | Subtrair
      3   | Multiplicar
      4   | Dividir
      5   | Sair");

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
