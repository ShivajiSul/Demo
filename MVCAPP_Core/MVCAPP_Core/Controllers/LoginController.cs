using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCAPP_Core.Interfaces;
using MVCAPP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;
        private readonly ISession username;
        public LoginController(IConfiguration config, ITokenService tokenService, IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
            username = httpContextAccessor.HttpContext.Session;
        }


        public IActionResult LoginIndex()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                return (RedirectToAction("Error"));
            }
            IActionResult response = Unauthorized();
            var validUser = GetUser(userModel);
            username.SetString("Username", validUser.UserName);
            if (validUser != null)
            {
                generatedToken = _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), validUser);
                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    return RedirectToAction("mainwindow");
                }
                else
                {
                    return (RedirectToAction("Error"));
                }
            }
            else
            {
                return (RedirectToAction("Error"));
            }
        }

        private UserDTO GetUser(UserModel userModel)
        {
            // Write your code here to authenticate the user     
            return _userRepository.GetUser(userModel);
        }

      
        [Route("mainwindow")]
        [HttpGet]
        public IActionResult MainWindow()
        {
            string token = HttpContext.Session.GetString("Token");
            if (token == null)
            {
                return (RedirectToAction("LoginIndex"));
            }
            if (!_tokenService.IsTokenValid(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), token))
            {
                return (RedirectToAction("Index","People"));
            }
            // ViewBag.Message = BuildMessage(token, 50);
            ViewBag.Message = "Congratulation You have Login Successfully";
            return View();
        }

        public IActionResult Error()
        {
            ViewBag.Message = "An error occured...";
            return View();
        }
        //Use this method when one want see token
        //private string BuildMessage(string stringToSplit, int chunkSize)
        //{
        //    var data = Enumerable.Range(0, stringToSplit.Length / chunkSize).Select(i => stringToSplit.Substring(i * chunkSize, chunkSize));
        //    string result = "The generated token is:";
        //    foreach (string str in data)
        //    {
        //        result += Environment.NewLine + str;
        //    }
        //    return result;
        //}
    }
}

