namespace Entra21.ExemplosLists
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico(); // por enquanto usar dessa forma para instanciar

        public void GerenciarMenu()
        {
            Cadastrar();
            ApresentarProdutos();
            Cadastrar();
            ApresentarProdutos();
        }

        public void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
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

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("Nome: " + produtoAtual.Nome + " Preço unitário: " + produtoAtual.PrecoUnitario);
            }
        }
    }
}
