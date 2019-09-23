using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Common.Configuration;
using Api.Core.Auth;
using Api.Core.DbContext;
using Api.Core.Entity;
using Api.Core.IRepository;
using Api.Core.IService;
using Api.Repositor;
using Api.Repository;
using Api.Service;


namespace Api.Api
{
    public class DependencyInjection
    {
        public void Map(IServiceCollection services, IConfiguration Configuration)
        {
            #region Configurations

            services.AddTransient<Core.Migrations.Configurations>();
            services.Configure<RefreshTokenConfiguration>(Configuration.GetSection("RefreshToken"));

            #endregion 

            #region Base
            services.AddHttpContextAccessor();
            services.AddScoped<IRequestInfo<ApiContext>, Recipe.NetCore.Infrastructure.RequestInfo<ApiContext>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<ApiContext>>();
            services.AddScoped(typeof(IService), typeof(Recipe.NetCore.Base.Generic.Service));
            #endregion

            #region Test
            services.AddScoped(typeof(ITestTableRepository), typeof(TestTableRepository));
            services.AddScoped(typeof(ITestTableService), typeof(TestTableService));
            #endregion

            #region Auth
            services.AddScoped<IJwtFactory, JwtFactory>();
            services.AddScoped(typeof(IAuthService), typeof(AuthService));
            services.AddScoped(typeof(IAuthRepository), typeof(AuthRepository));
            services.AddScoped<IPasswordHasher<ApplicationUser>, PasswordHasher<ApplicationUser>>();
            #endregion    
        }
    }
}
