using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCAPP_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.Controllers
{
    public class LoginC : Controller
    {

        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;

        public Login(IConfiguration config, ITokenService tokenService, IUserRepository userRepository)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
