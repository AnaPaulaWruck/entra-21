using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Construtor: mais pra frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        // Método Adicionar recebe como parâmetro o objeto no endereço completo do Form (Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre a lista de endereços a fim de encontrar o endereço que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtém o endereço da lista de endereços
                var endereco = enderecos[i];

                // Verifica se o código do endereço percorrido é o mesmo endereço que deve ser alterado
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    // Atualiza campos do endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Endereco enderecoParaApagar)
        {
            // Percorre a ista de endereços afim de encontrar o endereçi que deve ser removido
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtiém o endereço percorrido
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaApagar.Codigo)
                {
                    // Remove o endereço encontrado na lista de endereços
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        // Método que permite listar todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            // Percorre a lista de endereços afim de encontrar o endereço com o código desejado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtém o endereço percorrido
                var endereco = enderecos[i];

                // Verifica se o endereço contém o código desejado
                if (endereco.Codigo == codigo)
                    return endereco;
            }

            // Retorna null pois não encontrou o endereço com o código desejado
            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                ultimoCodigo = endereco.Codigo;
            }

            return ultimoCodigo;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosEmJson);
        }

        public void LerArquivo()
        {
            // Verifica se o endereço não existe
            if (File.Exists("enderecos.json") == false)
                return;

            // Ler o arquivo json e converte para uma lista de objetos de enderecos
            var enderecosEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }

        // FALTA PEGAR ENDEREÇO PELO CEP
    }
}
