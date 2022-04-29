﻿using MVCAPP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.Interfaces
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        bool IsTokenValid(string key, string issuer, string token);
    }
}
