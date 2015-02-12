using Microsoft.Data.Entity;
using MvcTodoWithNg.Models;

namespace MvcTodoWithNg.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Todo> Todos{ get; set; }
        
        protected override void OnConfiguring(DbContextOptions builder)
        {
            builder.UseInMemoryStore();
        }
    }
}