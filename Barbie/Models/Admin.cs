namespace Barbie.Models;

public class Admin
{
    public Guid Id { get; set; }
    public float Salary { get; set; }
    public string WorkSchedule { get; set; }

    public Guid UserId { get; set; }
    public User User{ get; set; }
    public ICollection<Record> Records { get; set; }

   public ICollection<Review> Reviews { get; set; }

}