using FlashcardsApp.Data;
using System.Data.SqlClient;

namespace FlashcardsApp.Services
{
    public class SessionService
    {
        public int SaveSession(int userId, int score)
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new SqlCommand("SaveSession", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Score", score);

                conn.Open();
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }
    }
}
