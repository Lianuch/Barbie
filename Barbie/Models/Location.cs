namespace Barbie.Models;

public class Location
{
    public Guid Id { get; set; }
    public string Adress { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public Guid BarbershopId { get; set; }
    
    public Barbershop Barbershop { get; set; }
}