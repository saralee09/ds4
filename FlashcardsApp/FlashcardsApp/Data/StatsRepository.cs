using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FlashcardsApp.Models;

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

        public List<HardestFlashcardDto> GetHardestFlashcards(int userId)
        {
            var list = new List<HardestFlashcardDto>();

            using (SqlConnection conn = new SqlConnection(_connection))
            using (SqlCommand cmd = new SqlCommand("GetHardestFlashcards", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);

                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new HardestFlashcardDto
                        {
                            FlashcardId = (int)rd["FlashcardId"],
                            Word = rd["Word"].ToString(),
                            Translation = rd["Translation"].ToString(),
                            FailCount = (int)rd["FailCount"]
                        });
                    }
                }
            }

            return list;
        }
    }
}
