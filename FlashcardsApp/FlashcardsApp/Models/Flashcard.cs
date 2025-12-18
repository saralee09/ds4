using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashcardsApp.Models
{
    public class Flashcard
    {
        public int FlashcardId { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
    }
}
