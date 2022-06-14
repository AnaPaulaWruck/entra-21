using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListasObjetos.Questao01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3) // , Triangulo classificacao
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            //triangulo.Classificacao = classificacao;

            if (triangulo.ValidarTriangulo() == true)
            {
                triangulo.Codigo = codigoAtual;

                codigoAtual++;

                triangulos.Add(triangulo);

                // condição de existência atendida, pode cadastrar o triângulo
                return true;
            }

            // condição de existência não atendida, não pode cadastrar o triângulo
            return false;
        }

        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if (trianguloParaAlterar == null)
            {
                return false; // código informado não existe
            }
            else if (trianguloParaAlterar.ValidarTriangulo() == true)
            {
                trianguloParaAlterar.Lado1 = lado1;
                trianguloParaAlterar.Lado2 = lado2;
                trianguloParaAlterar.Lado3 = lado3;

                return true; // condição de existência atendida
            }

            // condição de existência não atendida, não pode alterar o triângulo
            return false;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];

                if (triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);

                    return true;
                }
            }

            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }

            return null; // Se o código informado não estiver na lista
        }

        //public string ObterClassificacao()
        //{
        //    Triangulo triangulo = new Triangulo();

        //    if (triangulo.EhEquilatero() == true)
        //    {
        //        return "Equilátero";
        //    }
        //    else if (triangulo.EhEscaleno() == true)
        //    {
        //        return "Escaleno";
        //    }
        //    else if (triangulo.EhIsosceles() == true)
        //    {
        //        return "Isósceles";
        //    }

        //    return "";
        //}
    }
}
