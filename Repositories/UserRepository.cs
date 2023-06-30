using DataAccessLayer.DbContext;
using DataAccessLayer.Models;


namespace DataAccessLayer.Repositories
{
    public class UserRepository : BaseDataAccess<User>
    {
        public UserRepository(ExpenseTrackerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync<TKey>(TKey id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            return await CreateAsync(user);
        }

        public async Task<bool> UpdateUserAsync(string id, User user)
        {
            return await UpdateAsync(id, user);
        }

        public async Task<bool> DeleteUserAsync<TKey>(TKey id)
        {
            return await DeleteAsync(id);
        }
    }
}
