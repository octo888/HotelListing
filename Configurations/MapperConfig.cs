using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.Country;
using HotelListing.Models.Hotel;

namespace HotelListing.Configurations;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();
        CreateMap<Country, GetCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        
        CreateMap<Hotel, GetHotelDto>().ReverseMap();
    }
}
