using contactosPruebas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace contactosPruebas.ConfigurationEntity
{
    public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            builder.ToTable("Contacto");
            builder.HasKey(x => x.Id);

            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.Nombre).HasMaxLength(40);
       //     builder.Property(c => c.Nombre).Min(40);
            builder.Property(c => c.Apellido).HasMaxLength(40);
            builder.Property(c => c.Telefono).HasMaxLength(10);
        }
    }
}
