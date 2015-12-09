using System.Data.Entity.ModelConfiguration;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Infra.Persistence.Map
{
    public  class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Order");

            HasKey(x => x.Id);

            Property(x => x.Date).IsRequired();
            Property(x => x.Status).IsRequired();
            Ignore(x => x.Total);

            HasRequired(x => x.User);
            // 1 to N
            HasMany(x => x.OrderItem)
                .WithRequired(x => x.Order); 
        }
    }
}
