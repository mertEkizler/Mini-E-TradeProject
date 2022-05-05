using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Domain.Entities.Common;
using Mini_E_TradeProject.Persistence.Contexts;
using System.Linq.Expressions;

namespace Mini_E_TradeProject.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T>
        where T : BaseEntity
    {
        private readonly ETradeDBContext _context;

        public ReadRepository(ETradeDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> query)
            => Table.Where(query);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> query)
            => await Table.FirstOrDefaultAsync(query);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FindAsync(Guid.Parse(id));
    }
}