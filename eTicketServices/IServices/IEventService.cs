using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface IEventService
    {
        ICollection<EventViewModel> GetEvents();

        EventViewModel GetEvent(int id);

        void UpdateEvent(EventViewModel event1, int id);
        void Add(EventViewModel event1);
        void Delete(int id);


    }
}