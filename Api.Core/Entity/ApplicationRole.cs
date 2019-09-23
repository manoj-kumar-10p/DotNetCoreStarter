using Microsoft.AspNetCore.Identity;
using Api.Database.Base.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Core.Entity
{
    public class ApplicationRole: IdentityRole<long>, IAuditModel<long>
    {
        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
