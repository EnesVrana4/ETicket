using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using static eTicketWebApp.Models.Constantss;

namespace eTicketWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IRoleService _roleService;
        public UserController(IUnitOfWork unitOfWork, SignInManager<AspNetUser> signInManager, IRoleService roleService)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _roleService = roleService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            
            var users = _unitOfWork.User.GetUsers();
            return View(users);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> HomePageAsync()
        {
            if (!User.Identity?.IsAuthenticated ?? false)
                return ShowUnAuthenticatedHomePage();

            if (User.IsInRole(AspNetRole.MANAGER))
                return ShowManagerdHomePage();

            else if (User.IsInRole(AspNetRole.ADMIN))
                return ShowAdminHomePage();

            return ShowUserHomePage();

        }

        private IActionResult ShowUnAuthenticatedHomePage()
        {
            return View();
        }
        private IActionResult ShowManagerdHomePage()
        {
            return View("ManagerHomePage");
        }
        private IActionResult ShowAdminHomePage()
        {
            return View("ManagerHomePage");
            return View("AdminHomePage");
        }
        private IActionResult ShowUserHomePage()
        {
            return View("HomePage");
        }

        public  IActionResult ManagerPage()
        {
            string CurrentUserId =  _unitOfWork.User.GetCurrentUser();
            return View();

        }


        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
