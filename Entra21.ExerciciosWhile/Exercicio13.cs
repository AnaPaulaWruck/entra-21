using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            /*
            Deve-se solicitar as seguintes informações abaixo:
            ➔ Nome;
            ➔ Idade;
            ➔ Sexo;
            ➔ Peso;
            ➔ Altura;
            ➔ Quantidade de gols marcados;
            ➔ Quantidade de cartões amarelos recebidos;
            ➔ Quantidade de cartões vermelhos recebidos;
            */
            Console.Clear();

            int indice = 0;
            string nomeMenorNome = "", nomeMaiorNome = "", nomeMenorIdade = "", nomeMaiorIdade = "";
            string nomeMenorPeso = "", nomeMaiorPeso = "", nomeMenorAltura = "", nomeMaiorAltura = "";
            string nomeMenosGolsMarcados = "", nomeMaisGolsMarcados = "";
            string nomeMenosCartoesAmarelos = "", nomeMaisCartoesAmarelos = "", nomeMenosCartoesVermelhos = "", nomeMaisCartoesVermelhos = "";
            int quantidadeJogadoresFeminino = 0, quantidadeJogadoresMasculino = 0;
            int tamanhoMenorNome = int.MaxValue, tamanhoMaiorNome = int.MinValue;
            int menorIdade = int.MaxValue, maiorIdade = int.MinValue;
            double menorPeso = double.MaxValue, maiorPeso = double.MinValue;
            double menorAltura = double.MaxValue, maiorAltura = double.MinValue;
            int menorQuantidadeGolsMarcados = int.MaxValue, maiorQuantidadeGolsMarcados = int.MinValue;
            int menorQuantidadeCartoesAmarelos = int.MaxValue, maiorQuantidadeCartoesAmarelos = int.MinValue;
            int menorQuantidadeCartoesVermelhos = int.MaxValue, maiorQuantidadeCartoesVermelhos = int.MinValue;


            while (indice < 22)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine().Trim();
                if (nome.Length < tamanhoMenorNome)
                {
                    nomeMenorNome = nome;
                    tamanhoMenorNome = nome.Length;
                }
                if (nome.Length > tamanhoMaiorNome)
                {
                    nomeMaiorNome = nome;
                    tamanhoMaiorNome = nome.Length;
                }
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                if (idade < menorIdade)
                {
                    nomeMenorIdade = nome;
                    menorIdade = idade;
                }
                if (idade > maiorIdade)
                {
                    nomeMaiorIdade = nome;
                    maiorIdade = idade;
                }

                Console.Write("Sexo: ");
                string sexo = Console.ReadLine().ToUpper().Trim();
                if (sexo.StartsWith("F"))
                {
                    quantidadeJogadoresFeminino = quantidadeJogadoresFeminino + 1;
                }
                else if (sexo.StartsWith("M"))
                {
                    quantidadeJogadoresMasculino = quantidadeJogadoresMasculino + 1;
                }

                Console.Write("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                if (peso < menorPeso)
                {
                    nomeMenorPeso = nome;
                    menorPeso = peso;
                }
                if (peso > maiorPeso)
                {
                    nomeMaiorPeso = nome;
                    maiorPeso = peso;
                }

                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                if (altura < menorAltura)
                {
                    nomeMenorAltura = nome;
                    menorAltura = altura;
                }
                if (altura > maiorAltura)
                {
                    nomeMaiorAltura = nome;
                    maiorAltura = altura;
                }

                Console.Write("Quantidade de gols marcados: ");
                int quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                if (quantidadeGolsMarcados < menorQuantidadeGolsMarcados)
                {
                    nomeMenosGolsMarcados = nome;
                    menorQuantidadeGolsMarcados = quantidadeGolsMarcados;
                }
                if (quantidadeGolsMarcados > maiorQuantidadeGolsMarcados)
                {
                    nomeMaisGolsMarcados = nome;
                    maiorQuantidadeGolsMarcados = quantidadeGolsMarcados;
                }

                Console.Write("Quantidade de cartões amarelos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                if (quantidadeCartoesAmarelos < menorQuantidadeCartoesAmarelos)
                {
                    nomeMenosCartoesAmarelos = nome;
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if (quantidadeCartoesAmarelos > maiorQuantidadeCartoesAmarelos)
                {
                    nomeMaisCartoesAmarelos = nome;
                    maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                }

                Console.Write("Quantidade de cartões vermelhos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                if (quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
                {
                    nomeMenosCartoesVermelhos = nome;
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                }
                if (quantidadeCartoesVermelhos > maiorQuantidadeCartoesVermelhos)
                {
                    nomeMaisCartoesVermelhos = nome;
                    maiorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                }

                indice = indice + 1;
            }
            Console.WriteLine("\nJogador com menor nome: " + nomeMenorNome);
            Console.WriteLine("Jogador com maior nome: " + nomeMaiorNome);
            Console.WriteLine("Jogador com menor idade: " + nomeMenorIdade + " - " + menorIdade + " anos");
            Console.WriteLine("Jogador com maior idade: " + nomeMaiorIdade + " - " + maiorIdade + " anos");
            Console.WriteLine("Jogador com menor peso: " + nomeMenorPeso + " - " + menorPeso + " Kg");
            Console.WriteLine("Jogador com maior peso: " + nomeMaiorPeso + " - " + maiorPeso + " Kg");
            Console.WriteLine("Jogador com menor altura: " + nomeMenorAltura + " - " + menorAltura + " m");
            Console.WriteLine("Jogador com maior altura: " + nomeMaiorAltura + " - " + maiorAltura + " m");
            Console.WriteLine("Jogador com menos gols marcados: " + nomeMenosGolsMarcados + " - " + menorQuantidadeGolsMarcados + " gols");
            Console.WriteLine("Jogador com mais gols marcados: " + nomeMaisGolsMarcados + " - " + maiorQuantidadeGolsMarcados + " gols");
            Console.WriteLine("Jogador com menos cartões amarelos: " + nomeMenosCartoesAmarelos + " - " + menorQuantidadeCartoesAmarelos + " cartões amarelos");
            Console.WriteLine("Jogador com mais cartões amarelos: " + nomeMaisCartoesAmarelos + " - " + maiorQuantidadeCartoesAmarelos + " cartões amarelos");
            Console.WriteLine("Jogador com menos cartões vermelhos: " + nomeMenosCartoesVermelhos + " - " + menorQuantidadeCartoesVermelhos + " cartões vermelhos");
            Console.WriteLine("Jogador com mais cartões vermelhos: " + nomeMaisCartoesVermelhos + " - " + maiorQuantidadeCartoesVermelhos + " cartões vermelhos");
            Console.WriteLine("Quantidade de jogadores femininos: " + quantidadeJogadoresFeminino);
            Console.WriteLine("Quantidade de jogadores masculinos: " + quantidadeJogadoresMasculino);
        }
    }
}
