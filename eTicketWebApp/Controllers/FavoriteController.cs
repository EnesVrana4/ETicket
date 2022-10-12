//using eTicketServices.IServices;
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
    public class FavoriteController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IFavoriteService _favoriteService;

        private IdentityUser user;
        public FavoriteController(ILogger<HomeController> logger, IMapper mapper, IFavoriteService favoriteService)
        {
            _logger = logger;
            _mapper = mapper;
            _favoriteService = favoriteService;


        }
        //private readonly IEventService _service;



        public void OnGet()
        {
            var Favorite1 = new Favorite();
            var favoriteViewModel = _mapper.Map<FavoriteViewModel>(Favorite1); //convert project object to projectDTO;
        }
        [HttpGet]
        public IActionResult ShowEventFavorite()
        {

            //ViewBag.eventViewModel =  _eventService.GetEvent(2);

            ViewBag.favoriteViewModels = _favoriteService.GetAll();
            return View();
        }



        //[HttpGet]
        //public IActionResult CreateFavorite()
        //{
        //    return View();
        //}
        //            //[HttpGet]
        //            //public IActionResult Details(int id)
        //            //{
        //            //    FavoriteViewModel favoriteViewModel = _favoriteService.GetFavorite(id);
        //            //    ViewBag.MyFavorite = favoriteViewModel;
        //            //    return View();
        //            //}

        public IActionResult AddFavorite(int eventId)
        {


            _favoriteService.Add(eventId);
            return RedirectToAction("ShowEvent","Event");



            
        }
        


        
        public IActionResult CreateFavorite(int eventId)
        {
            //if (ModelState.IsValid)
            //{

               // _favoriteService.Add(favoriteEditViewModel);
                return RedirectToAction("ShowFavorite");


            //}
            return View("CreateFavorite");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            FavoriteEditViewModel favoriteEditViewModel = _favoriteService.GetEditFavorite(id);
            ViewBag.FavoriteId = id;
            return View(favoriteEditViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
