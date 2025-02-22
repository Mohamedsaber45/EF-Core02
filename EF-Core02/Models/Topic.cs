﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
