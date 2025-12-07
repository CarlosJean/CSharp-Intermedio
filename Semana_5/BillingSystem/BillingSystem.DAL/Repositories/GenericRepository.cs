using BillingSystem.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BillingSystem.DAL.Repositories;

public class GenericRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task CreateAsync(TEntity entity, int? id = null)
    {
        await _dbSet.AddAsync(entity);
    }
	public async Task<IEnumerable<TEntity>> GetAllAsync(
		params Expression<Func<TEntity, object>>[] includes) {
		IQueryable<TEntity> query = _dbSet;

		foreach (var include in includes) {
			query = query.Include(include);
		}

		return await query.ToListAsync();
	}


	public virtual async Task<TEntity> GetByIdAsync(int? id, bool tracking = false)
    {
        var entity = await _dbSet.FindAsync(id);

        if (!tracking && entity != null) {
            _context.Entry(entity).State = EntityState.Detached;
        }

        return entity;
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (_context.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbSet.Attach(entityToDelete);
        }
        _dbSet.Remove(entityToDelete);
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        _dbSet.Attach(entityToUpdate);
        _context.Entry(entityToUpdate).State = EntityState.Modified;
    }
}