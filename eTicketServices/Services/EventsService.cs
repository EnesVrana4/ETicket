using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using Microsoft.AspNetCore.Hosting;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class EventsService : IEventService
    {
        // private readonly ApplicationDbContext _context;

        private readonly IEventRepository _EventRepo;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _WebHostEnvironment;



        public EventsService(IEventRepository EventRepo, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _EventRepo = EventRepo;
            _mapper = mapper;
            _WebHostEnvironment = webHostEnvironment;
        }

        private string UploadFile(EventEditViewModel event1)
        {
            string fileName = null;
            if (event1.Image != null)
            {
                string Uploaddir = Path.Combine(_WebHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + event1.Image.FileName;
                string filePath = Path.Combine(Uploaddir, fileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    event1.Image.CopyTo(filestream);
                }
            }
            return fileName;
        }






        public EventViewModel Add(EventEditViewModel eventViewModel)
        {
          
            string StringFileName = UploadFile(eventViewModel);
            eventViewModel.Myimage = StringFileName;
            Event event1 = _mapper.Map<Event>(eventViewModel);
            //event1.Myimage = StringFileName;

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

        public EventViewModel GetLastCreated()
        {
            Event eventData = _EventRepo.GetLastCreated();
            EventViewModel eventViewModel = _mapper.Map<EventViewModel>(eventData);
            return eventViewModel;
        }
    }
}
