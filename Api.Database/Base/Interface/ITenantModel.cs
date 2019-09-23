namespace Api.Database.Base.Interface
{
    public interface ITenantModel<TKey> : IAuditModel<TKey>
    {
        int? TenantId { get; set; }
    }
}
