using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trivia.Models;

namespace Trivia.Infrastructure
{
    public class TriviaContext : IdentityDbContext<User>
    {
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public TriviaContext(DbContextOptions<TriviaContext> context) : base(context)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
