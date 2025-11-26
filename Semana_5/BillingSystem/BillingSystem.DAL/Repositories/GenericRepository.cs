using System.Threading.Tasks;
using BillingSystem.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

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
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {

        IQueryable<TEntity> query = _dbSet;
        return await query.ToListAsync();
    }
    public virtual async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (_context.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbSet.Attach(entityToDelete);
        }
        _dbSet.Remove(entityToDelete);
    }
}