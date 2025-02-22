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
    class Course_InstructorConfig : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.HasKey(ci => new { ci.InstructorId, ci.CourseId });

            builder.Property(ci => ci.Evaluation)
                   .HasConversion(
                      x => x.ToString(),
                      x => (Evaluation) Enum.Parse(typeof(Evaluation),x)
                   ).IsRequired();

            builder.HasOne(ci => ci.Instructor)
                   .WithMany(i => i.Courses_Instructors)
                   .HasForeignKey(ci => ci.InstructorId)
                   .IsRequired(false);

            builder.HasOne(ci => ci.Course)
                   .WithMany(c => c.Courses_Instructors)
                   .HasForeignKey(ci => ci.CourseId)
                   .IsRequired(false);
        }
    }
}
