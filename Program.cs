﻿using EntityFramTraining;






using (var context = new Context())
{

    var ppy = new Department { Name = "РРУ" };  // нужны скобки или нет????
    var echk59 = new Department() { Name = "ЭЧК-59" };

    Person Шутов = new Person { Name = "Сергей", SurName = "Шутов", Age = 59, Department = ppy };
    Person Танонов = new Person { Name = "Денис", SurName = "Танонов", Age = 51, Department = ppy };


    // добавляем их в бд
    context.Departments.Add(ppy); //Persons является типом dbset который нам предоставил EF
    context.Departments.Add(echk59);
    context.Persons.Add(Шутов);
    context.Persons.Add(Танонов);
    context.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");





    // получаем объекты из бд и выводим на консоль
    var users = context.Persons.ToList();
    Console.WriteLine("Users list:");
    foreach (Person item in users)
    {
        Console.WriteLine($"{item.Id}.{item.Name} - {item.Age}");
    }
}
Console.ReadKey();  