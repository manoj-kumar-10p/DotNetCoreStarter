using System;
using System.ComponentModel.DataAnnotations;
using Api.Database.Base.Interface;

namespace Api.Database.Base.Abstract
{
    public abstract class TenantEntityBase<TKey> : ITenantModel<TKey>
    {
        public TKey Id { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public int? TenantId { get; set; }
    }
}
