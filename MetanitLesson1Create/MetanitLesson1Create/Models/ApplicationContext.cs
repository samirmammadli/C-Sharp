using Microsoft.EntityFrameworkCore;

namespace MetanitLesson1Create.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
