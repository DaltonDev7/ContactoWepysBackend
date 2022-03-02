using contactosPruebas.Entities;
using System.Linq;

namespace contactosPruebas.Services
{
    public interface IContactoService
    {

        IQueryable<Contacto> Get();
        void Save(Contacto contacto);

    }
}
