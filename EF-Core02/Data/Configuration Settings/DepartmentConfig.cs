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
    class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.Property(d => d.Name)
                   .HasColumnName("DepartmentName")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();

            builder.Property(d => d.HiringDate)
                   .HasColumnType("Date")
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.HasOne(d => d.Instructor)
                   .WithOne(i => i.Department)
                   .HasForeignKey<Department>(d => d.InstructorId);
        }
    }
}
