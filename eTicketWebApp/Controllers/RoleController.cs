using Castle.Core.Internal;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Data;


namespace eTicketWebApp.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = Constantss.Policies.RequireAdmin)]
        public IActionResult Manager()
        {
            return View();
        }

        //[Authorize(Policy = "RequireAdmin")]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}


