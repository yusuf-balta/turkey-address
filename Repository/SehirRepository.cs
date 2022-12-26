using Microsoft.EntityFrameworkCore;
using turkey_address.Data;
using turkey_address.model;

namespace turkey_address.Repository
{
    public class SehirRepository : ISehirRepository
    {
        private readonly DataContext _context;

        public SehirRepository(DataContext _context)

        {
            this._context = _context;
        }
   

        public async Task<ICollection<Sehir>> getCitys()
        {
            return await  _context.Sehirler.OrderBy(e => e.SehirId).ToListAsync();
        }

    }

    public interface ISehirRepository
    {
        Task <ICollection<Sehir>> getCitys();
       
    }


}
