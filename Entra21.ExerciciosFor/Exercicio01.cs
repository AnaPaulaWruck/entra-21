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
            var nome = "";
            var preco = 0.0;
            for (var i = 0; i < 3; i++)
            {
                while (nome.Length < 5)
                {
                    Console.Write("Digite o nome da peça: ");
                nome = Console.ReadLine().Trim();
                    Console.Write()
                }
                Console.Write("Digite o valor da peça: R$ ");
                preco = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
