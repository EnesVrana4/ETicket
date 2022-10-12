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
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;


        public TicketService(ITicketRepository TicketRepo, IMapper mapper, ICategoryRepository categoryRepo)
        {
            _TicketRepo = TicketRepo;
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }

        public TicketViewModel Add(TicketEditViewModel ticketViewModel)
        {
            Ticket ticket1 = _mapper.Map<Ticket>(ticketViewModel);

            _TicketRepo.Add(ticket1);
            _TicketRepo.SaveChanges();


            TicketViewModel ticketViewModelReturn = _mapper.Map<TicketViewModel>(ticket1);
            return ticketViewModelReturn;

        }
       public bool AddTicket(int categoryId,int numberOfTIcket)
        {
            Category category = _categoryRepo.Get(categoryId);
            if (category.NumOfTickets < numberOfTIcket)
            {
                return false;
            }

            for (int i = 0; i < numberOfTIcket; i++)
            {
                Ticket ticket = new Ticket()
                {
                    CategoryId = categoryId,
                };
                _TicketRepo.Add(ticket);
                _TicketRepo.SaveChanges();
            }

           
            
            
                category.NumOfTickets = category.NumOfTickets - numberOfTIcket;
                _categoryRepo.SaveChanges();
                return true;
            
          

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
       