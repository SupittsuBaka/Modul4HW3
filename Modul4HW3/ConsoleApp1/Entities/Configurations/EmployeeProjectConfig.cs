using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Entities.Configurations
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.Property(a => a.Rate).IsRequired();
            builder.Property(a => a.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(a => a.EmployeeId).IsRequired();
            builder.Property(a => a.ProjectId).IsRequired();
        }
    }
}
