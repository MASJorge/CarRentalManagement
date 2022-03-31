using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = "1",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "System"
                },// pongo coma y agrego tantos colores como quiero y lo puedo hacer con otras entidades tambien

                new Colour
                {
                    Id = "2",
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Name = "Blue",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
