using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciado um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection(); // Ctrl . => Find and install sql connection

            //// string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados
            //var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\db\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            //// Definir o caminho da conexão para o Sql Connection
            //conexao.ConnectionString = connectionString;

            var nomeBanco = "DataBase";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\Database\{nomeBanco}.mdf;Integrated Security=True";

            // Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
