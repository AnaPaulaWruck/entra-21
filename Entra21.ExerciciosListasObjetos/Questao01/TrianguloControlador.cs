namespace Entra21.ExerciciosListasObjetos.Questao01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            CadastrarTriangulo();
            ApresentarListaTriangulos();
            ApresentarTriangulo();
        }

        public void CadastrarTriangulo()
        {
            Console.Write("Valor Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var cadastrar = trianguloServico.Adicionar(lado1, lado2, lado3);

            if (cadastrar == false)
            {
                Console.WriteLine("Não foi possível realizar o cadastro, pois a condição de existência de um triângulo não foi atendida.");
            }
            else
            {
                Console.WriteLine("Triângulo cadastrado com sucesso.");
            }
        }

        private void EditarTriangulo()
        {
            ApresentarListaTriangulos();

            Console.Write("Código do triângulo para editar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var codigo

            if (alterar == false)
            {
                Console.WriteLine("Código digitado não existe.");
            }

            Console.Write("Valor Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var alterar = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if (alterar == false)
            {
                Console.WriteLine("Código digitado não existe.");
            }
            else
            {
                Console.WriteLine("Dados do triângulo alterados com sucesso.");
            }
        }

        private void ApresentarListaTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triângulo cadastrado.");

                return;
            }

            Console.WriteLine("Lista de triângulos cadastrados:");
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($"Código: {trianguloAtual.Codigo} \nLado1: {trianguloAtual.Lado1} - Lado 2: {trianguloAtual.Lado2} - " +
                    $"Lado 3: {trianguloAtual.Lado3}\n");
            }
        }

        private void ApresentarTriangulo()
        {
            ApresentarListaTriangulos();

            Console.Write("Digite o código do triângulo desejado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Triângulo não cadastrado.");

                return;
            }

            Console.WriteLine(@$"Código: {triangulo.Codigo}
Lado 1: {triangulo.Lado1}
Lado 2: {triangulo.Lado2}
Lado 3: {triangulo.Lado3}
Tipo de triângulo: ");
        }
    }
}
