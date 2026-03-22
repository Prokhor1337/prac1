namespace prac1.Models;

public class Scooter
{
    public int Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public int BatteryLevel { get; set; }
    
    public int RentalPointId { get; set; }
    public RentalPoint? RentalPoint { get; set; }
    public DateTime LastMaintenanceDate { get; set; } = DateTime.UtcNow;
}