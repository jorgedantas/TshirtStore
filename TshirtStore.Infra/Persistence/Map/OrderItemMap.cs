using System.Data.Entity.ModelConfiguration;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Infra.Persistence.Map
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("OrderItems");

            HasKey(x => x.Id);

            Property(x => x.Price).IsRequired();
            Property(x => x.Quantity).IsRequired();

            HasRequired(x => x.Order);
            HasRequired(x => x.Product);

        }
    }
}
