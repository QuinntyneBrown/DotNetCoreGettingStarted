﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreGettingStarted.Features.Security
{
    public class AuthConfiguration
    {
        public string TokenPath { get; set; }
        public int ExpirationMinutes { get; set; }
        public string JwtKey { get; set; }
        public string JwtIssuer { get; set; }
        public string JwtAudience { get; set; }
        public string AuthType { get; set; }
    }
}