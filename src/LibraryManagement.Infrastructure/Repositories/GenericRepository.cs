using System.Linq.Expressions;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly LibraryDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(LibraryDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbSet.AsNoTracking().ToListAsync();

    public async Task<TEntity?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

    public void Remove(TEntity entity) => _dbSet.Remove(entity);

    public void Update(TEntity entity) => _dbSet.Update(entity);
}
