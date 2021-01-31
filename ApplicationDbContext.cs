using MediatRPattern.DbModels;
using Microsoft.EntityFrameworkCore;

namespace MediatRPattern
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }
        public DbSet<Workshop> Workshops { get; set; }
    }
}
