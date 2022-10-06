using eTicketData.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eTicketWebApp.Controllers
{
    public class userController : Controller
    {
        private readonly IUserRepository userRepository;

        public userController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var test = userRepository.GetUsers();
            return View();
        }
    }
}
