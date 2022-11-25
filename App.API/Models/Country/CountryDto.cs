using App.API.Models.Character;

namespace App.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public IList<CharacterDto> Characters { get; set; }
    }

}
