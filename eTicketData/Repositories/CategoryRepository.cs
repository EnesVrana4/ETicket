using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;

namespace eTicketData.Repositories
{
   
   

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetCategorys()
        {
            return _context.Categorys.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categorys.FirstOrDefault(u => u.CategoryId == id);
        }

        public Category UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();

            return category;
        }

        
    }
}