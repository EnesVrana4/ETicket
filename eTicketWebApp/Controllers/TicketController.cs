using Abp.Runtime.Validation.Interception;
using AutoMapper;
using eTicketData.Entities;
using eTicketServices.IServices;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedComponents.ViewModel;
using System.Diagnostics;
using static eTicketWebApp.Models.Constantss;

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


        //[HttpPost]
        //public IActionResult CreateTicket(TicketEditViewModel ticketEditViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _ticketService.Add(ticketEditViewModel);
        //        return RedirectToAction("ShowTicket");


        //    }
        //    return View("CreateTicket");
        //}
        [Authorize(Roles =" User")]

        public IActionResult CreateTicket(int numberOfTicket,int categoryId,int eventId)
        {
            var succses = _ticketService.AddTicket(categoryId, numberOfTicket);
                if (!succses)
            {

                return RedirectToAction("Details" ,"Event", new { id = eventId , alert="Reservation Failed! Please do not exceed the number of tickets in stock. Try again!"});
            }
            else
            {
                return RedirectToAction("Details", "Event", new { id = eventId, alert = "Reservation was SUCCESSFUL! Have fun!"});
                }
        }

        [Authorize(Roles = " Manager")]

        public IActionResult Delete(int id)
        {
            _ticketService.Delete(id);
            return RedirectToAction("ShowTicket");
        }

        [Authorize(Roles = "Manager")]

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
