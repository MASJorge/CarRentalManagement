

using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = "1",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "Prius",
                },
                new Model
                {
                    Id="2",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "Corolla",
                },
                new Model
                {
                    Id = "3",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "3 Series",
                },
                new Model
                {
                    Id = "4",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedDate = DateTime.Now,
                    Name = "X2",
                }
                );
        }
    }
}
