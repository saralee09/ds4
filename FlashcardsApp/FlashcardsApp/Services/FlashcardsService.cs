using FlashcardsApp.Data;
using FlashcardsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FlashcardsApp.Services
{
    public class FlashcardsService
    {
        private readonly FlashcardsRepository _repo;

        public FlashcardsService()
        {
            _repo = new FlashcardsRepository();
        }

        
        public List<Flashcard> GetFlashcardsByLanguage(int languageId)
        {
            return _repo.GetFlashcardsByLanguage(languageId);
        }

       
        public List<FlashcardAdaptiveDto> GetAdaptiveFlashcards(int languageId, int userId)
        {
            return _repo
                .GetAdaptiveFlashcards(languageId, userId)
                .OrderByDescending(c => c.FailCount)
                .ToList();
        }
    }
}
