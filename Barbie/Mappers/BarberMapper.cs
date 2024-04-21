using Barbie.Dtos;
using Barbie.Models;

namespace Barbie.Mappers;

public  class BarberMapper
{
    public  BarberDto ToBarberDto(Barber barber)
    {
        return new BarberDto()
        {
            BarberClass = barber.BarberClass,
            BarberIncome = barber.BarberIncome,
            UserId = barber.UserId,
            Records = barber.Records,
            Reviews = barber.Reviews
            
            
        };
    }
}