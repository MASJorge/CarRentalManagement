using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = "1",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "BMW"
                },
                new Make
                {
                    Id="2",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "Toyota"
                }

                );
        }
    }
}
