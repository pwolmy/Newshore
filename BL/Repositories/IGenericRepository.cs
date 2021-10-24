using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();

        #region CRUD
        //ReadOne
        Task<TEntity> GetById(int id);

        //CREATE
        Task<TEntity> Insert(TEntity entity);

        //UPDATE
        Task<TEntity> Update(TEntity entity);

        //DELETE
        Task Delete(int id);
        #endregion

        //EXIST
        bool ModelExists(int id);

        //UniversityContext GetContext();
    }
}
