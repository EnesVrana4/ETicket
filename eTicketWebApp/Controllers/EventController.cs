//using eTicketServices.IServices;
using AutoMapper;
using eTicketData.Entities;
using eTicketServices.IServices;
using eTicketServices.Services;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharedComponents.ViewModel;
using System.Diagnostics;

namespace eTicketWebApp.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;
      

        private IdentityUser user;
        public EventController(ILogger<EventController> logger, IMapper mapper, IEventService eventService, ICategoryService categoryService)
        {
            _logger = logger;
            _mapper = mapper;
            _eventService = eventService;
            _categoryService = categoryService;
        }


 

        [HttpGet]
        public IActionResult ShowEvent()
        {
            //ViewBag.eventViewModel =  _eventService.GetEvent(2);

            ViewBag.eventViewModels = _eventService.GetEvents();
            return View();
        }
        [HttpPost]
        public IActionResult Search(string Name)
        {
            var search =_eventService.Search(Name);

            return RedirectToAction("ShowUserHomePage", "User", new{search=search});
        }
        [HttpPost]

        public IActionResult SearchByDate(DateTime Date)

        {

            List<Event> searchByDate = (List<Event>)_eventService.SearchByDate(DateTime.Now, Date);
            return RedirectToAction("ShowUserHomePage", "User", new { searchByDate = searchByDate });

        }



        [HttpGet]
        //[Authorize(Roles = "Manager")]

        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateEvent1()
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
        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult MenagerEventDetails(int id)
        {

            ViewBag.MyCategory = (List<CategoryViewModel>)_categoryService.GetByEventId(id);
            EventViewModel eventViewModel = _eventService.GetEvent(id);
            ViewBag.MyEvent = eventViewModel;
            return View();
        }



        [HttpPost]
        //[Authorize(Roles = AspNetRole.MANAGER)]
        public IActionResult CreateEvent(EventEditViewModel eventEditViewModel)
        {
            if (ModelState.IsValid)
            { 
                
                _eventService.Add(eventEditViewModel);
                EventViewModel eventViewModel = _eventService.GetLastCreated();
                
                return RedirectToAction("MenagerEventDetails" ,new {id = eventViewModel.EventId });

               // return RedirectToAction("ShowEvent");


            }
            return View("CreateEvent");
        }

        [HttpGet]
        [Authorize(Roles ="Manager")]
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
        [Authorize(Roles ="Manager")]

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
