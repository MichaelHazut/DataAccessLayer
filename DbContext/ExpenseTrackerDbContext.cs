using DataAccessLayer.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Configurations;

namespace DataAccessLayer.DbContext

{
    public class ExpenseTrackerDbContext : IdentityDbContext<User>
    {
        //public new DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public ExpenseTrackerDbContext
            (DbContextOptions<ExpenseTrackerDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new UserRoleConfig());
            builder.ApplyConfiguration(new ExpenseCategoryConfig());
            builder.ApplyConfiguration(new ExpenseConfig());
        }



    }
}

/*

To Create Migration Type In Packet Manager Console
EntityFrameworkCore\Add-Migration InitialCreate -Project DataAccessLayer -StartupProject ExpenSage

To Update Database Type In Packet Manager Console
EntityFrameworkCore\Update-Database -Project DataAccessLayer -StartupProject ExpenSage

*/