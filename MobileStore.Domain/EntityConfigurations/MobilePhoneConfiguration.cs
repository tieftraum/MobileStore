using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.EntityConfigurations
{
    public class MobilePhoneConfiguration : IEntityTypeConfiguration<MobilePhone>
    {
        public void Configure(EntityTypeBuilder<MobilePhone> builder)
        {
            builder.Property(e => e.MobilePhoneId).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Size).HasMaxLength(32).IsRequired();
            builder.Property(e => e.Weight).HasMaxLength(32).IsRequired();
            builder.Property(e => e.ScreenSizeAndResolution).HasMaxLength(32).IsRequired();
            builder.Property(e => e.Price).HasColumnType("money").IsRequired();

            builder.HasOne(e => e.CPU).WithMany(e => e.Phones).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.OperatingSystem).WithMany(e => e.Phones).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Manufacturer).WithMany(e => e.Phones).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
