using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FlashcardsApp.Models;

using FlashcardsApp.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace FlashcardsApp.Data
{
    public class StatsRepository
    {
        private readonly string _connection;

        public StatsRepository()
        {
            _connection = ConfigurationManager
                .ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<SessionStatDto> GetSessionStats(int userId)
        {
            var list = new List<SessionStatDto>();

            using (SqlConnection conn = new SqlConnection(_connection))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    s.SessionId,
                    CONVERT(varchar, s.SessionDate, 23) AS Date,
                    COUNT(sd.SessionDetailId) AS Total,
                    SUM(CASE WHEN sd.IsCorrect = 1 THEN 1 ELSE 0 END) AS Correct
                FROM Sessions s
                JOIN SessionDetails sd ON s.SessionId = sd.SessionId
                WHERE s.UserId = @UserId
                GROUP BY s.SessionId, s.SessionDate
                ORDER BY s.SessionDate
            ", conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                conn.Open();

                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int total = (int)rd["Total"];
                    int correct = (int)rd["Correct"];

                    list.Add(new SessionStatDto
                    {
                        SessionId = (int)rd["SessionId"],
                        Date = rd["Date"].ToString(),
                        Total = total,
                        Correct = correct,
                        Percentage = total == 0 ? 0 : (correct * 100 / total)
                    });
                }
            }

            return list;
        }
    }
}
