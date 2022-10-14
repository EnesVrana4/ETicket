using Abp.Domain.Repositories;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface IEventService 
    {
        ICollection<EventViewModel> GetEvents();
        ICollection<EventViewModel> GetMyEvents();
        ICollection<EventViewModel> Search(string search);
        ICollection<EventViewModel> SearchByDate(DateTime start, DateTime end);

        EventViewModel GetEvent(int id);
        EventViewModel GetLastCreated();
        
        EventEditViewModel GetEditEvent(int id);

        EventViewModel UpdateEvent(EventEditViewModel event1, int id);
        EventViewModel Add(EventEditViewModel event1);
        void Delete(int id);
    }
}