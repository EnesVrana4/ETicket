using AutoMapper;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketWebApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EventViewModel,Event>(); 
            CreateMap<Event,EventViewModel>();

            CreateMap<UserViewModel, AspNetUser>();
            CreateMap<AspNetUser, UserViewModel>();


        }
    }
}
