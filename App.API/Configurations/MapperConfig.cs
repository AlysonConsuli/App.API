using App.API.Data;
using App.API.Models.Character;
using App.API.Models.Country;
using App.API.Models.Users;
using AutoMapper;

namespace App.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Character, CharacterDto>().ReverseMap();
            CreateMap<Character, CreateCharacterDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
