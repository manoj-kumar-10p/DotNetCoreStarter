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
    [Route("api/Tests")]
    [Authorize]
    public class TestController : BaseController
    {

        protected readonly ITestTableService testService;
        protected readonly IRequestInfo<ApiContext> requestInfo;
        protected readonly ILogger<TestController> _logger;

        public TestController(ITestTableService _testService, IRequestInfo<ApiContext> _requestinfo, ILogger<TestController> logger)
        {
            this.testService = _testService;
            this.requestInfo = _requestinfo;
            this._logger = logger;
        }

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<List<TestTableDTO>>))]
        [ValidateModel]
        [Route("Results")]
        public async Task<IActionResult> GetAllTestResults()
        {

            _logger.LogInformation("Get All Results Called...");  // This is just an example. logger can be injected to service layer as well..
            return this.JsonResponse(await testService.GetAll());
        }
    }
}