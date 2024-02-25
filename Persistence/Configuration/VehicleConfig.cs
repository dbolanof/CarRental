using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {

            builder.ToTable("Vehicle");

            builder.Property(e => e.IdVehicle)
                .IsUnicode()
                .IsRequired();
            builder.Property(e => e.IdPlaceDelivery).IsUnicode(false);
            builder.Property(e => e.IdPlacePickUp).IsUnicode(false);
            builder.Property(e => e.Brand);
            builder.Property(e => e.Color);
            builder.Property(e => e.Model);
            builder.Property(e => e.PlateNumbe);
        }
    }
}
