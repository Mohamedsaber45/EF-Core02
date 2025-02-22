using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; } = null!;

        public ICollection<Course_Instructor> Courses_Instructors { get; set; } = new List<Course_Instructor>();

        public ICollection<Student_Course> students_Courses { get; set; } = new List<Student_Course>();
    }
}
