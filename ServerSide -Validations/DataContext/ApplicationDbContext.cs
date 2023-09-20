using Microsoft.EntityFrameworkCore;
using ServerSide__Validations.Models;

namespace ServerSide__Validations.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserInfo>  Resgistration { get; set; }
    }
}
