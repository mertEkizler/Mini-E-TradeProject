using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Domain.Entities.Common;

namespace Mini_E_TradeProject.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}