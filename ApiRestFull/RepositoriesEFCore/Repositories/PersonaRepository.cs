using Entities;
using Entities.Interfaces;

namespace RepositoriesEFCore.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        readonly Context _context;

        public PersonaRepository(Context context)
        {
            this._context = context;
        }

        public void Add(Persona persona)
        {
            _context.Add(persona);
        }

        public IEnumerable<Persona> GetAll()
        {
            return _context.Persona;
        }
    }
}