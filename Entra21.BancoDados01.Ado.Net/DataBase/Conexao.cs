using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciado um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection(); // Ctrl . => Find and install sql connection

            // string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ana.wruck\source\db\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o Sql Connection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
