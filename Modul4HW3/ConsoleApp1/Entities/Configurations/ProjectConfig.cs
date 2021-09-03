using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Entities.Configurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Budget).IsRequired();
            builder.Property(a => a.StartedDate).IsRequired().HasMaxLength(7);
        }
    }
}
