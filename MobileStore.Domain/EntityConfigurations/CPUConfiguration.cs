using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.EntityConfigurations
{
    public class CPUConfiguration : IEntityTypeConfiguration<CPU>
    {
        public void Configure(EntityTypeBuilder<CPU> builder)
        {
            builder.Property(e => e.CPUId).ValueGeneratedOnAdd();
            builder.Property(e => e.CPUName).HasMaxLength(64).HasColumnName("CPU Name").IsRequired();
        }
    }
}
