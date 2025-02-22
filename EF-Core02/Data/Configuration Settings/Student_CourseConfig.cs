using EF_Core02.Enums;
using EF_Core02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Data.Configuration_Settings
{
    class Student_CourseConfig : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Property(sc => sc.Grade)
                   .HasConversion(
                      x => x.ToString(),
                      x => (Grades) Enum.Parse(typeof(Grades), x)
                   ).IsRequired();


            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Students_Courses)
                   .HasForeignKey(sc => sc.StudentId)
                   .IsRequired();

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.students_Courses)
                   .HasForeignKey(sc => sc.CourseId)
                   .IsRequired();
        }
    }
}
