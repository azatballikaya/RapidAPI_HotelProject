using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.LoginDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelProject.WebUI.Controllers
{
    
    public class LoginController : Controller
    {
       
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDTO model)
        {
            if(ModelState.IsValid){
              
                var result=await _signInManager.PasswordSignInAsync(model.UserName,model.Password,true,true);
                if(result.Succeeded){
                    return RedirectToAction("Index","Staff");
                }
                else{
                    return View(model);
                }
            }
            return View();
        }
        
    }
}