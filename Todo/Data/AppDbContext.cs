using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TodoList> TodoList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoList>().HasData(
                new TodoList
                {
                    Id = 1,
                    Header = "Test",
                    SubHeader = "Test in Physics",
                    Description = "Don't forget to revise",
                    SubmissionsDate = DateTime.Now,
                    DueDate = new DateTime(2024, 2, 28),
                });
            modelBuilder.Entity<TodoList>().HasData(
                new TodoList
                {
                    Id = 2,
                    Header = "Test",
                    SubHeader = "Test in Chemistry",
                    Description = "Don't forget to revise",
                    SubmissionsDate = DateTime.Now,
                    DueDate = new DateTime(2024, 2, 22),
                });
        }
    }
}
