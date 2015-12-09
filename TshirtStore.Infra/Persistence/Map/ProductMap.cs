using System.Data.Entity.ModelConfiguration;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Infra.Persistence.Map
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(x => x.Id);

            Property(x => x.Description)
                .HasMaxLength(1024)
                .IsRequired();

            Property(x => x.Price)
                .IsRequired();

            Property(x => x.QuantityOnhand)
                .IsRequired();

            Property(x => x.Title)
                .IsRequired();

            HasRequired(x => x.Category);
        }
    }
}
