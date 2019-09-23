using Api.Database.Base.Generic;
using Api.Database.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.DbContext;
using Api.Core.Entity;
using Api.Core.IRepository;

namespace Api.Repository
{
    public class AuthRepository : AuditableRepository<AuthStore, long, ApiContext>, IAuthRepository
    {
        public AuthRepository(IRequestInfo<ApiContext> requestInfo)
         : base(requestInfo)
        {
        }
    }
}
