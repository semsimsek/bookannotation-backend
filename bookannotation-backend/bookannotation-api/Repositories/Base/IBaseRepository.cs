using System.Linq.Expressions;

namespace bookannotation_api.Repositories.Base
{

    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(object id);
    }
}
