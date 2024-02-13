using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    string Delete(Instructor instructor);
    List<Instructor> GetAll();
    Instructor GetById(int id);
}
