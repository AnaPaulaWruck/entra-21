namespace Entra21.ExemplosLists
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // Adicionar 1 no código atual para quando criar um novo produto o outro produto conter um novo código
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtém o produto desejado da lista de produtos
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verifica se não foi possível encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso porque não existe produto com o código dos parâmetros
                return false;
            }

            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro porque foi possível alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivos
                // int numero = numeros[i];

                // Resgatando de uma lista de objetos
                Produto produto = produtos[i];


                if (produto.Codigo == codigo)
                {
                    // Posso remover com o índice do objeto desejado
                    // produtos.RemoveAt(i);

                    // Posso remover com o objeto desejado
                    produtos.Remove(produto);

                    // Retorna true porque o produto com o código desejado foi removido da lista
                    return true;
                }
            }

            // Retorna falso porque não encontrou o produto com o código desejado, ou seja, nenhum elemento foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto
            // filtrando por código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado índice
                var produtoAtual = produtos[i];

                // Verificar se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }

        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            // Percorre a lista de produtos para obter o produto com o menor preço unitário
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista que está sendo percorrida
                Produto produto = produtos[i];

                // Verifica se o produto atual possui o menor preço unitário
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    // armazena o preço unitário, pois é o menor preço unitário até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    // armazena o produto para posteriormente saber qual é o produto com o menor preço unitário
                    produtoMenorPrecoUnitario = produto;
                }
            }

            return produtoMenorPrecoUnitario;
        }

        public List<double> ObterTodosPrecos()
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Verifica se a localizaçao do produto atual é a localização passada no parâmetro 
                if (produto.Localizacao == localizacao)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem()
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Verifica se a localizaçao do produto atual é Armazém
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por Armazém
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;

            // Percorre todos os produtos 
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total do produto na variável soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }

            // Calcula a média de acordo com a quantidade de produtos
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}

