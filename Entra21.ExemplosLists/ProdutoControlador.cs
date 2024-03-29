﻿namespace Entra21.ExemplosLists
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico(); // por enquanto usar dessa forma para instanciar

        public void GerenciarMenu()
        {
            int codigo = 0;
            // Repete enquanto o código não for o menu sair (6)
            while (codigo != 6)
            {
                Console.Clear();
                // Apresentar o menu e solicitar o código
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    //Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    // Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    // Menu escolhido para apagar produto
                    Apagar();
                }
                else if (codigo == 5)
                {
                    // Menu escolhido para apresentar produto
                    ApresentarProduto();
                }

                // Delay de 1 segundo
                Thread.Sleep(1500);
            }
        }

        public void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponíveis:
- Armazem
- Area Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private void Editar()
        {
            ApresentarProdutos();

            Console.Write("Código do produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponíveis:
1 - Armazem
2 - Area Venda
3 - Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }

        private void Apagar()
        {
            ApresentarProdutos();

            Console.Write("Digite o código do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com código informado");
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
                // Para a execução deste método
                return;
            }

            Console.WriteLine("Lista de produtos cadastrados: ");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("\nCódigo: " + produtoAtual.Codigo + "\nNome: " + produtoAtual.Nome + "\n");
            }
        }

        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.Write("Digite o código do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // Verifica se o produto não está cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto não cadastrado.");

                return;
            }

            Console.Clear();
            Console.WriteLine(@$"Código: {produto.Codigo}
                Nome: {produto.Nome}
                Preço unitário: {produto.PrecoUnitario}
                Quantidade: {produto.Quantidade}
                Total: {produto.CalcularPrecoTotal()}");
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            // Continua solicitando o código até que seja um código entre 1 e 5
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }

            return codigo;
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" MENU
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }

    }
}
