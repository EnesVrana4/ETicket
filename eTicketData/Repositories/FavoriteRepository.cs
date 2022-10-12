using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTicketData.Repositories
{
   
    public class FavoriteRepository :  Repository<Favorite>, IFavoriteRepository
    {

        public FavoriteRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public IEnumerable<Favorite> GetMyFavorites()
        {
            var all = _context.Favorites.
                Where(e => e.CreatedBy == _context.CurrentUserId && e.IsActive == true).ToList();
            return all;
        }

        public void UpdateFavorite(Favorite favorite, int favoriteId)
        {
            throw new NotImplementedException();
        }

        //public void Update(Event entity)
        //{
        //    throw new NotImplementedException();
        //}

        // public Favorite FirstOrDefault(int eventId, string CurrentUserId)
        //{
        //    _context.fi
        //}
    }
}