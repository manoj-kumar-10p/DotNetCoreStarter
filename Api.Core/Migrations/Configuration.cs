using Microsoft.AspNetCore.Identity;
using Api.Database.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Core.DbContext;
using Api.Core.Entity;
using Api.Core.Enum;

namespace Api.Core.Migrations
{
    public class Configurations
    {
        private readonly UserManager<ApplicationUser> userIdentityManager;
        private readonly ApiContext dbContext;
        private readonly IUnitOfWork unitOfWork;

        public Configurations(ApiContext _dbContext
            , IUnitOfWork _unitOfWork
            , UserManager<ApplicationUser> userManager
            )
        {
            dbContext = _dbContext;
            unitOfWork = _unitOfWork;
            userIdentityManager = userManager;
        }

        public async Task SeedData()
        {
            await SeedRolesAsync();
            await CreateSuperAdminAsync();
        }

        private async Task CreateSuperAdminAsync()
        {
            var superAdminUser = await userIdentityManager.FindByEmailAsync("superAdmin@tmh.com");
            if (superAdminUser == null)
            {
                var applicationUser = new ApplicationUser
                {
                    FirstName = "Test",
                    LastName = "SuperAdmin",
                    Email = "superAdmin@tmh.com",
                    PhoneNumber = "121212121",
                    UserType = (int)UserRole.SuperAdmin,
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    IsDeleted = false,
                    UserName = "superAdmin",
                    IsActive = true
                };
                var result = await userIdentityManager.CreateAsync(applicationUser, "B00km@rk");
                if (result.Succeeded)
                {
                    await userIdentityManager.AddToRoleAsync(applicationUser, UserRole.SuperAdmin.ToString());
                }
            }
        }

        private async Task SeedRolesAsync()
        {
            if (!dbContext.Roles.Any())
            {
                dbContext.Roles.Add(new ApplicationRole
                {
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = 1,
                    LastModifiedOn = DateTime.UtcNow,
                    IsDeleted = false,
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin"
                });

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
