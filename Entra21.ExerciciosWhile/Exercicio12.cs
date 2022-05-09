using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("\nEscolha o produto na tabela abaixo:\n");

            Console.WriteLine(" -----------------------------------------------------------------");
            Console.WriteLine("| Código | Tipo        | Nome                        | Valor      |");
            Console.WriteLine(" -----------------------------------------------------------------");
            Console.WriteLine("|   1    | Bolos       | Bolo Brigadeiro             | R$ 29,50   |");
            Console.WriteLine("|   2    | Bolos       | Bolo Floresta Negra         | R$ 2,00    |");
            Console.WriteLine("|   3    | Bolos       | Bolo Leite com Nutella      | R$ 29,23   |");
            Console.WriteLine("|   4    | Bolos       | Bolo Mousse de Chocolate    | R$ 7,10    |");
            Console.WriteLine("|   5    | Bolos       | Bolo Nega Maluca            | R$ 19,33   |");
            Console.WriteLine("|   6    | Doces       | Bomba de Creme              | R$ 17,71   |");
            Console.WriteLine("|   7    | Doces       | Bomba de Morango            | R$ 4,82    |");
            Console.WriteLine("|   8    | Sanduíches  | Filé-Mignon com fritas e    | R$ 21,16   |");
            Console.WriteLine("|        |             |  cheddar                    |            |");
            Console.WriteLine("|   9    | Sanduíches  | Hambúrguer com queijos,     | R$ 12,70   |");
            Console.WriteLine("|        |             |  champignon e rúcula        |            |");
            Console.WriteLine("|   10   | Sanduíches  | Provolone com salame        | R$ 19,70   |");
            Console.WriteLine("|   11   | Sanduíches  | Vegetariano de berinjela    | R$ 28,22   |");
            Console.WriteLine("|   12   | Pizzas      | Calabresa                   | R$ 8,98    |");
            Console.WriteLine("|   13   | Pizzas      | Napolitana                  | R$ 0,42    |");
            Console.WriteLine("|   14   | Pizzas      | Peruana                     | R$ 18,36   |");
            Console.WriteLine("|   15   | Pizzas      | Portuguesa                  | R$ 27,50   |");
            Console.WriteLine(" -----------------------------------------------------------------");
            Console.WriteLine("|   16   | Sair                                                   |");
            Console.WriteLine(" -----------------------------------------------------------------");

            int opcaoSelecionada = 0;
            int quantidadeBolos = 0, quantidadeDoces = 0, quantidadeSanduiches = 0, quantidadePizzas = 0;
            int quantidadeProduto = 0;

            while (opcaoSelecionada != 16)
            {
                Console.Write("Digite o número do produto desejado: ");
                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
                if ((opcaoSelecionada != 16) && (opcaoSelecionada >= 1) && (opcaoSelecionada <= 15))
                {
                    Console.WriteLine("Digite a quantidade desejada: ");
                    quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                }
                if ((opcaoSelecionada >= 1) && (opcaoSelecionada <= 5))
                {
                    quantidadeBolos = quantidadeBolos + quantidadeProduto;
                }
                if ((opcaoSelecionada == 6) || (opcaoSelecionada == 7))
                {
                    quantidadeDoces = quantidadeDoces + quantidadeProduto;
                }
                if ((opcaoSelecionada >= 8) && (opcaoSelecionada <= 11))
                {
                    quantidadeSanduiches = quantidadeSanduiches + quantidadeProduto;
                }
                if ((opcaoSelecionada >= 12) && (opcaoSelecionada <= 15))
                {
                    quantidadePizzas = quantidadePizzas + quantidadeProduto;
                }
                quantidadeProduto = 0;
            }
            int quantidadeTotalProdutos = quantidadeBolos + quantidadeDoces + quantidadeSanduiches + quantidadePizzas;

            Console.WriteLine("\nQuantidade de bolos consumidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de doces consumidos: " + quantidadeDoces);
            Console.WriteLine("Quantidade de sanduíches consumidos: " + quantidadeSanduiches);
            Console.WriteLine("Quantidade de pizzas consumidas: " + quantidadePizzas);
            Console.WriteLine("Quantidade total de produtos consumidos: " + quantidadeTotalProdutos);
        }
    }
}
