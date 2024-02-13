using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.Entities.Abstracts;

namespace KodlamaIo.Entities.Concretes;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

}
