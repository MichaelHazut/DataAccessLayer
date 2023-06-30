//using DataAccessLayer.Models;
using DataAccessLayer.DbContext;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



namespace DataAccessLayer.Repositories
{

    public abstract class BaseDataAccess<TEntity> : IEntityDataAccess<TEntity> where TEntity : class
    {
        protected readonly ExpenseTrackerDbContext _dbContext;

        protected BaseDataAccess(ExpenseTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync<TKey>(TKey id)
        {
            TEntity? entity = await _dbContext.Set<TEntity>().FindAsync(id);

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return entity;
        }

        public async Task<List<TEntity>> GetListByForeignKeyAsync<TKey>(string foreignKeyName, TKey foreignKeyId)
        {
            var table = _dbContext.Set<TEntity>();

            var parameter = Expression.Parameter(typeof(TEntity), "entity");
            var property = Expression.Property(parameter, foreignKeyName);
            var value = Expression.Constant(foreignKeyId);
            var equality = Expression.Equal(property, value);
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equality, parameter);

            return await _dbContext.Set<TEntity>()
                .Where(lambda)
                .ToListAsync();        
        }

        public async Task<bool> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity cannot be null. ", nameof(entity));
            }

            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync<TKey>(TKey id, TEntity newObject)
        {
            try
            {
                if(newObject == null)
                {
                    throw new ArgumentNullException(nameof(newObject));
                }

                var existingObject = await _dbContext.Set<TEntity>().FindAsync(id);
                if(existingObject == null)
                {
                    throw new ArgumentException($"No entity found with the specified id: {id}");
                }
                
                _dbContext.Entry(existingObject).CurrentValues.SetValues(newObject);
                
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating the entity.", ex);
            }
        }

        public async Task<bool> DeleteAsync<TKey>(TKey id)
        {
            try
            {
                TEntity entity = await GetByIdAsync(id);
                if(entity == null)
                {
                    throw new ArgumentException($"No Expense With Id: {id} ");
                }
                
                _dbContext.Set<TEntity>().Remove(entity);
                
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error occurred while deleting the entity.", ex);
            }

        }

    }
}