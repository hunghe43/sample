using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Sample.Core.Entities;
using Sample.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Core.Repository
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;
        protected readonly IHttpContextAccessor _httpContextAccessor;

        public EfRepository(DbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual T GetById(string id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T Add(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Add(entity);
            if (saveChange)
                _dbContext.SaveChanges();

            return entity;
        }

        public void Update(T entity, bool saveChange = true)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            if (saveChange)
                _dbContext.SaveChanges();
        }

        public void Delete(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Remove(entity);
            if (saveChange)
                _dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _dbContext.Database.BeginTransaction();
        }

        public virtual async Task<T> GetByIdAsync(params object[] keyValues)
        {
            return await _dbContext.Set<T>().FindAsync(keyValues);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity, bool saveChange = true)
        {
            await _dbContext.Set<T>().AddAsync(entity);

            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }

            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, bool saveChange = true)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);

            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity, bool saveChange = true)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Remove(entity);
            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _dbContext.Database.BeginTransactionAsync();
        }

        public IReadOnlyList<T1> ExecuteCommand<T1>(string query, Dictionary<string, object> parameters, System.Data.CommandType commandType)
        {
            using (var cmd = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandType = commandType;
                cmd.CommandText = query;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(new { parameter.Key, parameter.Value });
                    }
                }
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                var result = new List<T1>();
                using (var reader = cmd.ExecuteReader())
                {
                    var propertyInfos = typeof(T1).GetProperties();
                    while (reader.Read())
                    {
                        var obj = (T1)Activator.CreateInstance(typeof(T1));
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (!reader.IsDBNull(i))
                            {
                                string fieldName = reader.GetName(i);
                                var propertyInfo = propertyInfos.FirstOrDefault(m => string.Equals(m.Name, fieldName, StringComparison.OrdinalIgnoreCase));

                                if (propertyInfo == null)
                                    continue;

                                propertyInfo.SetValue(obj, reader.GetValue(i));
                            }
                        }
                        result.Add(obj);
                    }
                }
                return result;
            }
        }

        public IReadOnlyList<dynamic> ExecuteCommandDynamic(string query, Dictionary<string, object> parameters, CommandType commandType, List<string> keys)
        {
            using var cmd = _dbContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = commandType;
            cmd.CommandText = query;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(new { parameter.Key, parameter.Value });
                }
            }
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            var result = new List<dynamic>();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                IDictionary<string, object> obj = new ExpandoObject();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    obj.Add(keys[i], reader.GetValue(i));
                }
                result.Add(obj);
            }
            return result;
        }

        public IReadOnlyList<Dictionary<string, object>> ExecuteCommandDictionary(string query, Dictionary<string, object> parameters, CommandType commandType, List<string> keys)
        {
            using var cmd = _dbContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = commandType;
            cmd.CommandText = query;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(new { parameter.Key, parameter.Value });
                }
            }
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            var result = new List<Dictionary<string, object>>();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> obj = new();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    obj.Add(keys[i], reader.GetValue(i));
                }
                result.Add(obj);
            }
            return result;
        }

        public async Task<IReadOnlyList<dynamic>> ExecuteCommandDynamicAsync(string query, Dictionary<string, object> parameters,
            System.Data.CommandType commandType, List<string> keys)
        {
            return await Task.Run(() => ExecuteCommandDynamic(query, parameters, commandType, keys));
        }

        public async Task<IReadOnlyList<T1>> ExecuteCommandAsync<T1>(string query, Dictionary<string, object> parameters,
            System.Data.CommandType commandType)
        {
            return await Task.Run(() => ExecuteCommand<T1>(query, parameters, commandType));
        }

        public void SetAutoDetectChangesEnabled(bool value)
        {
            _dbContext.ChangeTracker.AutoDetectChangesEnabled = value;
        }
    }
}
