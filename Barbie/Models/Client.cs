namespace Barbie.Models;

public class Client 
{
    public Guid Id { get; set; }
    public string phoneNumber { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<Review> Reviews { get; set; }
    public ICollection<Record> Records { get; set; }
    public ICollection<BarbershopClient> BarbershopClients { get; set; }


}