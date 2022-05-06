using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            // Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que 5.
            // Ao final deve-se aplicar um desconto de R$ 150,00.

            int quantidadeProdutos = 0;
            double somaValores = 0;
            double valorDesconto = 150;
            
            while (quantidadeProdutos < 5)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: R$ ");
                double valorProduto = Convert.ToDouble(Console.ReadLine);
                Console.Write("Digite a quantidade do produto: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                somaValores = somaValores + (valorProduto * quantidadeProdutos);
            }

            double valorTotalComDesconto = somaValores - valorDesconto;
            Console.WriteLine("Valor total sem desconto: R$ " + somaValores);
            Console.WriteLine("Valor total com desconto: R$ " + valorTotalComDesconto);
        }
    }
}
