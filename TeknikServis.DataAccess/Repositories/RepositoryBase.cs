using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Core.Interfaces;
using TeknikServis.DataAccess.Context;

namespace TeknikServis.DataAccess.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly ServisContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(ServisContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
       
        public async Task<List<T>> GetAllAsync() => await _dbSet.ToListAsync();
      
        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task SaveAsync() =>await _context.SaveChangesAsync();
      
        public void Update(T entity)=> _dbSet.Update(entity);

        void IRepository<T>.Delete(T entity) => _dbSet.Remove(entity);
        
    }
}
