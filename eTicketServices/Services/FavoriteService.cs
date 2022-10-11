using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class FavoriteService : IFavoriteService
    {
        // private readonly ApplicationDbContext _context;

        private readonly IFavoriteRepository _FavoriteRepo;
        private readonly IMapper _mapper;


        public FavoriteService(IFavoriteRepository FavoriteRepo, IMapper mapper)
        {
            _FavoriteRepo = FavoriteRepo;
            _mapper = mapper;
        }

        public FavoriteViewModel Add(FavoriteEditViewModel favoriteViewModel)
        {
            Favorite favorite1 = _mapper.Map<Favorite>(favoriteViewModel);

            _FavoriteRepo.Add(favorite1);
            _FavoriteRepo.SaveChanges();


            FavoriteViewModel favoriteViewModelReturn = _mapper.Map<FavoriteViewModel>(favorite1);
            return favoriteViewModelReturn;

        }

        //public void Delete(int id)
        //{
        //    Favorite favorite2 = _FavoriteRepo.Get(id);

        //    _FavoriteRepo.Remove(favorite2);
        //    _FavoriteRepo.SaveChanges();

        //}

        public FavoriteViewModel GetFavorite(int id)
        {
            Favorite favoriteData = _FavoriteRepo.Get(id);
            FavoriteViewModel favoriteViewModel = _mapper.Map<FavoriteViewModel>(favoriteData);
            return favoriteViewModel;
        }

        public FavoriteEditViewModel GetEditFavorite(int id)
        {
            Favorite favoriteData = _FavoriteRepo.Get(id);
            FavoriteEditViewModel favoriteViewModel = _mapper.Map<FavoriteEditViewModel>(favoriteData);
            return favoriteViewModel;
        }

        public ICollection<FavoriteViewModel> GetFavorites()
        {
            List<FavoriteViewModel> FavoriteViewModelList = new List<FavoriteViewModel>();
            List<Favorite> Mylist = (List<Favorite>)_FavoriteRepo.GetAll();
            foreach (var favorite1 in Mylist)
            {
                FavoriteViewModel favoriteViewModel = _mapper.Map<FavoriteViewModel>(favorite1);
                FavoriteViewModelList.Add(favoriteViewModel);
            }

            return FavoriteViewModelList;
        }

        public FavoriteViewModel UpdateFavorite(FavoriteEditViewModel favoriteViewModel, int favoriteId)
        {
            Favorite favoriteData = _FavoriteRepo.Get(favoriteId);
            if (favoriteData == null)
                return null;

            favoriteData = _mapper.Map(favoriteViewModel, favoriteData);

            _FavoriteRepo.Update(favoriteData);
            _FavoriteRepo.SaveChanges();

            return _mapper.Map<FavoriteViewModel>(favoriteData);


        }
    }
}