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
    public class ExpenseConfig : IEntityTypeConfiguration<Expense>
    {

        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(
                new Expense
                {
                    Id = 1,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Groceries",
                    Price = 50.00m,
                    Date = new DateTime(2023, 1, 5),
                    Currency = "$",
                    ExpenseCategoryId = 1
                },
                new Expense
                {
                    Id = 2,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Rent for may",
                    Price = 2000,
                    Date = new DateTime(2023, 1, 15),
                    Currency = "$",
                    ExpenseCategoryId = 2
                },
                new Expense
                {
                    Id = 3,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Car",
                    Price = 467,
                    Date = new DateTime(2023, 2, 3),
                    Currency = "$",
                    ExpenseCategoryId = 2
                },
                new Expense
                {
                    Id = 4,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Dining Out",
                    Price = 30.00m,
                    Date = new DateTime(2023, 2, 12),
                    Currency = "$",
                    ExpenseCategoryId = 5
                },
                new Expense
                {
                    Id = 5,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Netflix",
                    Price = 25.00m,
                    Date = new DateTime(2023, 3, 1),
                    Currency = "$",
                    ExpenseCategoryId = 4
                },
                new Expense
                {
                    Id = 6,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Bus",
                    Price = 4,
                    Date = new DateTime(2023, 3, 10),
                    Currency = "$",
                    ExpenseCategoryId = 1
                },
                new Expense
                {
                    Id = 7,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Shopping",
                    Price = 75.00m,
                    Date = new DateTime(2023, 4, 5),
                    Currency = "$",
                    ExpenseCategoryId = 1
                },
                new Expense
                {
                    Id = 8,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Utilities",
                    Price = 80.00m,
                    Date = new DateTime(2023, 4, 20),
                    Currency = "$",
                    ExpenseCategoryId = 1
                },
                new Expense
                {
                    Id = 9,
                    UserId = "4cf45875-du4j-25j3-cme5-vjcmjy5kd5cm",
                    Title = "Healthcare",
                    Price = 50.00m,
                    Date = new DateTime(2023, 5, 8),
                    Currency = "$",
                    ExpenseCategoryId = 1
                }
            );
        }

    }

}