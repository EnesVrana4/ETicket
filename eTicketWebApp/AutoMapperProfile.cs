using AutoMapper;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketWebApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EventViewModel,Event>(); //reverse so the both direction
            CreateMap<Event,EventViewModel>();
            //CreateMap<EventViewModel,EventViewModel>();



        }
    }
}
