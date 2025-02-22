using EF_Core02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Course_Instructor
    {
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public Evaluation Evaluation { get; set; }
    }
}
