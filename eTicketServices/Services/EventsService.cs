using AutoMapper;
using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SharedComponents.ViewModel;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;

namespace eTicketServices.Services
{
    public class EventsService : IEventService
    {
       // private readonly ApplicationDbContext _context;

        private readonly IEventRepository _EventRepo;
        private readonly IMapper _mapper;


        public EventsService(IEventRepository EventRepo , IMapper mapper)
        {
            _EventRepo = EventRepo;
            _mapper = mapper;
        }

        public void Add(EventViewModel eventViewModel)
        {
            Event event1 = _mapper.Map<Event>(eventViewModel);

            _EventRepo.Add(event1);

        }

        public void Delete(int id)
        {
            Event event2 = _EventRepo.GetEvent(id);

            _EventRepo.Delete(event2);
        }

        public EventViewModel GetEvent(int id)
        {
            Event Event1 = _EventRepo.GetEvent(id);
            EventViewModel eventViewModel = _mapper.Map<EventViewModel>(Event1);
            return eventViewModel;
        }

        public ICollection<EventViewModel> GetEvents()
        {
            List<EventViewModel> EventViewModelList = new List<EventViewModel>();
            List<Event> Mylist = (List<Event>)_EventRepo.GetEvents();
           foreach(var event1 in Mylist)
            {
                EventViewModel eventViewModel =_mapper.Map<EventViewModel>(event1);
                EventViewModelList.Add(eventViewModel);
            }

           return EventViewModelList;
        }

        public void UpdateEvent(EventViewModel eventViewModel,int id)
        {
            Event event1 = _EventRepo.GetEvent(id);
            event1.Name= eventViewModel.Name;
            event1.Date = eventViewModel.Date;
            event1.Location = eventViewModel.Location;
            event1.Description = eventViewModel.Description;

            _EventRepo.UpdateEvent(); 
        } 
    }
}
