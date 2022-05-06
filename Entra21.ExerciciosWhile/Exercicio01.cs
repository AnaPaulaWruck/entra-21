using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;
            while (indice < 13)
            {
                Console.Write("Nome da peça " + (indice + 1) + ": ");
                string nomePeca = Console.ReadLine();
                Console.Write("Valor da peça " + (indice + 1) + ": R$ ");
                double valorPeca = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
            }
        }
    }
}
