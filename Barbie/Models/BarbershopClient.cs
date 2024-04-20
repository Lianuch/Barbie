namespace Barbie.Models;

public class BarbershopClient
{
    public Guid BarbershopId { get; set; }
    public Barbershop Barbershop { get; set; }
    
    public Guid ClientId { get; set; }
    public Client Client { get; set; }
}