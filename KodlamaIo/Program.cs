// See https://aka.ms/new-console-template for more information

using KodlamaIo.Business.Abstracts;
using KodlamaIo.Business.Concretes;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Concretes;


ICourseService _courseService = new CourseManager(new CourseDal());
ICategoryService _categoryService = new CategoryManager(new CategoryDal());
IInstructorService _instructorService = new InstructorManager(new InstructorDal());

//******************************** Category created ********************************
_categoryService.Add(new Category()
{
    Id = 1,
    Name = "Programlama"
});

//******************************** Course created ********************************
_courseService.Add(new Course()
{
    Id = 1,
    Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",
    Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip döküman ve duyurularını buradan yapacağız.",
    ImgUrl = "img1.jpg",
    Price = 0,
    InstructorId = 1,
    CategoryId = 1
});

_courseService.Add(new Course()
{
    Id = 2,
    Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
    Description = "1.5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip döküman ve duyurularını buradan yapacağız.",
    ImgUrl = "img2.jpg",
    Price = 0,
    InstructorId = 2,
    CategoryId = 1
});

//******************************** Instructor created ********************************
_instructorService.Add(new Instructor()
{
    Id = 1,
    FirstName = "Engin",
    LastName = "Demiroğ",
    Email = "engin@gmail.com"
});

_instructorService.Add(new Instructor()
{
    Id = 2,
    FirstName = "Halit",
    LastName = "Kalaycı",
    Email = "halit@gmail.com"
});

//******************************** Course updated by id ********************************
_courseService.Update(new Course() { Id = 1, Name = "Java", Description = "desc", ImgUrl = "test", Price = 10, InstructorId = 2, CategoryId = 2 });
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

//******************************** Course deleted by id ********************************
string deletedCourseName = _courseService.Delete(new Course() { Id = 1 });
Console.WriteLine($"{deletedCourseName}");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

//******************************** Category list returned ********************************
foreach (Category category in _categoryService.GetAll())
{
    Console.WriteLine($"Category ID: {category.Id}");
    Console.WriteLine($"Category Name: {category.Name}");
    Console.WriteLine("--------------------------------------------");
}
Console.WriteLine();

//******************************** Course list returned ********************************
foreach (Course course in _courseService.GetAll())
{
    Console.WriteLine($"Course ID: {course.Id}");
    Console.WriteLine($"Course Name: {course.Name}");
    Console.WriteLine($"Course Description: {course.Description}");
    Console.WriteLine($"Course Image URL: {course.ImgUrl}");
    Console.WriteLine($"Course Price: {course.Price}");
    Console.WriteLine($"Instructor ID: {course.InstructorId}");
    Console.WriteLine($"Category ID: {course.CategoryId}");
    Console.WriteLine("--------------------------------------------");
}
Console.WriteLine();

//******************************** Instructor list returned ********************************
foreach (Instructor instructor in _instructorService.GetAll())
{
    Console.WriteLine($"Instructor ID: {instructor.Id}");
    Console.WriteLine($"Instructor Name: {instructor.FirstName + " " + instructor.LastName}");
    Console.WriteLine("--------------------------------------------");
}
Console.WriteLine();


//******************************** Course returned by id ********************************
var getCourse = _courseService.GetById(1);
if (getCourse != null)
{
    Console.WriteLine($"Course ID: {getCourse.Id}");
    Console.WriteLine($"Course Name: {getCourse.Name}");
    Console.WriteLine($"Course Description: {getCourse.Description}");
    Console.WriteLine($"Course Image URL: {getCourse.ImgUrl}");
    Console.WriteLine($"Course Price: {getCourse.Price}");
    Console.WriteLine("--------------------------------------------");
}
else
{
    Console.WriteLine("No course was found with the specified Id.");
}