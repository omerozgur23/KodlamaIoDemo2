using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    private List<Course> courses;
    private string message = "No course found with the specified id: ";

    public CourseDal()
    {

        courses = new List<Course>();
        //{
        //    new Course()
        //    {
        //        Id = 1,
        //        Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",
        //        Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip döküman ve duyurularını buradan yapacağız.",
        //        ImgUrl = "img1.jpg",
        //        Price = 0
        //    }
        //};
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }


    public void Update(Course course)
    {
        var update = courses.FirstOrDefault(c => c.Id == course.Id);
        if (update != null)
        {
            update.Name = course.Name;
            update.Description = course.Description;
            update.ImgUrl = course.ImgUrl;
            update.Price = course.Price;
        }
        else
        {
            Console.WriteLine(message + course.Id);
        }
    }


    public string Delete(Course course)
    {
        var delete = courses.FirstOrDefault(c => c.Id == course.Id);
        if (delete != null)
        {
            string deleteCourseName = "Deleted course: " + delete.Name;
            courses.Remove(delete);
            return deleteCourseName;
        }
        else
        {
            
            return message + course.Id;
        }
    }

    public Course GetById(int id)
    {
        var course = courses.FirstOrDefault(c => c.Id == id);
        return course;
    }

    public List<Course> GetAll()
    {
        return courses;
    }
}
