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
    class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).ValueGeneratedNever();

            builder.Property(i => i.Name)
                   .HasColumnName("InstructorName")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();

            builder.Property(i => i.Bonus)
                   .HasColumnType("float")
                   .IsRequired(false);

            builder.Property(i => i.Salary)
                   .HasAnnotation("MinValue", 3000)
                   .HasAnnotation("MaxValue", 15000)
                   .IsRequired();

            builder.Property(i => i.Address)
                   .HasColumnType("NVARCHAR(200)")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(i => i.HourRate)
                   .HasAnnotation("MinValue", 6)
                   .HasAnnotation("MaxValue", 12)
                   .IsRequired();

            builder.HasOne(i => i.Department)
                   .WithOne(d => d.Instructor)
                   .HasForeignKey<Instructor>(i => i.DepartmentId)
                   .IsRequired();
        }
    }
}
