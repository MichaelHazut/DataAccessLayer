#nullable disable warnings 

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccessLayer.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public string? Title { get; set; }
        public decimal Price { get; set; } = 0;
        public DateTime Date { get; set; }
        public string? Currency { get; set; }

        [ForeignKey("ExpenseCategory")]
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}