using Barbie.Models;
namespace Barbie.Dtos;

public class BarberDto
{
    public string BarberClass { get; set; }
    public float BarberIncome { get; set; }
    public Guid UserId { get; set; }
    public ICollection<Record> Records { get; set; }
    public ICollection<Review> Reviews { get; set; }

}