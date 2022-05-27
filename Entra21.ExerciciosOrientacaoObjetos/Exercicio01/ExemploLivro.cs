using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            livro.Titulo = "Nunca coloque a mão de um cadáver na boca";
            livro.Autor = "Dana Kollmann";
            livro.CodigoIsbn = "978-65-89999-01-3";
            livro.IdiomaOriginal = "Inglês";
            livro.DataLancamento = new DateTime(2010, 06, 01);
            livro.QuantidadePaginas = 265;
            livro.QuantidadePaginasLidas = 52;
            livro.QuantidadeReleituras = 2;

            livro.ApresentarTituloAutor();
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadePaginasLidasTotal();
        }
    }
}
