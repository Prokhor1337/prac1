using prac1;
using prac1.Models;
using prac1.Data;

using var db = new AppDbContext();

db.Database.EnsureCreated();
Console.WriteLine("База данных готова.");

var point = new RentalPoint { Address = "Центральный Парк" };
point.Scooters.Add(new Scooter { Model = "Xiaomi Pro 2", BatteryLevel = 95 });

db.RentalPoints.Add(point);
db.SaveChanges();
Console.WriteLine("Данные добавлены!");

var allScooters = db.Scooters.ToList();
Console.WriteLine($"В базе сейчас самокатов: {allScooters.Count}");

var firstScooter = db.Scooters.First();
firstScooter.BatteryLevel = 50; // Разрядился
db.SaveChanges();
Console.WriteLine("Заряд самоката обновлен.");

db.Scooters.Remove(firstScooter);
db.SaveChanges();
Console.WriteLine("Самокат удален.");