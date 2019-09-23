using Api.Database.Attribute;
using Api.Database.Base.Abstract;
using Api.Database.Enum;
using Api.Database.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Database.Base.Interface
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }

    public interface IService<TDTO, TKey> : IService
    {
        [AuditOperationAttribute(OperationType.Read)]
        Task<DataTransferObject<TDTO>> GetAsync(TKey id);

        [AuditOperationAttribute(OperationType.Read)]
        Task<int> GetCount();
        
        [AuditOperationAttribute(OperationType.Create)]
        Task<DataTransferObject<TDTO>> CreateAsync(TDTO dtoObject);

        [AuditOperationAttribute(OperationType.Update)]
        Task<DataTransferObject<TDTO>> UpdateAsync(TDTO dtoObject);

        [AuditOperationAttribute(OperationType.Delete)]
        Task DeleteAsync(TKey id);

        [AuditOperationAttribute(OperationType.Create)]
        Task<IList<TDTO>> CreateAsync(IList<TDTO> dtoObjects);

        [AuditOperationAttribute(OperationType.Delete)]
        Task DeleteAsync(IList<TKey> ids);

        [AuditOperationAttribute(OperationType.Update)]
        Task<IList<TDTO>> UpdateAsync(IList<TDTO> dtoObjects);

        [AuditOperationAttribute(OperationType.Delete)]
        Task BulkDelete(IList<TKey> ids);
    }

    public interface IService<TRepository, TEntity, TDTO, TKey> : IService<TDTO, TKey>
    {
        TRepository Repository { get; }
    }
}

