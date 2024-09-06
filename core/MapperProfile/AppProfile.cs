using AutoMapper;
using hotel.Dtos;
using hotel.Entities;

public class AppProfile : Profile
{
    public AppProfile()
    {
        CreateMap<HotelRoomsDto, HotelRoom>().ReverseMap();
        //.ForMember(x => x.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
    }
}