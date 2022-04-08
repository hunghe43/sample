using Microsoft.EntityFrameworkCore.Storage;
using Sample.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Core.Interface
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        T GetById(string id);

        IReadOnlyList<T> ListAll();

        T Add(T entity, bool saveChange = true);

        void Update(T entity, bool saveChange = true);

        void Delete(T entity, bool saveChange = true);

        void SaveChanges();

        IDbContextTransaction BeginTransaction();
        
        Task<T> GetByIdAsync(params object[] keyValues);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> AddAsync(T entity, bool saveChange = true);

        Task AddRangeAsync(IEnumerable<T> entities, bool saveChange = true);

        Task UpdateAsync(T entity, bool saveChange = true);

        Task DeleteAsync(T entity, bool saveChange = true);

        Task SaveChangesAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();

        IReadOnlyList<T1> ExecuteCommand<T1>(string query, Dictionary<string, object> parameters, System.Data.CommandType commandType);

        void SetAutoDetectChangesEnabled(bool value);
    }
}
