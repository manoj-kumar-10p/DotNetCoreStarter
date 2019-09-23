using Api.Database.Attribute;
using Api.Database.Enum;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Database.Base.Interface
{
    public interface IAuditableRepository<TEntity, TKey>: IRepository<TEntity, TKey>
    {
        [AuditOperationAttribute(OperationType.Delete)]
        Task HardDeleteAsync(TKey id);
        Task HardDeleteRangeAsync<TEntityList>(TEntityList entityList) where TEntityList : IQueryable;
    }
}
