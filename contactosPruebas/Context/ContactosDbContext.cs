using contactosPruebas.ConfigurationEntity;
using contactosPruebas.Entities;
using Microsoft.EntityFrameworkCore;

namespace contactosPruebas.Context
{
    public class ContactosDbContext : DbContext
    {
        public ContactosDbContext(DbContextOptions<ContactosDbContext> options) : base(options)
        {
        }

        public DbSet<Contacto> Contacto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ContactoConfiguration());
        }
    }
}
