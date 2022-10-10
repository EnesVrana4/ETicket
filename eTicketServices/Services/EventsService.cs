using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class EventsService : IEventService
    {
        // private readonly ApplicationDbContext _context;

        private readonly IEventRepository _EventRepo;
        private readonly IMapper _mapper;


        public EventsService(IEventRepository EventRepo, IMapper mapper)
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
            Event event2 = _EventRepo.Get(id);

            _EventRepo.Remove(event2);
        }

        public EventViewModel GetEvent(int id)
        {
            Event Event1 = _EventRepo.Get(id);
            EventViewModel eventViewModel = _mapper.Map<EventViewModel>(Event1);
            return eventViewModel;
        }

        public ICollection<EventViewModel> GetEvents()
        {
            List<EventViewModel> EventViewModelList = new List<EventViewModel>();
            List<Event> Mylist = (List<Event>)_EventRepo.GetAll();
            foreach (var event1 in Mylist)
            {
                EventViewModel eventViewModel = _mapper.Map<EventViewModel>(event1);
                EventViewModelList.Add(eventViewModel);
            }

            return EventViewModelList;
        }

        public void UpdateEvent(EventViewModel eventViewModel, int eventId)
        {
            Event newEvent = _EventRepo.Get(eventId);


            newEvent = _mapper.Map<Event>(eventViewModel);


            _EventRepo.Update(newEvent);
        }
    }
}
