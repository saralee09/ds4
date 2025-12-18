using System.Collections.Generic;
using FlashcardsApp.Data;
using FlashcardsApp.Models;

namespace FlashcardsApp.Services
{
    public class StatsService
    {
        private readonly StatsRepository _repo;

        public StatsService()
        {
            _repo = new StatsRepository();
        }

        public List<HardestFlashcardDto> GetHardestFlashcards(int userId)
        {
            return _repo.GetHardestFlashcards(userId);
        }
    }
}
