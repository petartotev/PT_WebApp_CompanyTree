using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Repository.Interfaces
{
    public interface IRepository<TEntity, TPrimaryKey>
    {
        //Task<int> CreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity> CreateAsync(TEntity entity);
        //Task<int> DeleteAsync(string filterQuery, object filterParams = null);
        Task<int> DeleteAsync(TPrimaryKey primaryKey);
        Task<IList<TEntity>> GetAllAsync();
        //Task<IList<TEntity>> GetByKeysAsync(IEnumerable<TPrimaryKey> primaryKeys);
        Task<TEntity> GetSingleOrDefaultAsync(TPrimaryKey primaryKey);
        //Task<Page<TEntity>> PageAsync(int skip, int take);
        Task<int> UpdateAsync(TEntity entity);
    }
}
