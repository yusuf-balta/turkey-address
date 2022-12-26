using Microsoft.EntityFrameworkCore;
using turkey_address.Data;
using turkey_address.model;

namespace turkey_address.Repository
{
    public class SemtMahalleRepository : ISemtMahalleRepostiory
    {
        private readonly DataContext _context;

        public SemtMahalleRepository(DataContext _context)

        {
            this._context = _context;
        }
     
       

        public async Task<ICollection<SemtMahalle>> getStreets(int id)
        {
            return await _context.SemtMah.Where(e => e.ilceId==id).ToListAsync();
        }
    }

    public interface ISemtMahalleRepostiory
    {
        Task<ICollection<SemtMahalle>> getStreets(int id);

    }
}
