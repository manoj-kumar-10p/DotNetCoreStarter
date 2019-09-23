using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api.Core.DTO;
using Api.Core.Entity;
using Api.Core.IRepository;

namespace Api.Core.IService
{
    public interface ITestTableService: IService<ITestTableRepository, TestTable, TestTableDTO, long>
    {
        Task<DataTransferObject<List<TestTableDTO>>> GetByName(DataTransferObject<TestTableDTO> model);

        Task<DataTransferObject<List<TestTableDTO>>> GetAll();

    }
}
