namespace Barbie.Models;

public class Barbershop
{
    public Guid Id { get; set; }
    public ICollection<BarberBarbershop> BarberBarbershops { get; set; }
    public ICollection<BarbershopClient> BarbershopClients { get; set; }
    public ICollection<User>? Users { get; set; }
 
    public Location Location { get; set; }


}