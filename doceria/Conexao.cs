using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doceria
{
    public static class Conexao
    {
        public static SqlConnection Conectar()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }
    }
}
