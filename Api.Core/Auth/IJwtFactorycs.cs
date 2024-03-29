﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Api.Core.Entity;

namespace Api.Core.Auth
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity, string deviceId);

        ClaimsIdentity GenerateClaimsIdentity(ApplicationUser user, string deviceId, string role, string userName);
    }
}
