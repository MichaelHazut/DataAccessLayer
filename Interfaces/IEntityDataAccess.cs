

namespace DataAccessLayer.Interfaces
{
    public interface IEntityDataAccess<TEntity>
    {
        Task<TEntity> GetByIdAsync<TKey>(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> UpdateAsync<TKey>(TKey id, TEntity entity);
        Task<bool> DeleteAsync<TKey>(TKey id);
    }
}
