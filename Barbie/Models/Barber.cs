namespace Barbie.Models;

public class Barber
{
    public Guid Id { get; set; }
    public string BarberClass { get; set; }
    public float BarberIncome { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Record> Records { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<BarberBarbershop> BarberBarbershops { get; set; }
}