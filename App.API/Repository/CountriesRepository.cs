using App.API.Contracts;
using App.API.Data;
using Microsoft.EntityFrameworkCore;

namespace App.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly StarWarsDbContext _context;

        public CountriesRepository(StarWarsDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Characters)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
