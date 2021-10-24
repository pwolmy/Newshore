using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BL.DATA;

namespace BL.Repositories.Implements
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly NewshoreContext _context;

        public GenericRepository(NewshoreContext context)
        {
            _context = context;
        }

        #region CRUD
        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {

            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<TEntity> Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete(int id)
        {
            TEntity entity = await GetById(id);
            if (entity == null)
                throw new Exception("The entity is null");

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        #endregion

        public NewshoreContext GetContext()
        {
            throw new NotImplementedException();
        }

        public bool ModelExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
