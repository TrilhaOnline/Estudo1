using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TrilhaOnline.Infra.Data.Context
{
    public sealed class BaseContext
    {
        public static IDbConnection Conn() => new SqlConnection(ConfigurationManager.ConnectionStrings["trilhaconn"].ConnectionString);
    }
}
