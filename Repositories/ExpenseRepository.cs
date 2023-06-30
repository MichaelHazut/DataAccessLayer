using DataAccessLayer.Models;
using DataAccessLayer.DbContext;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Repositories
{
    public class ExpenseRepository : BaseDataAccess<Expense>
    {
        public ExpenseRepository(ExpenseTrackerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Expense> GetExpenseByIdAsync(int expenseId)
        {
            return await GetByIdAsync(expenseId);
        }

        public async Task<IEnumerable<Expense>> GetExpensesListAsync()
        {
            return await GetAllAsync();
        }

        public async Task<List<Expense>> GetExpenseByUserId(string id)
        {
            return await _dbContext.Expenses
                                   .Include(e => e.ExpenseCategory)
                                   .Where(e => e.UserId == id)
                                   .ToListAsync();
        }

        public async Task<bool> CreateExpenseAsync(Expense expense)
        {
            return await CreateAsync(expense);
        }

        public async Task<bool> UpdateExpenseAsync(int id, Expense expense)
        {
            return await UpdateAsync(id, expense);
        }

        public async Task<bool> DeleteExpenseAsync<TKey>(TKey id)
        {
            return await DeleteAsync(id);
        }
    }
}
