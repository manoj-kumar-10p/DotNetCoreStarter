using AutoMapper;
using Api.Database.Base.Abstract;
using Api.Database.Base.Generic;
using Api.Database.Base.Interface;
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
    public class CarService : Service<ICarRepository, Car, CarDTO, long>, ICarService
    {
        private readonly ICarRepository CarRepository;
        private readonly IRequestInfo<ApiContext> _requestInfo;
        private readonly IMapper _mapper;

        public CarService(IUnitOfWork unitOfWork
            , ICarRepository repository, IRequestInfo<ApiContext> requestInfo,IMapper mapper)
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

        public Task<DataTransferObject<CarDTO>> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<DataTransferObject<List<CarDTO>>> GetByName(DataTransferObject<CarDTO> model)
        {
            throw new NotImplementedException();
        }
        public async Task<DataTransferObject<List<CarDTO>>> GetAll()
        {
            var result=await this.Repository.GetAll();
            var response= _mapper.Map<List<Car>, List<CarDTO>>(result.ToList());
            return new DataTransferObject<List<CarDTO>>(response);
        }
    }
}
