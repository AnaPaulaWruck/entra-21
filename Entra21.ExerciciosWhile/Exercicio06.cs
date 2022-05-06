using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            // Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de
            // sair, ao final deve - se aplicar ao valor total da compra um desconto de 5 %.

            string nomeProduto = "";
            double somaValores = 0;

            while (nomeProduto != "sair")
            {
                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();

                if (nomeProduto != "sair")
                {
                    Console.Write("Digite o valor do produto: R$ ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a quantidade de produtos: ");
                    int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    somaValores = somaValores + (valorProduto * quantidadeProdutos);
                }
            }
            double valorTotalComDesconto = somaValores - (somaValores * 0.05);
            Console.WriteLine("Valor total da compra sem desconto: R$ " + somaValores);
            Console.WriteLine("Valor total da compra com desconto: R$ " + valorTotalComDesconto);
        }
    }
}
