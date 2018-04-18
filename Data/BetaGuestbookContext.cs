using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BetaGuestbook.Models
{
    public class BetaGuestbookContext : DbContext
    {
        public BetaGuestbookContext (DbContextOptions<BetaGuestbookContext> options)
            : base(options)
        {
        }

        public DbSet<BetaGuestbook.Models.Comment> Comment { get; set; }
    }
}
