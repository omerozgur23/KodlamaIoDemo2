using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts;

public interface ICategoryService
{
    void Add(Category category);
    void Update(Category category);
    string Delete(Category category);
    List<Category> GetAll();
    Category GetById(int id);
}
