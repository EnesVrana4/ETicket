﻿using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Xml.Linq;
using static eTicketWebApp.Models.Constantss;
namespace eTicketWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IRoleService _roleService;
        private readonly IEventService _eventService;

        public UserController(IUnitOfWork unitOfWork, SignInManager<AspNetUser> signInManager, IRoleService roleService, IEventService eventService)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _roleService = roleService;
            _eventService = eventService;
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            
            var users = _unitOfWork.User.GetUsers();
            return View(users);
        }

        public IActionResult Profile()
        {   
            if(!User.Identity?.IsAuthenticated ?? false) 
            {
                return Redirect("~/Identity/Account/Login");
            }

            return View();
        }
        public async Task<IActionResult> HomePageAsync()
        {
            if (!User.Identity?.IsAuthenticated ?? false)
                return ShowUnAuthenticatedHomePage();

            if (User.IsInRole("User"))
                return ShowUserHomePage(null,DateTime.MaxValue);

            else if (User.IsInRole(AspNetRole.ADMIN))
                return ShowAdminHomePage();

            return ShowManagerdHomePage();

        }
        private IActionResult ShowUnAuthenticatedHomePage()
        {
            return View();
        }
        public IActionResult ShowManagerdHomePage()
        {
            ViewBag.MYEvents = _eventService.GetMyEvents();
            return View("ManagerHomePage");
        }

        private IActionResult ShowAdminHomePage()
        {
           ViewBag.AllUsers = _unitOfWork.User.GetUsers();
            return View("AdminHomePage");
        }
        
        public IActionResult ShowUserHomePage(string Name ,DateTime Date)
        {

            ViewBag.Events = _eventService.GetEvents();

            if (!String.IsNullOrEmpty(Name))
            {
                ViewBag.Events = _eventService.Search(Name);
            }
            if (Date >=DateTime.Now)
            {
                ViewBag.Events = _eventService.SearchByDate(DateTime.Now, Date);
            }


            return View("HomePage");
        }


        public  IActionResult ManagerPage()
        {
            string CurrentUserId =  _unitOfWork.User.GetCurrentUser();
            return View();

        }


        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = _unitOfWork.User.GetUser(id);
            var roles = _unitOfWork.Role.GetRoles();

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);

            var roleItems = roles.Select(role =>
                new SelectListItem(
                    role.Name,
                    role.Id,
                    userRoles.Any(ur => ur.Contains(role.Name)))).ToList();

            var vm = new EditUserViewModel
            {
                User = user,
                Roles = roleItems
            };

            return View(vm);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        {

            var user = _unitOfWork.User.GetUser(data.User.Id);
            if (user == null)
            {
                return NotFound();
            }

            var selectedRoles = data.Roles.Where(r => r.Selected)
                                          .Select(r=> r.Text);
            var result = await _signInManager.UserManager.AddToRolesAsync(user, selectedRoles);
            //if (!result.Succeeded)
            //    throw new Exception();

            var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);
            var rolesToAdd = new List<string>();
            var rolesToDelete = new List<string>();

            foreach (var role in data.Roles)
            {
                var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
                if (role.Selected)
                {
                    if (assignedInDb == null)
                    {
                        rolesToAdd.Add(role.Text);
                    }
                }
                else
                {
                    if (assignedInDb != null)
                    {
                        rolesToDelete.Add(role.Text);
                    }
                }
            }

            if (rolesToAdd.Any())
            {
                await _signInManager.UserManager.AddToRolesAsync(user, rolesToAdd);
            }

            if (rolesToDelete.Any())
            {
                await _signInManager.UserManager.RemoveFromRolesAsync(user, rolesToDelete);
            }

            user.FirstName = data.User.FirstName;
            user.LastName = data.User.LastName;
            user.Email = data.User.Email;

            _unitOfWork.User.UpdateUser(user);

            return RedirectToAction("Edit", new { id = user.Id });
        }
    }
}
