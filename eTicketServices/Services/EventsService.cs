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

        public EventViewModel Add(EventEditViewModel eventViewModel)
        {
            Event event1 = _mapper.Map<Event>(eventViewModel);
          
            _EventRepo.Add(event1);
            _EventRepo.SaveChanges();


            EventViewModel eventViewModelReturn = _mapper.Map<EventViewModel>(event1);
            return eventViewModelReturn; 

        }

        public void Delete(int id)
        {
            Event event2 = _EventRepo.Get(id);

            _EventRepo.Remove(event2);
            _EventRepo.SaveChanges();

        }

        public EventViewModel GetEvent(int id)
        {
            Event eventData   = _EventRepo.Get(id);
            EventViewModel eventViewModel = _mapper.Map<EventViewModel>(eventData);
            return eventViewModel;
        }

       public EventEditViewModel GetEditEvent(int id)
        {
            Event eventData = _EventRepo.Get(id);
            EventEditViewModel eventViewModel = _mapper.Map<EventEditViewModel>(eventData);
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

        public EventViewModel UpdateEvent(EventEditViewModel eventViewModel, int eventId)
        {
            Event eventData = _EventRepo.Get(eventId);
            if ( eventData == null)
                return null;

            eventData = _mapper.Map(eventViewModel, eventData);

            _EventRepo.Update(eventData);
            _EventRepo.SaveChanges();

            return _mapper.Map<EventViewModel>(eventData);


        }

        public ICollection<EventViewModel> GetMyEvents()
        {
            List<EventViewModel> EventViewModelList = new List<EventViewModel>();
            List<Event> Mylist = (List<Event>)_EventRepo.GetMyEvents();
            foreach (var event1 in Mylist)
            {
                EventViewModel eventViewModel = _mapper.Map<EventViewModel>(event1);
                EventViewModelList.Add(eventViewModel);
            }

            return EventViewModelList;
        }
    }
}
