using FlashcardsApp.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FlashcardsApp.Data
{
    public class FlashcardsRepository
    {
        private readonly string _connection;

        public FlashcardsRepository()
        {
            _connection = ConfigurationManager
                .ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<Flashcard> GetFlashcardsByLanguage(int languageId)
        {
            var list = new List<Flashcard>();

            using (SqlConnection conn = new SqlConnection(_connection))
            using (SqlCommand cmd = new SqlCommand("GetFlashcardsByLanguage", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LanguageId", languageId);

                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new Flashcard
                        {
                            FlashcardId = (int)rd["FlashcardId"],
                            Word = rd["Word"].ToString(),
                            Translation = rd["Translation"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        // 🔹 MÉTODO ADAPTATIVO
        public List<FlashcardAdaptiveDto> GetAdaptiveFlashcards(int languageId, int userId)
        {
            var list = new List<FlashcardAdaptiveDto>();

            using (SqlConnection conn = new SqlConnection(_connection))
            using (SqlCommand cmd = new SqlCommand("GetAdaptiveFlashcards", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LanguageId", languageId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new FlashcardAdaptiveDto
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
