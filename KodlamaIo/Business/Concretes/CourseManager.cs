using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }


    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }


    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }


    public void Add(Course course)
    {
        _courseDal.Add(course);
    }


    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public string Delete(Course course)
    {
        return _courseDal.Delete(course);
    }
}
