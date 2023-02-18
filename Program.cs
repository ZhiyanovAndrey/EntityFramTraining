using EntityFramTraining;






using (var context = new Context())
{

    // получаем объекты из бд и выводим на консоль
    var users = context.Persons.ToList();
    Console.WriteLine("Users list:");
    foreach (Person item in users)
    {
        Console.WriteLine($"{item.Id}.{item.Name} - {item.Age}");
    }
}
Console.ReadKey();  