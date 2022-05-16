using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            // Solicite o preço e nome da peça de 13 peças.
            Console.Clear();

            for (var i = 0; i < 13; i++)
            {
                Console.Write("Digite o nome da peça: ");
                var nome = Console.ReadLine().Trim();
                while (nome.Length < 5)
                {
                    Console.WriteLine("Nome da peça deve ter mais de 4 caracteres.");
                    Console.Write("Digite o nome da peça: ");
                    nome = Console.ReadLine().Trim();
                }
                var preco = 0.0;
                while (preco <= 0)
                {
                    try
                    {
                        Console.Write("Digite o valor da peça: R$ ");
                        preco = Convert.ToDouble(Console.ReadLine());
                        if (preco < 0)
                        {
                            Console.WriteLine("Valor não pode ser negativo.");
                        }
                        else if (preco == 0)
                        {
                            Console.WriteLine("Valor não pode ser zero.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado não é um número válido.");
                    }
                }
            }
        }
    }
}
