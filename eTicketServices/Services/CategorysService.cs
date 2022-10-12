using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class CategorysService : ICategoryService
    {
        // private readonly ApplicationDbContext _context;

        private readonly ICategoryRepository _CategoryRepo;
        private readonly IMapper _mapper;


        public CategorysService(ICategoryRepository CategoryRepo, IMapper mapper)
        {
            _CategoryRepo = CategoryRepo;
            _mapper = mapper;
        }

        public CategoryViewModel Add(CategoryEditViewModel categoryViewModel,int eventId)
        {
            Category category = _mapper.Map<Category>(categoryViewModel);
            category.EventId = eventId;
            _CategoryRepo.Add(category);
            _CategoryRepo.SaveChanges();


            CategoryViewModel categoryViewModelReturn = _mapper.Map<CategoryViewModel>(category);
            return categoryViewModelReturn; 

        }

        
        public void Delete(int id)
        {
            Category category = _CategoryRepo.Get(id);

            _CategoryRepo.Remove(category);
            _CategoryRepo.SaveChanges();

        }


        public CategoryViewModel GetCategory(int id)
        {
            Category category = _CategoryRepo.Get(id);
            CategoryViewModel categoryViewModel = _mapper.Map<CategoryViewModel>(category);
            return categoryViewModel;
        }

        public CategoryEditViewModel GetEditCategory(int id)
        {
            Category category = _CategoryRepo.Get(id);
            CategoryEditViewModel categoryViewModel = _mapper.Map<CategoryEditViewModel>(category);
            return categoryViewModel;
        }

        public ICollection<CategoryViewModel> GetCategorys()
        {
            List<CategoryViewModel> categoryViewModelList = new List<CategoryViewModel>();
            List<Category> Mylist = (List<Category>)_CategoryRepo.GetAll();
            foreach (var category in Mylist)
            {
                CategoryViewModel categoryViewModel = _mapper.Map<CategoryViewModel>(category);
                categoryViewModelList.Add(categoryViewModel);
            }

            return categoryViewModelList;
        }

        public CategoryViewModel UpdateCategory(CategoryEditViewModel categoryViewModel, int categoryId)
        {
            Category category = _CategoryRepo.Get(categoryId);
            if (category == null)
                return null;

            category = _mapper.Map(categoryViewModel, category);

            _CategoryRepo.Update(category);
            _CategoryRepo.SaveChanges();

            return _mapper.Map<CategoryViewModel>(category);


        }

        public ICollection<CategoryViewModel> GetByEventId(int eventId)
        {
            List<CategoryViewModel> categoryViewModelList = new List<CategoryViewModel>();
            List<Category> Mylist = (List<Category>)_CategoryRepo.GetByEventId(eventId);
            foreach (var category in Mylist)
            {
                CategoryViewModel categoryViewModel = _mapper.Map<CategoryViewModel>(category);
                categoryViewModelList.Add(categoryViewModel);
            }

            return categoryViewModelList;
        }
    }
}
