//using eTicketServices.IServices;
using AutoMapper;
using eTicketData.Entities;
using eTicketServices.IServices;
using eTicketServices.Services;
using eTicketWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedComponents.ViewModel;
using System.Diagnostics;
using static eTicketWebApp.Models.Constantss;

namespace eTicketWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private IdentityUser user;
        public CategoryController(ILogger<CategoryController> logger, IMapper mapper, ICategoryService categoryService)
        {
            _logger = logger;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult ShowCategory()
        {

            //ViewBag.eventViewModel =  _eventService.GetEvent(2);

            ViewBag.eventViewModels = _categoryService.GetCategorys();
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            CategoryViewModel categoryViewModel = _categoryService.GetCategory(id);
            ViewBag.MyCategory = categoryViewModel;
            return View();
        }


        [HttpGet]
        public IActionResult Create(int eventId)
        {
            ViewBag.eventId = eventId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryEditViewModel categoryEditViewModel, int eventId)
        {
            if (ModelState.IsValid)
            {

                _categoryService.Add(categoryEditViewModel, eventId);
                return RedirectToAction("ShowCategory");


            }
            return View("Create");
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Update(int id)
        {
            CategoryEditViewModel categoryEditViewModel = _categoryService.GetEditCategory(id);
            ViewBag.Id = id;
            return View(categoryEditViewModel);
        }

        [HttpPost]
        public IActionResult Update(CategoryEditViewModel categoryEditViewModel, int id)
        {
            if (ModelState.IsValid)
            {
                _categoryService.UpdateCategory(categoryEditViewModel, id);
                return RedirectToAction("ShowCategory");
            }

            return RedirectToAction("Update", new { id = id });
        }

        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("ShowCategory");
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
