using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            /*
             5. Faça um programa que solicite a quantidade de carros que o usuário deseja
            cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
            atinja a quantidade de carros para cadastro.
            Apresente ao final:
                ● Média do ano dos carros;
                ● Média do valor dos carros;
                ● Quantidade de carros que começam com a letra G;
                ● Quantidade de carros que começam com a letra A.
            */
            Console.Clear();

            var somaAnoCarros = 0;
            var somaValorCarros = 0.0;
            var quantidadeComecamLetraG = 0;
            var quantidadeComecamLetraA = 0;
            var mediaAnoCarros = 0;
            var mediaValorCarros = 0.0;

            try
            {
                Console.Write("Digite a quantidade de carros para cadastrar: ");
                var quantidadeCadastros = Convert.ToInt32(Console.ReadLine());
                for (var i = 0; i < quantidadeCadastros; i++)
                {
                    Console.Write("Modelo do carro: ");
                    var modeloCarro = Console.ReadLine().Trim().ToUpper();
                    if (modeloCarro.StartsWith("G"))
                    {
                        quantidadeComecamLetraG++;
                    }
                    else if (modeloCarro.StartsWith("A"))
                    {
                        quantidadeComecamLetraA++;
                    }

                    var valorCarro = 0.0;
                    while (valorCarro <= 0)
                    {
                        try
                        {
                            Console.Write("Valor do carro: R$ ");
                            valorCarro = Convert.ToInt32(Console.ReadLine());
                            if (valorCarro == 0)
                            {
                                Console.WriteLine("Valor não pode ser igual a zero.");
                            }
                            else if (valorCarro < 0)
                            {
                                Console.WriteLine("Valor não pode ser negativo.");
                            }
                            somaValorCarros += valorCarro;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Valor digitado não é um número válido.");
                        }
                    }

                    var anoCarro = 0;
                    while (anoCarro <= 0)
                    {
                        try
                        {
                            {
                                Console.Write("Ano do carro: ");
                                anoCarro = Convert.ToInt32(Console.ReadLine());
                                if (anoCarro == 0)
                                {
                                    Console.WriteLine("Ano não pode ser igual a zero.");
                                }
                                else if (anoCarro < 0)
                                {
                                    Console.WriteLine("Ano não pode ser um valor negativo.");
                                }
                            }
                            somaAnoCarros += anoCarro;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Deve ser um número válido.");
                        }
                    }
                }
                mediaAnoCarros = somaAnoCarros / quantidadeCadastros;
                mediaValorCarros = somaValorCarros / quantidadeCadastros;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor digitado inválido. Deve ser um número inteiro positivo.");
            }
            Console.WriteLine("\nMédia do ano dos carros: " + mediaAnoCarros);
            Console.WriteLine("Media do valor dos carros: R$ " + mediaValorCarros);
            Console.WriteLine("Quantidade de carros que modelo começa com a letra G: " + quantidadeComecamLetraG);
            Console.WriteLine("Quantidade de carros que modelo começa com a letra A: " + quantidadeComecamLetraA);
        }
    }
}
