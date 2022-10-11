using Abp.Domain.Repositories;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface IFavoriteService
    {
        ICollection<FavoriteViewModel> GetFavorites();

        FavoriteViewModel GetFavorite(int id);
        FavoriteEditViewModel GetEditFavorite(int id);

        FavoriteViewModel UpdateFavorite(FavoriteEditViewModel favorite1, int id);
        FavoriteViewModel Add(FavoriteEditViewModel favorite1);

        //void Delete(int id);


    }
}