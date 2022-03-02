using contactosPruebas.Context;
using contactosPruebas.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace contactosPruebas.Services
{
    public class ContactoService : IContactoService
    {
        private readonly ContactosDbContext _dbContext;

        public ContactoService(ContactosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Contacto> Get()
        {
          return _dbContext.Contacto.AsQueryable();
        }

        public void Save(Contacto contacto)
        {
            _dbContext.AddRange(contacto);
            _dbContext.SaveChanges();
        }
    }
}
