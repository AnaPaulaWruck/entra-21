using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio07
    {
        public void Executar()
        {
            Console.Clear();
            // 7. Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura.

            int quantidadeCadastros = 4;
            string[] animais = new string[quantidadeCadastros];
            double[] alturas = new double[quantidadeCadastros];
            double menorAltura = double.MaxValue;
            string animalMenorAltura = "";

            for (var i = 0; i < quantidadeCadastros; i++)
            {
                Console.Write($"Animal {i + 1}: ");
                animais[i] = Console.ReadLine().Trim();
                Console.Write("Altura: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                    animalMenorAltura = animais[i];
                }
            }
            Console.WriteLine($"\nO animal com menor altura é o {animalMenorAltura} com {menorAltura}m.");
        }
    }
}
