namespace Entra21.ExerciciosListasObjetos.Questao01
{
    internal class Triangulo
    {
        public int Codigo;
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public TrianguloClassificacao Classificacao;

        public bool ValidarTriangulo()
        {
            /*
            Condição de existência de um triângulo:
            | b - c | < a < b + c
            | a - c | < b < a + c
            | a - b | < c < a + b
            */

            if (ValidarLado1() == true && ValidarLado2() == true && ValidarLado3() == true)
            {
                return true;
            }

            return false;
        }

        private bool ValidarLado1()
        {
            int moduloLado23 = Math.Abs(Lado2 - Lado3);
            int somaLado23 = Lado2 + Lado3;

            if (moduloLado23 < Lado1 && somaLado23 > Lado1)
            {
                return true;
            }

            return false;
        }

        private bool ValidarLado2()
        {
            int moduloLado13 = Math.Abs(Lado1 - Lado3);
            int somaLado13 = Lado1 + Lado3;

            if (moduloLado13 < Lado2 && somaLado13 > Lado2)
            {
                return true;
            }

            return false;
        }

        private bool ValidarLado3()
        {
            int moduloLado12 = Math.Abs(Lado1 - Lado2);
            int somaLado12 = Lado1 + Lado2;

            if (moduloLado12 < Lado3 && somaLado12 > Lado3)
            {
                return true;
            }

            return false;
        }

        public bool EhEquilatero()
        {
            if (ValidarTriangulo() == false)
            {
                return false;
            }

            if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
            {
                return true;
            }

            return false;
        }

        public bool EhEscaleno()
        {
            if (ValidarTriangulo() == false)
            {
                return false;
            }

            if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
            {
                return true;
            }

            return false;
        }

        public bool EhIsosceles()
        {
            if (ValidarTriangulo() == false)
            {
                return false;
            }

            if (EhEquilatero() == false && EhEscaleno() == false)
            {
                return true;
            }

            return false;
        }
    }
}
