using LibraryCRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryCRUD.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Library> libraries { get; set; }
    }
}
