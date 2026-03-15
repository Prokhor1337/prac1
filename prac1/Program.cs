using prac1;
using prac1.Models;
using prac1.Data;

using var db = new AppDbContext();

db.Database.EnsureCreated();
Console.WriteLine("База даних готова");

var point = new RentalPoint { Address = "Центральний Парк" };
point.Scooters.Add(new Scooter { Model = "Xiaomi Pro 2", BatteryLevel = 95 });

db.RentalPoints.Add(point);
db.SaveChanges();
Console.WriteLine("Данні додані");

var allScooters = db.Scooters.ToList();
Console.WriteLine($"В бізі на разі самокатів: {allScooters.Count}");

var firstScooter = db.Scooters.First();
firstScooter.BatteryLevel = 50;
db.SaveChanges();
Console.WriteLine("Заряд самоката оновлено");

db.Scooters.Remove(firstScooter);
db.SaveChanges();
Console.WriteLine("Самокат видалено");