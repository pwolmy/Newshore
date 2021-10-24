using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Services;

using BL.Repositories;

namespace BL.Services.Implements
{
    public abstract class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        public IGenericRepository<TEntity> _genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public virtual async Task Delete(int id)
        {
            await _genericRepository.Delete(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _genericRepository.GetAll();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _genericRepository.GetById(id);
        }

        public virtual async Task<TEntity> Insert(TEntity entity)
        {
            return await _genericRepository.Insert(entity);
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            return await _genericRepository.Update(entity);
        }
    }
}
