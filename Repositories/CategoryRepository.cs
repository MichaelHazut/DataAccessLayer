using DataAccessLayer.DbContext;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : BaseDataAccess<ExpenseCategory>
    {
        public CategoryRepository(ExpenseTrackerDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<ExpenseCategory> GetCategoryByIdAsync(int categoryId)
        {
            return await GetByIdAsync(categoryId);
        }

        public async Task<IEnumerable<ExpenseCategory>> GetCategoryListByIdAsync(string id)
        {
            var resuly = await _dbContext.Users.FindAsync(id);
            var categoryIds = await _dbContext.Expenses
                .Where(e => e.UserId == id)
                .Select(e => e.ExpenseCategoryId)
                .Distinct()
                .ToListAsync();

            var categories = await _dbContext.ExpenseCategories
                .Where(c => categoryIds.Contains(c.Id))
                .ToListAsync();

            return categories;
        }

        public async Task<List<ExpenseCategory>> GetCategoriesListByUserId(string id)
        {
            return await GetListByForeignKeyAsync("UserId", id);
        }

        public async Task<bool> CreateCategoryAsync(ExpenseCategory category)
        {
            return await CreateAsync(category);
        }

        public async Task<bool> UpdateCategoryAsync(int id, ExpenseCategory category)
        {
            return await UpdateAsync(id, category);
        }

        public async Task<bool> DeleteExpenseAsync<TKey>(TKey id)
        {
            return await DeleteAsync(id);
        }
    }
}
