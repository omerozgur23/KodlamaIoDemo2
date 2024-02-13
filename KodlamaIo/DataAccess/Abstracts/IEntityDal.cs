using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstracts;

public interface IEntityDal<T>
{
    void Add(T entity);
    void Update(T entity);
    string Delete(T entity);
    List<T> GetAll();
    T GetById(int id);
}
