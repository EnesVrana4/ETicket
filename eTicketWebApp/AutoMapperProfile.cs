using AutoMapper;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketWebApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EventViewModel,Event>().ReverseMap(); //reverse so the both direction
            CreateMap<EventViewModel, Event>();
            CreateMap<EventViewModel, EventViewModel>();



        }
    }
}
