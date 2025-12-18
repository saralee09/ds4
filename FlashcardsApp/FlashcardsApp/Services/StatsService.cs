using FlashcardsApp.Data;
using FlashcardsApp.Models;
using System.Collections.Generic;

namespace FlashcardsApp.Services
{
    public class StatsService
    {
        private readonly StatsRepository _repo;

        public StatsService()
        {
            _repo = new StatsRepository();
        }

        public List<SessionStatDto> GetStats(int userId)
        {
            return _repo.GetSessionStats(userId);
        }
    }
}
