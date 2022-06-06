using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosLists
{
    public class Exercicio01
    {
        public void Executar()
        {
            /*
    Criar uma classe que irá armazenar os melhores filmes de todos os tempos.
    a. Adicionar o filme "Dragon Ball Evollution";
    b. Adicionar o filme "Titanic";
    c. Adicionar o filme "Lanterna verde";
    d. Listar os filmes armazenados na lista;
    e. Adicionar o filme "";
    f. Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
    g. Remover filme "Lanterna verde";
    h. Verificar se a lista contém o filme "Lanterna verde" apresentando para o usuário se está ou não cadastrado;
    i. Adicionar o filme "Quarteto fantástico";
    j. Listar os filmes armazenados na lista;
    k. Alterar o filme "Titanic" para “Titanic 2”;
    l. Listar os filmes armazenados na lista;
    m. Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário 
            */

            List<string> melhoresFilmes = new List<string>();
            // a, b, c
            melhoresFilmes.Add("Dragon Ball Evollution");
            melhoresFilmes.Add("Titanic");
            melhoresFilmes.Add("Lanterna Verde");
            // d
            Console.WriteLine("Filme 1: " + melhoresFilmes[0] + "\nFilme2: " + melhoresFilmes[1] + "\nFilme3: " + melhoresFilmes[2]);
            // e
            melhoresFilmes.Add("");
            // f
            melhoresFilmes[0] = "Dragon Ball Super: Broly";
            // g
            melhoresFilmes.Remove("Lanterna Verde");
            // h
            string filme = "Lanterna Verde";
            bool contemFilme = melhoresFilmes.Contains(filme);
            if (contemFilme == true)
            {
                Console.WriteLine("\nA lista contém o filme " + filme);
            }
            else
            {
                Console.WriteLine("\nA lista não contém o filme " + filme);
            }
            // i
            melhoresFilmes.Add("Quarteto Fantástico");
            // j
            Console.WriteLine("\nFilme 1: " + melhoresFilmes[0] + "\nFilme 2: " + melhoresFilmes[1] + "\nFilme 3: " + 
                melhoresFilmes[2] + "\nFilme 4: " + melhoresFilmes[3]);
            // k
            melhoresFilmes[1] = "Titanic 2";
            // l
            Console.WriteLine("\nFilme 1: " + melhoresFilmes[0] + "\nFilme 2: " + melhoresFilmes[1] + "\nFilme 3: " +
                melhoresFilmes[2] + "\nFilme 4: " + melhoresFilmes[3]);
            // m
            filme = "A Lagoa Azul";
            contemFilme = melhoresFilmes.Contains(filme);
            if (contemFilme == true)
            {
                Console.WriteLine("\nA lista contém o filme " + filme);
            }
            else
            {
                Console.WriteLine("\nA lista não contém o filme " + filme);
            }
        }
    }
}
