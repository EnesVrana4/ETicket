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
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;

        private IdentityUser user;
        public EventController(ILogger<HomeController> logger, IMapper mapper, IEventService eventService)
        {
            _logger = logger;
            _mapper = mapper;
            _eventService = eventService;


        }
        //private readonly IEventService _service;


        //public EventController(IEventService service)
        //{
        //    _service = service;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var data = await _service.GetAll();

        //    return View(data);
        //}

        //public void AddEvent()
        //{
        //    var Event1 = new Event()
        //    {
        //        Name= "Cinema",
        //        Location = "Tirana",
        //        Description = "Very fun",
        //        Date = DateTime.Now,
        //        //AspNetUserId = "3b1b42f9 - 144f - 45b9 - bb90 - 4b591166f05d"
        //    };
        //    var Event2 = new Event()
        //    {
        //        Name = "Theatre",
        //        Location = "Elbasan",
        //        Description = "Very fun",
        //        Date = DateTime.Now,
        //        //AspNetUserId = "3b1b42f9 - 144f - 45b9 - bb90 - 4b591166f05d"


        //    };

        //    //_context.Events.Add(Event1);
        //    //_context.Events.Add(Event2);
        //    //_context.SaveChanges();


        //}


        public void OnGet()
        {
            var Event1 = new Event();
            var eventViewModel = _mapper.Map<EventViewModel>(Event1); //convert project object to projectDTO;
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
