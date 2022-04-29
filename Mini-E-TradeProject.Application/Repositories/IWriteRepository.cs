using Mini_E_TradeProject.Domain.Entities.Common;

namespace Mini_E_TradeProject.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> models);

        bool Remove(T model);

        bool RemoveRange(List<T> models);

        Task<bool> RemoveAsync(string id);

        Task<bool> UpdateAsync(string id);

        Task<int> SaveAsync();
    }
}