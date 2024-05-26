namespace Barbie.Interfaces;
using Barbie.Dtos;


public interface IBarberService
{
    Task<BarberDto> Get(Guid barberId);
    Task<List<BarberDto>> GetAll();
    Task<BarberDto> Create(BarberCreateDto barber);
    Task<BarberDto> Delete(Guid barberId);
}