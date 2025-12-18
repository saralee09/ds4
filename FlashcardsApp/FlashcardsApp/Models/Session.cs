using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashcardsApp.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public int Score { get; set; }
    }
}
