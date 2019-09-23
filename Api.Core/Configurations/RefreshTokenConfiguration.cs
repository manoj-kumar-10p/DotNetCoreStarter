using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Common.Configuration
{
    public class RefreshTokenConfiguration
    {
        public double ValidFor { get; set; }
        public DateTime RefreshTokenExpiry => DateTime.UtcNow.AddMinutes(this.ValidFor);
    }
}
