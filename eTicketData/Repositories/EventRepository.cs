using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;

namespace eTicketData.Repositories
{

    public class EventRepository :  Repository<Event>, IEventRepository
    {

        public EventRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;


        //public virtual void Add(Event entity)
        //{
        //   entity.CreatedBy = _context.CurrentUserId;
        //    _entities.Add(entity);
        //    _appContext.SaveChanges();
        //}

        //public virtual void AddRange(IEnumerable<Event> entities)
        //{
        //    _entities.AddRange(entities);
        //}


        // public virtual void Update(Event entity)
        //{
        //    object value = _entities.Update(entity);
        //}

        //public virtual void UpdateRange(IEnumerable<Event> entities)
        //{
        //    _entities.UpdateRange(entities);
        //}

        //public virtual void Remove(Event entity)
        //{
        //    if (entity is eTicketData.Entities.IAuditableEntity)
        //    {

        //        var prop = entity.GetType().GetProperty("Status");
        //        prop.SetValue(entity, false);
        //        _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

        //    }
        //    else
        //        _entities.Remove(entity);
        //}

        //public virtual void RemoveRange(IEnumerable<Event> entities)
        //{
        //    foreach (var e in entities)
        //    {
        //        if (e is eTicketData.Entities.IAuditableEntity)
        //        {
        //            e.GetType().GetProperty("Status").SetValue(e, false);
        //        }
        //        else
        //            _entities.Remove(e);
        //    }
        //}

        //public virtual int Count()
        //{
        //    var alle = _entities.ToList();
        //    return _entities.Count();
        //}

        //public virtual Event Get(int id)
        //{

        //    var temp = _entities.Find(id);
        //    if (temp != null)
        //    {
        //        return temp;
        //    }
        //    return null;
        //}
        //public virtual IEnumerable<Event> GetAll()
        //{
        //    var all = _entities.ToList();
        //    return all;
        //}

    }
}