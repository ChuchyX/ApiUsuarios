using Microsoft.EntityFrameworkCore;

namespace JwtWebApiTutorial
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public DbSet<User> Usuarios { get; set; }
    }
}
