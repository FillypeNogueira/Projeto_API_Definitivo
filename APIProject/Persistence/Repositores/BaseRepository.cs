using APIProject.Persistence.Context;

namespace APIProject.Persistence.Repositores
{
    public abstract class BaseRepository
    {
        private readonly DataAppDbContext _context;

        protected BaseRepository(DataAppDbContext context)
        {
            _context = context;
        }
    }
}