using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.Clear();
            // 3. Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o
            // nome e preço dos sete produtos

            int quantidadeParaCadastrar = 7;
            string[] nomesProdutos = new string[quantidadeParaCadastrar];
            double[] precosProdutos = new double[quantidadeParaCadastrar];

            for (var i = 0; i < quantidadeParaCadastrar; i++)
            {
                Console.Clear();
                Console.Write($"Nome do produto: ");
                nomesProdutos[i] = Console.ReadLine().Trim();
                Console.Write($"Preço: R$ ");
                precosProdutos[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Clear();
            for (var i = 0; i < quantidadeParaCadastrar; i++)
            {
                Console.WriteLine($"Nome produto {i + 1}: {nomesProdutos[i]}\nPreço: R$ {precosProdutos[i].ToString("F")}\n");
            }

        }
    }
}
