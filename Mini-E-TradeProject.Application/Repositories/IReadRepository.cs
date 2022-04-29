using Mini_E_TradeProject.Domain.Entities.Common;
using System.Linq.Expressions;

namespace Mini_E_TradeProject.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> query);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> query);

        Task<T> GetByIdAsync(string id);
    }
}