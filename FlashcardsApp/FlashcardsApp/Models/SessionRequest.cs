using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashcardsApp.Models.DTO
{
    public class SessionRequest
    {
        public int UserId { get; set; }
        public int Score { get; set; }
    }
}
