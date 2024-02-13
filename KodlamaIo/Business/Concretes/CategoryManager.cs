using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities;


namespace KodlamaIo.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
        
    }

    public string Delete(Category category)
    {
        return _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    
}
