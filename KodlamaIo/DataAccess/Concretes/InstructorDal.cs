using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    private List<Instructor> instructors;
    private string message = "No instructor found with the specified id: ";

    public InstructorDal()
    {
        instructors = new List<Instructor>();
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        var update = instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (update != null)
        {
            update.FirstName = instructor.FirstName;
            update.LastName = instructor.LastName;
            update.Email = instructor.Email;
            
        }
        else
        {
            Console.WriteLine(message + instructor.Id);
        }
    }

    public string Delete(Instructor instructor)
    {
        var delete = instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (delete != null)
        {
            string deleteInstructor = "Deleted instructor: " + delete.FirstName + " " + delete.LastName;
            instructors.Remove(delete);
            return deleteInstructor;
        }
        else
        {

            return message + instructor.Id;
        }
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public Instructor GetById(int id)
    {
        var instructor = instructors.FirstOrDefault(i => i.Id == id);
        return instructor;
    }

    
}
