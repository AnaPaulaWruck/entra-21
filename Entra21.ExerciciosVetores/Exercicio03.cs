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

            int quantidadeParaCadastrar = 3;
            string[] nomesProdutos = new string[quantidadeParaCadastrar];
            double[] precosProdutos = new double[quantidadeParaCadastrar];

            for (var i = 0; i < quantidadeParaCadastrar; i++)
            {
                Console.Write("Nome do produto: ");
                nomesProdutos[i] = Console.ReadLine().Trim();
                while (nomesProdutos[i].Length < 5)
                {
                    Console.WriteLine("Nome do produto deve conter mais de 4 caracteres.");
                    Console.Write("Nome do produto: ");
                    nomesProdutos[i] = Console.ReadLine().Trim();
                }
                bool numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write($"Preço: R$ ");
                        precosProdutos[i] = Convert.ToDouble(Console.ReadLine());
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite um valor válido.");
                    }
                }
            }

            Console.Clear();
            for (var i = 0; i < quantidadeParaCadastrar; i++)
            {
                Console.WriteLine($"Nome produto {i + 1}: {nomesProdutos[i]}\nPreço: R$ {precosProdutos[i].ToString("F")}\n");
            }
        }
    }
}
