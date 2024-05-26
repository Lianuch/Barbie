using Barbie.Models;
namespace Barbie.Dtos;

public class BarberDto
{
    public Guid Id { get; set; }
    public string BarberClass { get; set; }
    public float BarberIncome { get; set; }
}