using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Core.DTO;
using Api.Core.Entity;

namespace Api.Mappings
{
    public class AutoMapperMappingProfile : Profile
    {
        public AutoMapperMappingProfile()
        {
            this.CreateMap<LoginDTO, ApplicationUser>();
            this.CreateMap<AuthStore, LoginDTO>();

        }
    }
}
