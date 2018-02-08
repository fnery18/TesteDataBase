
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace Teste.DAL
{
    public class ConnectionFactory
    {
        public static DbConnection TESTE()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
