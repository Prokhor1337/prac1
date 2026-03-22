using prac1.Data;
using prac1.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Додавання даних");
using (var db = new AppDbContext())
{
    var newUser = new User { FullName = "Прохор", PhoneNumber = "+380000000000" };
    db.Users.Add(newUser);
    
    Console.WriteLine($"Стан сутності до SaveChanges: {db.Entry(newUser).State}");
    
    db.SaveChanges();
    Console.WriteLine($"Дані збережено. Стан: {db.Entry(newUser).State}");
}

Console.WriteLine("\nОновлення (Change Tracking)");
using (var db = new AppDbContext())
{
    var user = db.Users.First();
    user.FullName = "Прохор Оновлений";
    
    Console.WriteLine($"Стан після зміни властиіості: {db.Entry(user).State}");
    
    db.SaveChanges();
    Console.WriteLine("Зміни зафіксовано в БД");
}

Console.WriteLine("\nВидалення");
using (var db = new AppDbContext())
{
    var user = db.Users.First();
    db.Users.Remove(user);
    Console.WriteLine($"Стан після Remove: {db.Entry(user).State}");
    
    db.SaveChanges();
    Console.WriteLine("Користувача видалено");
}