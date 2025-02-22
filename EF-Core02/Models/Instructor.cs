using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double? Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; } = null!;
        public double HourRate { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Course_Instructor> Courses_Instructors { get; set; } = new List<Course_Instructor>();
    }
}
