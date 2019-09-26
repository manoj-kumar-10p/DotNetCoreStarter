using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.Database.Base.Interface;
using Api.Core.DbContext;
using Api.Core.IService;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Annotations;
using Api.Database.Base.Abstract;
using Api.Core.DTO;
using Microsoft.Extensions.Logging;
using Api.ActionFilters;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Cars")]
    [Authorize]
    public class CarController : BaseController
    {

        protected readonly ICarService CarService;
        protected readonly IRequestInfo<ApiContext> requestInfo;
        protected readonly ILogger<CarController> _logger;

        public CarController(ICarService _CarService, IRequestInfo<ApiContext> _requestinfo, ILogger<CarController> logger)
        {
            this.CarService = _CarService;
            this.requestInfo = _requestinfo;
            this._logger = logger;
        }

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<List<CarDTO>>))]
        [ValidateModel]
        [Route("Results")]
        public async Task<IActionResult> GetAllCarResults()
        {
            _logger.LogInformation("Get All Results Called...");  // This is just an example. logger can be injected to service layer as well..
            return this.JsonResponse(await CarService.GetAll());
        }
        
    }
}