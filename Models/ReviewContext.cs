using Microsoft.EntityFrameworkCore;
 
namespace RESTraunter.Models
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options) {}
        public DbSet<Review> Reviews { get; set; }
    }
}