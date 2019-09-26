using Api.Database.Base.Abstract;
using Api.Database.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api.Core.DTO;
using Api.Core.Entity;
using Api.Core.IRepository;

namespace Api.Core.IService
{
    public interface ICarService: IService<ICarRepository, Car, CarDTO, long>
    {
        Task<DataTransferObject<List<CarDTO>>> GetByName(DataTransferObject<CarDTO> model);

        Task<DataTransferObject<List<CarDTO>>> GetAll();

    }
}
