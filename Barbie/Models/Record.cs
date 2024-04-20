namespace Barbie.Models;

public class Record
{ 
   public Guid Id { get; set; }
   public int Price { get; set; }
   public DateTime RecordDate { get; set; }

   
   public Guid BarberId { get; set; }
   public Barber Barber { get; set; }
    public Guid HaircutTypeId { get; set; } 

    public HaircutType HaircutType { get; set; } 

    public Guid ClientId { get; set; }
    public Client Client { get; set; }
    public Guid AdminId { get; set; }
    public Admin Admin { get; set; }

}