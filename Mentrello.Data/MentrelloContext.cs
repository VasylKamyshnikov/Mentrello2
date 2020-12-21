using Mentrello.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mentrello.Data
{
    public class MentrelloContext : DbContext
    {
        public MentrelloContext(DbContextOptions<MentrelloContext> options) : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
