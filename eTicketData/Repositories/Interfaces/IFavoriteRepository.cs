using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    
    public interface IFavoriteRepository
    {
        ICollection<Favorite> GetFavorites();

        Favorite GetFavorite(int id);

        Favorite UpdateFavorite(Favorite favorite);
    }
}