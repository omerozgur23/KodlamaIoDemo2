using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    private List<Category> categories;
    private string message = "No category found with the specified id: ";

    public CategoryDal()
    {
        categories = new List<Category>();
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Update(Category category)
    {
        var update = categories.FirstOrDefault(c => c.Id == category.Id);
        if (update != null)
        {
            update.Name = category.Name;
        }
        else
        {
            Console.WriteLine(message + category.Id);
        }
    }

    public string Delete(Category category)
    {
        var delete = categories.FirstOrDefault(c => c.Id == category.Id);
        if (delete != null)
        {
            string deleteCategoryName = "Deleted category: " + delete.Name;
            categories.Remove(delete);
            return deleteCategoryName;
        }
        else
        {

            return message + category.Id;
        }
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
        var category = categories.FirstOrDefault(c => c.Id == id);
        return category;
    }

    
}
