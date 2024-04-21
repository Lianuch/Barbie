using Barbie.Models;

namespace Barbie.Dtos;

public class ReviewDto
{

    public string Text { get; set; }
    public int Value { get; set; }
    
    public Guid BarberId{ get; set; }
    
    public Guid ClientId { get; set; }
    public Guid AdminId { get; set; }
}