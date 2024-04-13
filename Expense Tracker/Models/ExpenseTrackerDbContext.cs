using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ExpenseTrackerDbContext : DbContext
    {

        public ExpenseTrackerDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
