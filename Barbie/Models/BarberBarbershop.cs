namespace Barbie.Models;

public class BarberBarbershop
{
    public Guid BarbershopId { get; set; }
    public Barbershop Barbershop { get; set; }
    public Guid BarberId { get; set; }
    public Barber Barber { get; set; }
}