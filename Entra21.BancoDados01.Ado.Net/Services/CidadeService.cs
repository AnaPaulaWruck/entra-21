using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            // Sunstituir os @ no comando da query que será executada no banco de dados, prevenindo SQL Injection
            comando.Parameters.AddWithValue("@ID", id);

            // Executa o comando de delete
            comando.ExecuteNonQuery();

            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO cidades (id_unidade_federativa, nome, quantidade_habitantes, data_fundacao, pib)
VALUES (@ID_UNIDADE_FEDERATIVA, @NOME, @QUANTIDADE_HABITANTES, @DATA_FUNDACAO, @PIB);";

            // Substituir os @ do insert com os valores preenchidos pelo usuário
            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            // Executa o comando de INSERT
            comando.ExecuteNonQuery();

            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
        }

        public void Editar(Cidade cidade)
        {
            // Conectado no banco de dados e definido a query que será executada
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE cidades 
SET id_unidade_federativa = @ID_UNIDADE_FEDERATIVA, nome = @NOME, quantidade_habitantes = @QUANTIDADE_HABITANTES, 
data_fundacao = @DATA_FUNDACAO, pib = @PIB 
WHERE id = @ID";

            // Substituir os @ do UPDATE com os valores preenchidos pelo usuário
            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);
            comando.Parameters.AddWithValue("@ID", cidade.Id);

            // Executar o UPDATE na tabela de cidades
            comando.ExecuteNonQuery();

            // Fechar conexão
            comando.Connection.Close();
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, id_unidade_federativa, nome, quantidade_habitantes, data_fundacao, pib 
FROM cidades 
WHERE id = @ID";

            // Substituir o @ do comando dp select com o id
            comando.Parameters.AddWithValue("@ID", id);

            // Cria tabela em memória para armazenar o registro da consulta
            var dataTable = new DataTable();
            // Carregar os registros no dataTable
            dataTable.Load(comando.ExecuteReader());
            // Verifica se encontrou um registro
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidade = new Cidade();
            cidade.Id = Convert.ToInt32(registro["id"]);

            // Instanciar UnidadeFederativa para poder armazenar o id da UnidadeFederativa
            cidade.UnidadeFederativa = new UnidadeFederativa();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            cidade.Nome = registro["nome"].ToString();
            cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_fundacao"]);
            cidade.Pib = Convert.ToDecimal(registro["pib"]);

            conexao.Close();

            return cidade;
        }

        public List<Cidade> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            // id, id_unidade_federativa, nome, quantidade_habitantes, data_fundacao, pib
            comando.CommandText = @"SELECT
c.id AS 'id',
c.nome AS 'nome',
c.quantidade_habitantes AS 'quantidade_habitantes',
c.data_fundacao AS 'data_hora_fundacao',
c.pib AS 'pib',
uf.id AS 'unidade_federativa_id',
uf.sigla AS 'unidade_federativa_sigla'
FROM cidades AS c
INNER JOIN unidades_federativas AS uf ON(c.id_unidade_federativa = uf.id)";

            // Criado tabela em memória para armazenar os registros do SELECT
            var tabelaEmMemoria = new DataTable();
            // Executa o SELECT armazenando na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado lista de cidades para armazenar os registros
            var cidades = new List<Cidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                // Instanciado a cidade populando com os dados do SELECT
                var cidade = new Cidade();
                cidade.Id = Convert.ToInt32(registro["id"]);

                // Instanciar UnidadeFederativa para poder armazenar o id da UnidadeFederativa
                cidade.UnidadeFederativa = new UnidadeFederativa();
                cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["unidade_federativa_id"]);
                cidade.UnidadeFederativa.Sigla = registro["unidade_federativa_sigla"].ToString();

                cidade.Nome = registro["nome"].ToString();
                cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
                cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
                cidade.Pib = Convert.ToDecimal(registro["pib"]);

                cidades.Add(cidade);
            }

            return cidades;
        }
    }
}
