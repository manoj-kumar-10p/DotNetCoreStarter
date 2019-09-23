using AutoMapper;
using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Core.DbContext;
using Api.Core.DTO;
using Api.Core.Entity;
using Api.Core.IRepository;
using Api.Core.IService;

namespace Api.Service
{
    public class TestTableService : Service<ITestTableRepository, TestTable, TestTableDTO, long>, ITestTableService
    {
        private readonly ITestTableRepository TestTableRepository;
        private readonly IRequestInfo<ApiContext> _requestInfo;
        private readonly IMapper _mapper;

        public TestTableService(IUnitOfWork unitOfWork
            , ITestTableRepository repository, IRequestInfo<ApiContext> requestInfo,IMapper mapper)
            : base(unitOfWork, repository)
        {
            _requestInfo = requestInfo;
            _mapper = mapper;
        }



        public Task BulkDelete(IList<long> ids)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IList<long> ids)
        {
            throw new NotImplementedException();
        }

        public Task<DataTransferObject<TestTableDTO>> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<DataTransferObject<List<TestTableDTO>>> GetByName(DataTransferObject<TestTableDTO> model)
        {
            throw new NotImplementedException();
        }
        public async Task<DataTransferObject<List<TestTableDTO>>> GetAll()
        {
            var result=await this.Repository.GetAll();
            var response= _mapper.Map<List<TestTable>, List<TestTableDTO>>(result.ToList());
            return new DataTransferObject<List<TestTableDTO>>(response);
        }
    }
}
