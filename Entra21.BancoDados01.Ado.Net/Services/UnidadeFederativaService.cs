using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class UnidadeFederativaService : IUnidadeFederativaService
    {
        public void Apagar(int id)
        {
            // Conectar com o bd
            var conexao = new Conexao().Conectar();

            // Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            // Definido o comando para apagar o registro
            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Executado o comando para apagar o registro
            comando.ExecuteNonQuery();

            // Fechar conexão com o bd
            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            // Criando conexão com o Banco de Dados e aberta a conexão
            var conexao = new Conexao().Conectar();

            // Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // Especificando o comando que será executado
            comando.CommandText = "INSERT INTO unidades_federativas (nome, sigla) VALUES(@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla.ToUpper());

            // Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            {
                var conexao = new Conexao().Conectar();

                // Conectado no banco de dados e definido a query que será executada
                var comando = conexao.CreateCommand();
                comando.CommandText = "UPDATE unidades_federativas SET tipo = @TIPO WHERE id = @ID";

                comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
                comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
                comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);

                // Executa o UPDATE na tabela de unidades_federativas
                comando.ExecuteNonQuery();

                // Fechar conexão
                comando.Connection.Close();
            }
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no bando de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Instanciado tabela em memória para armazenar os registros retornados da consulta SELECT
            var tabelaEmMemoria = new DataTable();

            // Executado a consulta na tabela de tipos_personagens armazenando-os na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Id = Convert.ToInt32(primeiroRegistro["id"]);
            unidadeFederativa.Nome = primeiroRegistro["nome"].ToString();
            unidadeFederativa.Sigla = primeiroRegistro["sigla"].ToString();

            // Fechar a conexão
            comando.Connection.Close();

            return unidadeFederativa;
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            // Criando conexão com o Banco de Dados e aberta a conexão
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas";

            // Criado tabela em memória para posteriormente carregar os registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            // Carregado na tabela em memória os registros encontrados com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado uma lista para armazenar os registros da consulta do SELECT
            var unidadesFederativas = new List<UnidadeFederativa>();

            // Percorrido cada um dos registros da tabelaEmMemoria (registros do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                // Instanciado objeto da classe UnidadeFederativa preenchendo com as informações do SELECT, da linha que está sendo percorrida
                var unidadeFederativa = new UnidadeFederativa();
                unidadeFederativa.Id = Convert.ToInt32(linha["id"].ToString());
                unidadeFederativa.Nome = linha["nome"].ToString();
                unidadeFederativa.Sigla = linha["sigla"].ToString();

                // Adicionado tipoPersonagem instanciado na lista de TiposPersonagens
                unidadesFederativas.Add(unidadeFederativa);
            }

            // Fechado a conexão com o banco de dados
            comando.Connection.Close();

            return unidadesFederativas;
        }
    }
}
