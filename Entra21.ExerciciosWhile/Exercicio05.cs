using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeCarrosParaCadastrar = Convert.ToInt32(Console.ReadLine());

            int anoDoCarro = 0;
            int somaAnoDosCarros = 0;

            double valorDoCarro = 0;
            double somaValorDosCarros = 0;

            string modeloCarro = "";
            int quantidadeCarrosComecamLetraG = 0;
            int quantidadeCarrosComecamLetraA = 0;
            int quantidadeOutrosCarros = 0;

            int indice = 0;

            while (indice < quantidadeCarrosParaCadastrar)
            {
                Console.Write("Digite o modelo do carro: ");
                modeloCarro = Console.ReadLine().ToUpper().Trim();
                Console.Write("Digite o ano do carro: ");
                anoDoCarro = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor do carro: R$ ");
                valorDoCarro = Convert.ToDouble(Console.ReadLine());

                somaAnoDosCarros = somaAnoDosCarros + anoDoCarro;
                somaValorDosCarros = somaValorDosCarros + valorDoCarro;

                if (modeloCarro.StartsWith("G"))
                {
                    quantidadeCarrosComecamLetraG = quantidadeCarrosComecamLetraG + 1;
                }
                else if (modeloCarro.StartsWith("A"))
                {
                    quantidadeCarrosComecamLetraA = quantidadeCarrosComecamLetraA + 1;
                }

                indice = indice + 1;
            }

            int mediaAnoCarros = somaAnoDosCarros / quantidadeCarrosParaCadastrar;
            double mediaValorCarros = somaValorDosCarros / quantidadeCarrosParaCadastrar;

            Console.WriteLine("Quantidade de carros cadastrados: " + quantidadeCarrosParaCadastrar);
            Console.WriteLine("Média do ano dos carros: " + mediaAnoCarros);
            Console.WriteLine("Média do valor dos carros: R$ " + mediaValorCarros);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + quantidadeCarrosComecamLetraG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + quantidadeCarrosComecamLetraA);
        }
    }
}
