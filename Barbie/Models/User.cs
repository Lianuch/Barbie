namespace Barbie.Models;

public class User
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }

    public Admin? Admin { get; set; }
    public Client? Client { get; set; }
    public Barber? Barber{ get; set; }


    public Guid BarbershopId { get; set; }
    public Barbershop Barbershop { get; set; }

 
}