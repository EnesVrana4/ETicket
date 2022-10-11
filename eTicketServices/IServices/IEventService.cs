using Abp.Domain.Repositories;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface IEventService 
    {
        ICollection<EventViewModel> GetEvents();

        EventViewModel GetEvent(int id);

        EventViewModel UpdateEvent(EventEditViewModel event1, int id);
        EventViewModel Add(EventEditViewModel event1);
        void Delete(int id);


    }
}