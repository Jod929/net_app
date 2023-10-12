using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quotes.Models;

namespace Quotes.Data
{
    public class QuotesContext : DbContext
    {
        public QuotesContext (DbContextOptions<QuotesContext> options)
            : base(options)
        {
        }

        public DbSet<Quotes.Models.Quote> Quote { get; set; } = default!;
    }
}
