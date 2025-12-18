using System.Configuration;
using System.Data.SqlClient;

namespace FlashcardsApp.Data
{
    public class DbHelper
    {
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["FlashcardsDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
