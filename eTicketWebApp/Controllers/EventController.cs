//using eTicketServices.IServices;
using AutoMapper;
using eTicketData;
using eTicketData.Entities;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using SharedComponents.ViewModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace eTicketWebApp.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private ApplicationDbContext _context;
        public EventController(ILogger<HomeController> logger, IMapper mapper, ApplicationDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
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

        public void AddEvent()
        {
            var Event1 = new Event()
            {
                Name= "Cinema",
                Location = "Tirana",
                Description = "Very fun",
                Date = DateTime.Now,
                EventCreatorId=5,
                AspNetUserId = "ilgiiiadfakjrhfiufaegafgafg",
                UserId= "ilgiiiadfakjrhfiufaegafgafg"


            };
            var Event2 = new Event()
            {
                Name = "Theatre",
                Location = "Elbasan",
                Description = "Very fun",
                Date = DateTime.Now,
                EventCreatorId = 6,
                AspNetUserId = "ilgiiiadfakjrhfiufaeg",
                UserId = "ilgiiiadfakjrhfiufaegaffgdfhsghaerggafg"

            };
            _context.Events.Add(Event1);
            _context.Events.Add(Event2);
            _context.SaveChanges();

        }


        public void OnGet()
        {
            var Event1 = new Event();
            var eventViewModel = _mapper.Map<EventViewModel>(Event1); //convert project object to projectDTO;
        }

        public IActionResult ShowEvent()
        {

            Event Event1 =  _context.Events.FirstOrDefault(e=>e.EventCreatorId==5);
            ViewBag.eventViewModel = _mapper.Map<EventViewModel>(Event1);

            return View();
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
