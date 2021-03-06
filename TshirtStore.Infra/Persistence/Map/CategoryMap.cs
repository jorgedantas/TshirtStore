﻿using System.Data.Entity.ModelConfiguration;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Infra.Persistence.Map
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Title)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
