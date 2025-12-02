using System.Configuration;
using System.Data.SqlClient;

namespace doceria
{
    public static class Conexao
    {
        public static SqlConnection Conectar()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["conn"].ConnectionString
            );
        }
    }
}
