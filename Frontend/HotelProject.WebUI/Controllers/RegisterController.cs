﻿using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.RegisterDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateRegisterDTO createRegisterDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                UserName = createRegisterDTO.Username,
                Name = createRegisterDTO.Name,
                Surname = createRegisterDTO.Surname,
                Email = createRegisterDTO.Mail,
                WorkLocationID = 2
            };

            var result = await _userManager.CreateAsync(appUser, createRegisterDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
