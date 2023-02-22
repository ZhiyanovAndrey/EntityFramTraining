using EntityFramTraining;
using Microsoft.EntityFrameworkCore;

using (var context = new Context())
{

    //var ppy = new Department { Name = "РРУ" };  // нужны скобки или нет????
    //var echk59 = new Department() { Name = "ЭЧК-59" };

    //Person Шутов = new Person { Name = "Сергей", SurName = "Шутов", Age = 59, Department = ppy };
    //Person Танонов = new Person { Name = "Денис", SurName = "Танонов", Age = 51, Department = ppy };


    //// добавляем их в бд
    //context.Departments.Add(ppy); //Persons является типом dbset который нам предоставил EF
    //context.Departments.Add(echk59);
    //context.Persons.Add(Шутов);
    //context.Persons.Add(Танонов);
    //context.SaveChanges();
    //Console.WriteLine("Объекты успешно сохранены");





    // получаем объекты из бд и выводим на консоль
    var persons = context.Persons.Include(p => p.Department);
    Console.WriteLine("Users list:");
    foreach (var person in persons)
    {
        Console.WriteLine($"{person.Id}. {person.Name} {person.SurName} - {person.Age} работает в {person.Department.Name}");
    }
}
Console.ReadKey();  