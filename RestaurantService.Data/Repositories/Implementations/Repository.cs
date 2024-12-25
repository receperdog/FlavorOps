using Microsoft.EntityFrameworkCore;
using RestaurantService.Data.Repositories.Interfaces;
using RestaurantService.Models.Common;

namespace RestaurantService.Data.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly FlavorOpsDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(FlavorOpsDbContext flavorOpsDbContext)
    {
        _context = flavorOpsDbContext;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.Where(e => !e.IsDeleted).ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.Where(e => e.Id == id && !e.IsDeleted).FirstOrDefaultAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public Task UpdateAsync(T entity)
    {
         _dbSet.Update(entity);
         return Task.CompletedTask;
    }

    public Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        return Task.CompletedTask;
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}