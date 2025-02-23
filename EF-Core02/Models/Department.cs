using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly HiringDate { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
