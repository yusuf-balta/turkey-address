using Microsoft.EntityFrameworkCore;
using turkey_address.Data;
using turkey_address.model;

namespace turkey_address.Repository
{
    public class IlceRepository : IIlceRepository
    {
        private readonly DataContext _context;

        public IlceRepository(DataContext _context)

        {
            this._context = _context;
        }
     
      

        public async Task<ICollection<Ilce>> getCountys(int SehirId)
        {
            return await _context.Ilceler.Where(e => e.SehirId==SehirId).ToListAsync();
        }
    }

    public interface IIlceRepository
    {
        Task<ICollection<Ilce>> getCountys(int id);
        

    }
}
