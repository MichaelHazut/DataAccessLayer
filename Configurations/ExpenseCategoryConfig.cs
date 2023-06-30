using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class ExpenseCategoryConfig : IEntityTypeConfiguration<ExpenseCategory>
    {

        public void Configure(EntityTypeBuilder<ExpenseCategory> builder)
        {
            builder.HasData(
                new ExpenseCategory
                {
                    Id = 1,
                    Name = "Bills",
                },
                new ExpenseCategory
                {
                    Id = 2,
                    Name = "Rent",
                },
                new ExpenseCategory
                {
                    Id = 3,
                    Name = "Groceries",
                },
                new ExpenseCategory
                {
                    Id = 4,
                    Name = "Subscriptions",
                },
                new ExpenseCategory
                {
                    Id = 5,
                    Name = "Food",
                }

                
            );
        }
    }
}
