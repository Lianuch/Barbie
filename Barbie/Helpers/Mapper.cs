using AutoMapper;
using Barbie.Dtos;
using Barbie.Models;

namespace Barbie.Helpers;

public class Mapper : Profile 
{
    public Mapper()
    {
        CreateMap<Barber, BarberDto>();
        CreateMap<BarberDto, Barber>();
    }
}