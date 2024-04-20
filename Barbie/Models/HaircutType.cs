namespace Barbie.Models;

public class HaircutType
{
    public Guid Id { get; set; }
    public string HairType { get; set; }
    public int Price { get; set; }
    public ICollection<Record> Records { get; set; } 

}