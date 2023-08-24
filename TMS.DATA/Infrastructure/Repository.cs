using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TMS.DATA.Context;

namespace TMS.DATA.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TMS_Context _dbContext;
        public Repository(TMS_Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(T model)
        {
            var _dbset = _dbContext.Set<T>();
            await _dbset.AddAsync(model);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefault(Expression<Func<T, object>>? include = null, Expression<Func<T, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetbyIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
