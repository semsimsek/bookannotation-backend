using bookannotation_api.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected DataContext _context;
    protected DbSet<TEntity> _dbSet;

    public BaseRepository(DataContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
    {
        try
        {
            return _dbSet.Where(filter);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
        }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
        }
    }

    public Task<bool> DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }
}