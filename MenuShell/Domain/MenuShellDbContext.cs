using System.Data.Entity;

namespace MenuShell.Domain
{
    class MenuShellDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MenuShellDbContext() : base("MenuShellDbContext")
        {
        }
    }
}   
