using Api.Database.Base.Generic;
using Api.Database.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api.Core.Entity;

namespace Api.Core.IRepository
{
    public interface ITestTableRepository : IAuditableRepository<TestTable, long>
    {
        Task<TestTable> GetByName(string name); 
    }
}
