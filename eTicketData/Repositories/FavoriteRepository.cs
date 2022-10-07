using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;

namespace eTicketWebApp.Repositories
{
   
    
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly ApplicationDbContext _context;

        public FavoriteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Favorite> GetFavorites()
        {
            return _context.Favorites.ToList();
        }

        public Favorite GetFavorite(int id)
        {
            return _context.Favorites.FirstOrDefault(u => u.FavoriteId == id);
        }

        public Favorite UpdateFavorite(Favorite favorite)
        {
            _context.Update(favorite);
            _context.SaveChanges();

            return favorite;
        }

        
    }
}