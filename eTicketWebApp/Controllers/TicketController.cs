using AutoMapper;
using eTicketData.Entities;
using eTicketServices.IServices;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedComponents.ViewModel;
using System.Diagnostics;

namespace eTicketWebApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly ITicketService _ticketService;
     
        private IdentityUser user;
        public TicketController(ILogger<HomeController> logger, IMapper mapper, ITicketService ticketService)
        {
            _logger = logger;
            _mapper = mapper;
            _ticketService = ticketService;


        }
        
        public void OnGet()
        {
            var ticket1 = new Ticket();
            var ticketViewModel = _mapper.Map<EventViewModel>(ticket1); //convert project object to projectDTO;
        }
        [HttpGet]
        public IActionResult ShowTicket()
        {

            ViewBag.ticketViewModels = _ticketService.GetTickets();
            return View();
        }



        //[HttpGet]
        //public IActionResult CreateTicket()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult Details(int id)
        {
            TicketViewModel ticketViewModel = _ticketService.GetTicket(id);
            ViewBag.MyTicket = ticketViewModel;
            return View();
        }


        [HttpPost]
        public IActionResult CreateTicket(TicketEditViewModel ticketEditViewModel)
        {
            if (ModelState.IsValid)
            {

                _ticketService.Add(ticketEditViewModel);
                return RedirectToAction("ShowTicket");


            }
            return View("CreateTicket");
        }
        [HttpPost]
        public IActionResult CreateTicket(int categoryId )
        {
            if (ModelState.IsValid)
            {

                _ticketService.AddTicket(categoryId);
                return RedirectToAction("ShowTicket");


            }
            return View("CreateTicket");
        }


        public IActionResult Delete(int id)
        {
            _ticketService.Delete(id);
            return RedirectToAction("ShowTicket");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
