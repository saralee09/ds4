using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashcardsApp.Models
{
    public class SessionDetail
    {
        public int DetailId { get; set; }
        public int SessionId { get; set; }
        public int FlashcardId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
