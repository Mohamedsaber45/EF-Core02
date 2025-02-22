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
    class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedNever();

            builder.Property(c => c.Duration)
                   .HasColumnName("CourseDuration")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(c => c.Name)
                   .HasColumnName("CourseName")
                   .HasColumnType("NVARChAR(40)")
                   .IsRequired();

            builder.Property(c => c.Description)
                   .HasColumnName("CourseDescription")
                   .HasColumnType("NVARCHAR(350)")
                   .IsRequired(false);

            builder.HasOne(c => c.Topic)
                   .WithMany(t => t.Courses)
                   .HasForeignKey(c => c.TopicId)
                   .IsRequired();
        }
    }
}
