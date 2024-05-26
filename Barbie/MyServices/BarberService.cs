using Barbie.Data;
using Barbie.Dtos;
using Barbie.Interfaces;
using Barbie.Models;
using Microsoft.EntityFrameworkCore;

namespace Barbie.Services;

public class BarberService : IBarberService
{
    private readonly DataContext _context;

    public BarberService(DataContext context)
    {
        _context = context;
    }

    public async Task<BarberDto> Get(Guid barberId)
    {
        var barber = await _context.Barbers.FirstOrDefaultAsync(b => b.Id == barberId);

        if (barber == null)
        {
            throw new Exception("Barber not found");
        }

        return new BarberDto()
        {
            Id = barber.Id,
            BarberClass = barber.BarberClass,
            BarberIncome = barber.BarberIncome
        };
    }

    public async Task<List<BarberDto>> GetAll()
    {
        var barbers = await _context.Barbers.ToListAsync();

        if (barbers == null)
        {
            throw new Exception("Barbers not found");
        }

        var barbersDto = barbers.Select(b => new BarberDto()
        {
            Id = b.Id,
            BarberClass = b.BarberClass,
            BarberIncome = b.BarberIncome
        }).ToList();

        return barbersDto;
    }

    public async Task<BarberDto> Create(BarberCreateDto barberDto)
    {
        var barber = new Barber()
        {
            BarberIncome = barberDto.BarberIncome,
            BarberClass = barberDto.BarberClass
        };

        await _context.AddAsync(barber);

        await _context.SaveChangesAsync();
        
        return new BarberDto()
        {
            Id = barber.Id,
            BarberClass = barber.BarberClass,
            BarberIncome = barber.BarberIncome
        };
    }

    public async Task<BarberDto> Delete(Guid barberId)
    {
        var barber = await _context.Barbers.FirstOrDefaultAsync(b=>b.Id == barberId);
        if (barber == null)
        {
            throw new Exception("Barber not found");
        }

        _context.Barbers.Remove(barber);

        await _context.SaveChangesAsync();
        
        return new BarberDto()
        {
            Id = barber.Id,
            BarberClass = barber.BarberClass,
            BarberIncome = barber.BarberIncome,
        };

    }


}