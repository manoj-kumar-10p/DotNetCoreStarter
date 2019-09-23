using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.Entity;

namespace Api.Core.IRepository
{
    public interface IAuthRepository: IAuditableRepository<AuthStore, long>
    {
    }
}
