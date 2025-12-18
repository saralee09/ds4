using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashcardsApp.Models
{
    public class SessionStatDto
    {
        public int SessionId { get; set; }
        public string Date { get; set; }
        public int Total { get; set; }
        public int Correct { get; set; }
        public int Percentage { get; set; }
    }
}
