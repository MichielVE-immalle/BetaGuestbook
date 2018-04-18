using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaGuestbook.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public User Name { get; set; }
    }
}
