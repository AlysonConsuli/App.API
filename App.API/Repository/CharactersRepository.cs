using App.API.Contracts;
using App.API.Data;
using Microsoft.EntityFrameworkCore;

namespace App.API.Repository
{
    public class CharactersRepository : GenericRepository<Character>, ICharactersRepository
    {
        public CharactersRepository(StarWarsDbContext context) : base(context)
        {
        }
    }
}