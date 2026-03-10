namespace prac1.Models;

public class RentalPoint
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public int Capacity { get; set; }
    
    public List<Scooter> Scooters { get; set; } = new();
}