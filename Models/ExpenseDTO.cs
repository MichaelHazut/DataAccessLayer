using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }

        public ExpenseDTO(Expense expense)
        {
            Id = expense.Id;
            Title = expense.Title!;
            Price = expense.Price;
            Date = expense.Date;
            Currency = expense.Currency!;
            CategoryName = expense.ExpenseCategory.Name;

        }

    }
}
