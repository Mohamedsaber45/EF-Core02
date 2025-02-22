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
    class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).ValueGeneratedNever();

            builder.Property(s => s.Fname)
                   .HasColumnName("FirstName")
                   .HasColumnType("NVARCHAR(50)")
                   .IsRequired();

            builder.Property(s => s.Lname)
                   .HasColumnName("LastName")
                   .HasColumnType("NVARCHAR(60)")
                   .IsRequired(false);

            builder.Property(s => s.Address)
                   .HasColumnName("StudentAddress")
                   .HasColumnType("NVARCHAR(200)")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(s => s.Age)
                   .HasColumnName("StudentAge")
                   .HasColumnType("INT")
                   .HasAnnotation("MinValue",17)
                   .HasAnnotation("MaxValue",25)
                   .IsRequired();

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentId)
                   .IsRequired();
        }
    }
}
