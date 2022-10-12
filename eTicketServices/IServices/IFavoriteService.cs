using Abp.Domain.Repositories;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface IFavoriteService
    {
        ICollection<FavoriteViewModel> GetFavoritesByEventId(int id);
        FavoriteViewModel GetFavorite(int id);
        FavoriteEditViewModel GetEditFavorite(int id);
        void Add(int eventId);
        ICollection<FavoriteViewModel> GetAll();     
        ICollection<FavoriteViewModel> GetMYFavorites();
    }
}