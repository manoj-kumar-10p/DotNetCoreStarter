using Api.Database.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Database.Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuditOperationAttribute : System.Attribute
    {
        public AuditOperationAttribute(OperationType operationType)
        {
            this.OperationType = operationType;
        }

        public OperationType OperationType { get; set; }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuditOperationIgnoreAttribute : System.Attribute
    {
        public AuditOperationIgnoreAttribute()
        {
        }
    }
}
