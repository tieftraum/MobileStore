using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.EntityConfigurations
{
    public class MyOperatingSystemConfiguration :
        IEntityTypeConfiguration<MyOperatingSystem>
    {
        public void Configure(EntityTypeBuilder<MyOperatingSystem> builder)
        {
            builder.Property(e => e.MyOperatingSystemId).ValueGeneratedOnAdd();
            builder.Property(e => e.OperatingSystemName).HasMaxLength(64);

        }
    }
}
