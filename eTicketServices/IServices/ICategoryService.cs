using Abp.Domain.Repositories;
using eTicketData.Entities;
using SharedComponents.ViewModel;

namespace eTicketServices.IServices
{
    public interface ICategoryService 
    {
        ICollection<CategoryViewModel> GetCategorys();

        CategoryViewModel GetCategory(int id);
        CategoryEditViewModel GetEditCategory(int id);

        CategoryViewModel UpdateCategory(CategoryEditViewModel category, int id);
        CategoryViewModel Add(CategoryEditViewModel category,int eventId);
        void Delete(int id);


    }
}