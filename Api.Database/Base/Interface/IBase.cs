using System.ComponentModel.DataAnnotations;

namespace Api.Database.Base.Interface
{
    public interface IBase<TKey> : IBase
    {
        [Key]
        TKey Id { get; set; }
    }

    public interface IBase
    {
    }
}

