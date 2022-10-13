using AutoMapper;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketWebApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
          //  CreateMap<EventViewModel,Event>(); 
            CreateMap<Event,EventViewModel>(); 
            CreateMap<EventEditViewModel, Event>();
            CreateMap<Event, EventEditViewModel>();

            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryEditViewModel, Category>();
            CreateMap<Category,CategoryEditViewModel>();



            CreateMap<Ticket, TicketViewModel>();

            CreateMap<TicketEditViewModel, Ticket>();
            CreateMap<Ticket, TicketEditViewModel>();
            // CreateMap<Event, EventEditViewModel>();
            //CreateMap<EventViewModel,EventViewModel>();

            //CreateMap<MedicalCard, MedicalCardViewModel>();
            //CreateMap<MedicalCardEditViewModel, MedicalCard>();

            CreateMap<UserViewModel, AspNetUser>();
            CreateMap<AspNetUser, UserViewModel>();

            CreateMap<RoleViewModel, AspNetRole>();
            CreateMap<AspNetRole, RoleViewModel>();
        }
    }
}
