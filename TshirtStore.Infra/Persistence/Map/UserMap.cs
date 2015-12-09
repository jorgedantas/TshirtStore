using System.Data.Entity.ModelConfiguration;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Infra.Persistence.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(x => x.Id);

            Property(x => x.Email)
                .HasMaxLength(160)
                .IsRequired();
        }
    }
}
