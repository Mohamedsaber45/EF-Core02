using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string? Lname { get; set; }
        public string Address { get; set; } = null!;
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Student_Course> Students_Courses { get; set; } = new List<Student_Course>();
    }
}
