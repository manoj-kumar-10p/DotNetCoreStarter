using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api.Database.Base.Generic;
using Api.Database.Base.Interface;
using Api.Core.DbContext;
using Api.Core.Entity;
using Api.Core.IRepository;

namespace Api.Repositor
{
    public class CarRepository : AuditableRepository<Car, long, ApiContext>, ICarRepository
    {
        public CarRepository(IRequestInfo<ApiContext> requestInfo)
         : base(requestInfo)
        {
        }

        public Task<Car> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
