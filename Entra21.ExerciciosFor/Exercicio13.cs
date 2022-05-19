using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio13
    {
        public void Executar()
        {
            string nomeMaiorNome = "", nomeMenorNome = "", nomeMaiorIdade = "", nomeMenorIdade = "";
            string nomeMaiorAltura = "", nomeMenorAltura = "", nomeMaiorPeso = "", nomeMenorPeso = "";
            string nomeMaisGolsMarcados = "", nomeMenosGolsMarcados = "";
            string nomeMaisCartoesAmarelos = "", nomeMenosCartoesAmarelos = "", nomeMaisCartoesVermelhos = "", nomeMenosCartoesVermelhos = "";

            int tamanhoMaiorNome = int.MinValue, tamanhoMenorNome = int.MaxValue;
            int maiorIdade = int.MinValue, menorIdade = int.MaxValue;
            double maiorAltura = int.MinValue, menorAltura = int.MaxValue, maiorPeso = int.MinValue, menorPeso = int.MaxValue;
            int maiorQuantidadeGols = int.MinValue, menorQuantidadeGols = int.MaxValue;
            int maiorQuantidadeAmarelos = int.MinValue, menorQuantidadeAmarelos = int.MaxValue;
            int maiorQuantidadeVermelhos = int.MinValue, menorQuantidadeVermelhos = int.MaxValue;
            int quantidadeJogadoresFeminino = 0, quantidadeJogadoresMasculino = 0;

            for (var i = 0; i < 3; i++)
            {
                // Obter nome:

                var nome = "";
                var tamanhoNome = 0;
                while (nome == "" || tamanhoNome < 5)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine().Trim();
                    tamanhoNome = nome.Length;
                    if (tamanhoNome < 5)
                    {
                        Console.WriteLine("Nome deve conter mais de 5 caracteres.");
                    }
                    if (tamanhoNome > tamanhoMaiorNome)
                    {
                        nomeMaiorNome = nome;
                    }
                    else if (tamanhoNome < tamanhoMenorNome)
                    {
                        nomeMenorNome = nome;
                    }
                }

                // Obter idade:
                var idade = 0;
                while (idade <= 0)
                {
                    try
                    {
                        Console.Write("Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        if (idade <= 0)
                        {
                            Console.WriteLine("Idade deve ser um valor inteiro positivo.");
                        }
                        else
                        {
                            if (idade > maiorIdade)
                            {
                                maiorIdade = idade;
                                nomeMaiorIdade = nome;
                            }
                            else if (idade < menorIdade)
                            {
                                menorIdade = idade;
                                nomeMenorIdade = nome;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para a idade.");
                    }
                }

                // Obter altura:
                var altura = 0.0;
                while (altura <= 0)
                {
                    try
                    {
                        Console.Write("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Altura deve ser um valor positivo.");
                        }
                        if (altura > maiorAltura)
                        {
                            maiorAltura = altura;
                            nomeMaiorAltura = nome;
                        }
                        else if (altura < menorAltura)
                        {
                            menorAltura = altura;
                            nomeMenorAltura = nome;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para a altura.");
                    }
                }

                // Obter peso:
                var peso = 0.0;
                while (peso <= 0)
                {
                    try
                    {
                        Console.Write("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        if (peso <= 0)
                        {
                            Console.WriteLine("Peso deve ser um valor positivo.");
                        }
                        if (peso > maiorPeso)
                        {
                            maiorPeso = peso;
                            nomeMaiorPeso = nome;
                        }
                        else if (peso < menorPeso)
                        {
                            menorPeso = peso;
                            nomeMenorPeso = nome;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para o peso.");
                    }
                }

                // Obter número de gols marcados:
                var golsMarcados = -1;
                while (golsMarcados < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de gols marcados: ");
                        peso = Convert.ToInt32(Console.ReadLine());
                        if (golsMarcados < 0)
                        {
                            Console.WriteLine("Quantidade de gols marcados não pode ser negativa.");
                        }
                        if (golsMarcados > maiorQuantidadeGols)
                        {
                            maiorQuantidadeGols = golsMarcados;
                            nomeMaisGolsMarcados = nome;
                        }
                        else if (golsMarcados < menorQuantidadeGols)
                        {
                            menorQuantidadeGols = golsMarcados;
                            nomeMenosGolsMarcados = nome;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para a quantidade de gols marcados.");
                    }
                }

                // Obter número de cartões amarelos recebidos:
                var quantidadeAmarelos = -1;
                while (quantidadeAmarelos < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões amarelos: ");
                        quantidadeAmarelos = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeAmarelos < 0)
                        {
                            Console.WriteLine("Quantidade de cartões amarelos não pode ser negativa.");
                        }
                        if (quantidadeAmarelos > maiorQuantidadeAmarelos)
                        {
                            maiorQuantidadeAmarelos = quantidadeAmarelos;
                            nomeMaisCartoesAmarelos = nome;
                        }
                        else if (quantidadeAmarelos < menorQuantidadeAmarelos)
                        {
                            menorQuantidadeAmarelos = quantidadeAmarelos;
                            nomeMenosCartoesAmarelos = nome;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para a quantidade de cartões amarelos.");
                    }
                }

                // Obter número de cartões vermelhos:
                var quantidadeVermelhos = -1;
                while (quantidadeVermelhos < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões vermelhos: ");
                        quantidadeVermelhos = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeVermelhos < 0)
                        {
                            Console.WriteLine("Quantidade de cartões vermelhos não pode ser negativa.");
                        }
                        if (quantidadeVermelhos > maiorQuantidadeVermelhos)
                        {
                            maiorQuantidadeVermelhos = quantidadeVermelhos;
                            nomeMaisCartoesVermelhos = nome;
                        }
                        else if (quantidadeVermelhos < menorQuantidadeVermelhos)
                        {
                            menorQuantidadeVermelhos = quantidadeVermelhos;
                            nomeMenosCartoesVermelhos = nome;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Deve ser digitado um valor válido para a quantidade de cartões vermelhos.");
                    }
                }

                // Obter quantidade de jogadores Masculinos e Femininos:
                var sexoJogador = "";
                while (sexoJogador == "" || !sexoJogador.StartsWith("F") || !sexoJogador.StartsWith("M"))
                {
                    Console.Write("Sexo: ");
                    sexoJogador = Console.ReadLine().Trim().ToUpper();
                    if (sexoJogador.StartsWith("F"))
                    {
                        quantidadeJogadoresFeminino++;
                    }
                    else if (sexoJogador.StartsWith("M"))
                    {
                        quantidadeJogadoresMasculino++;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido para o sexo do jogador.");
                    }
                }
            }
            // FALTA FAZER OS CONSOLES MOSTRANDO OS RESULTADOS
        }
    }
}
