using AutoMapper;
using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using SharedComponents.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTicketServices.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _FavoriteRepo;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public FavoriteService(IFavoriteRepository FavoriteRepo, IMapper mapper, ApplicationDbContext context)
        {
            _FavoriteRepo = FavoriteRepo;
            _mapper = mapper;
            _context = context;
        }

        public void Add(int eventId)
        {
            if(_FavoriteRepo.GetAll().Any(e=>e.EventId == eventId && e.CreatedBy == _context.CurrentUserId))
            {
                Favorite favorite = _FavoriteRepo.GetAll().FirstOrDefault(e=>e.EventId == eventId && e.CreatedBy == _context.CurrentUserId);
                
                if (favorite.IsActive == true)       
                    _FavoriteRepo.Remove(favorite);
                else
                    _FavoriteRepo.Update(favorite);
                
                
                _FavoriteRepo.SaveChanges();
            }
            else
            {
                Favorite favorite = new Favorite()
                {
                    EventId = eventId
                };

                _FavoriteRepo.Add(favorite);
                _FavoriteRepo.SaveChanges();
            }
           }

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


        public ICollection<FavoriteViewModel> GetFavoritesByEventId(int eventId)
        {
                List<FavoriteViewModel> favoriteViewModelList = new List<FavoriteViewModel>();
                List<Favorite> Mylist = (List<Favorite>)_FavoriteRepo.GetFavoritesByEventId(eventId);
                foreach (var favorite in Mylist)
                {
                FavoriteViewModel favoriteViewModel = _mapper.Map<FavoriteViewModel>(favorite);
                    favoriteViewModelList.Add(favoriteViewModel);
                }

                return favoriteViewModelList;
            
        }

        public ICollection<FavoriteViewModel> GetAll()
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

        public ICollection<FavoriteViewModel> GetMYFavorites()
        {

            List<FavoriteViewModel> FavoriteViewModelList = new List<FavoriteViewModel>();
            List<Favorite> Mylist = (List<Favorite>)_FavoriteRepo.GetMyFavorites();
            foreach (var favorite1 in Mylist)
            {
                FavoriteViewModel favoriteViewModel = _mapper.Map<FavoriteViewModel>(favorite1);
                FavoriteViewModelList.Add(favoriteViewModel);
            }

            return FavoriteViewModelList;
        }
    }
}