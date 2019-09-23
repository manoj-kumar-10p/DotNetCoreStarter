using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.Database.Base.Abstract;
using Swashbuckle.AspNetCore.Annotations;
using Api.ActionFilters;
using Api.Core.DTO;
using Api.Core.IService;

namespace Api.Controllers
{

    [Route("api/Auth")]
    public class AuthController : BaseController
    {

        private readonly IAuthService authService;

        public AuthController(IAuthService _authService)
        {
            this.authService = _authService;
        }

        // POST api/v1/auth/login
        [HttpPost("login")]
        [ValidateModel]
        [AllowAnonymous]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<LoginResponseDTO>))]
        public async Task<IActionResult> Post([FromBody]LoginDTO credentials)
        {
            var response = await this.authService.Login(credentials);
            return this.JsonResponse(response);
        }

        [HttpPost("logout")]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<bool>))]
        public async Task<IActionResult> Post()
        {
            var response = await this.authService.Logout();
            return this.JsonResponse(response);
        }

        //POST api/v1/auth/token/refresh
        [HttpPost("token/refresh")]
        [ValidateModel]
        [AllowAnonymous]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<LoginResponseDTO>))]
        public async Task<IActionResult> RefreshToken([FromBody]AuthStoreDTO tokenDto)
        {
            var response = await this.authService.RefreshToken(tokenDto);
            return this.JsonResponse(response);
        }

        //POST api/v1/auth/token/revoke
        [HttpPost("token/revoke")]
        [ValidateModel]
        [AllowAnonymous]
        [SwaggerResponse(200, Type = typeof(DataTransferObject<RevokeResponseDTO>))]
        public async Task<IActionResult> RevokeToken([FromBody]AuthStoreDTO tokenDto)
        {
            var response = await this.authService.RevokeToken(tokenDto);
            return this.JsonResponse(response);
        }
    }
}