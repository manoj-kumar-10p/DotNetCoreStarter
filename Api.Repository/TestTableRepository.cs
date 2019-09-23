using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;
using Api.Core.DbContext;
using Api.Core.Entity;
using Api.Core.IRepository;

namespace Api.Repositor
{
    public class TestTableRepository : AuditableRepository<TestTable, long, ApiContext>, ITestTableRepository
    {
        public TestTableRepository(IRequestInfo<ApiContext> requestInfo)
         : base(requestInfo)
        {
        }

        public Task<TestTable> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
