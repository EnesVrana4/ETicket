//using eTicketServices.IServices;
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
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;

        private IdentityUser user;
        public EventController(ILogger<EventController> logger, IMapper mapper, IEventService eventService)
        {
            _logger = logger;
            _mapper = mapper;
            _eventService = eventService;


        }
   


      
        [HttpGet]
        public IActionResult ShowEvent()
        {

            //ViewBag.eventViewModel =  _eventService.GetEvent(2);

            ViewBag.eventViewModels = _eventService.GetEvents();
            return View();
        }
     


        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            EventViewModel eventViewModel = _eventService.GetEvent(id);
            ViewBag.MyEvent = eventViewModel;
            return View();
        }


        [HttpPost]
        public IActionResult CreateEvent(EventEditViewModel eventEditViewModel)
        {
            if (ModelState.IsValid)
            { 
                
                _eventService.Add(eventEditViewModel);
                return RedirectToAction("ShowEvent");


            }
            return View("CreateEvent");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            EventEditViewModel eventEditViewModel = _eventService.GetEditEvent(id);
            ViewBag.EventId = id;
            return View(eventEditViewModel);
        }

        [HttpPost]
            public IActionResult Update(EventEditViewModel eventEditViewModel, int id)
        {
            if (ModelState.IsValid)
            { 
                 _eventService.UpdateEvent(eventEditViewModel, id);
                return RedirectToAction("ShowEvent");
            }

                //  EventViewModel eventViewModel1= _eventService.GetEvent(id);

                return RedirectToAction("Update", new { id = id });
            
        }
       
        public IActionResult Delete(int id)
        {
            _eventService.Delete(id);
            return RedirectToAction("ShowEvent");
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
