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

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> query, bool tracking = true)
        {
            var response = Table.Where(query);

            if (!tracking)
            {
                response = response.AsNoTracking();
            }

            return response;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> query, bool tracking = true)
        {
            var response = Table.AsQueryable();

            if (!tracking)
            {
                response = response.AsNoTracking();
            }

            return await response.FirstOrDefaultAsync(query);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        }
    }
}