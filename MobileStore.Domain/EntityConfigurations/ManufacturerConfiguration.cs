using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.EntityConfigurations
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(e => e.ManufacturerId).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(64).IsRequired();
        }
    }
}
