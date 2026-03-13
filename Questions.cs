using Microsoft.EntityFrameworkCore;
using SwingQuestBackEnd.Models;

namespace SwingQuestBackEnd.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext (DbContextOptions option) : base (option)
        {

        }

        public DbSet<Users> users { get; set; }
        public DbSet<Questions> questions { get; set; }
    }
}
