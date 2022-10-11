using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class TicketService : ITicketService
    {
        // private readonly ApplicationDbContext _context;

        private readonly ITicketRepository _TicketRepo;
        private readonly IMapper _mapper;


        public TicketService(ITicketRepository TicketRepo, IMapper mapper)
        {
            _TicketRepo = TicketRepo;
            _mapper = mapper;
        }

        public TicketViewModel Add(TicketEditViewModel ticketViewModel)
        {
            Ticket ticket1 = _mapper.Map<Ticket>(ticketViewModel);

            _TicketRepo.Add(ticket1);
            _TicketRepo.SaveChanges();


            TicketViewModel ticketViewModelReturn = _mapper.Map<TicketViewModel>(ticket1);
            return ticketViewModelReturn;

        }
       public void AddTicket(int categoryId)
        {
            Ticket ticket = new Ticket()
            {
                CategoryId = categoryId,
            };
            _TicketRepo.Add(ticket);
            _TicketRepo.SaveChanges();

        }


        public void Delete(int id)
        {
            Ticket ticket2 = _TicketRepo.Get(id);

            _TicketRepo.Remove(ticket2);
            _TicketRepo.SaveChanges();

        }

        public TicketViewModel GetTicket(int id)
        {
            Ticket ticket2 = _TicketRepo.Get(id);
            TicketViewModel ticketViewModel = _mapper.Map<TicketViewModel>(ticket2);
            return ticketViewModel;
        }



        public ICollection<TicketViewModel> GetTickets()
        {
            List<TicketViewModel> TicketViewModelList = new List<TicketViewModel>();
            List<Ticket> Mylist = (List<Ticket>)_TicketRepo.GetAll();
            foreach (var ticket in Mylist)
            {
                TicketViewModel ticketViewModel = _mapper.Map<TicketViewModel>(ticket);
                TicketViewModelList.Add(ticketViewModel);
            }

            return TicketViewModelList;

        }
       


    }

   
}
       