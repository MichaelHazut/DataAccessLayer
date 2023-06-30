#nullable disable

using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
