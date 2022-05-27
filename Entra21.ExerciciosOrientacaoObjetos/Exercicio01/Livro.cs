using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine($"Título do livro: {Titulo}\nNome do autor: {Autor}");
        }

        public int CalcularQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;

            return quantidadePaginasParaLer;
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.WriteLine($"Páginas pendentes para leitura: {CalcularQuantidadePaginasParaLer()}");
        }

        public void ApresentarQuantidadePaginasLidasTotal()
        {
            Console.WriteLine($"Quantidade de páginas lidas: {QuantidadePaginasLidas}");
        }
    }
}
