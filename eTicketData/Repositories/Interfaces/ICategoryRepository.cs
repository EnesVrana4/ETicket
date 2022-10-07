using eTicketData.Entities;
using eTicketData;

namespace eTicketData.Repositories.Interfaces
{
    public interface ICategoryRepository
    {

        ICollection<Category> GetCategorys();

        Category GetCategory(int id);

        Category UpdateCategory(Category category);
    }
}