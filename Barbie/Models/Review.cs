namespace Barbie.Models;

public class Review
{
    public Guid Id { get; set; }

    public string Text { get; set; }
    public int Value { get; set; }
    
    public Guid BarberId{ get; set; }
    public Barber Barber{ get; set; }
    
    public Guid ClientId { get; set; }
    public Client Client { get; set; }
     public Guid AdminId { get; set; }
    public Admin Admin{ get; set; }
   

}