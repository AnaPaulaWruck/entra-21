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

            int lado12 = Math.Abs(Lado1 - Lado2);
            int lado23 = Math.Abs(Lado2 - Lado3);
            int lado13 = Math.Abs(Lado1 - Lado3);
            int somaLado12 = Lado1 + Lado2;
            int somaLado23 = Lado2 + Lado3;
            int somaLado13 = Lado1 + Lado3;

            if ((lado23 < Lado1) && (somaLado23 > Lado1))
            {
                if ((lado13 < Lado2) && (somaLado13 > Lado2))
                {
                    if ((lado12 < Lado3) && (somaLado12 > Lado3))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        // TODO criar métodos separados para validar lado1, lado 2 e lado 3 para então usar no ValidarTriangulo()
        //private bool Lado1Valido()
        //{
        //    if ()

        //    return false;
        //}
    }
}
