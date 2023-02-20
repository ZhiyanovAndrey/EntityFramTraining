using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramTraining
{
    public class Context : DbContext
    {

        public DbSet<Person> Persons { get; set; } // прописываем каждый класс для связи
        public DbSet<Department> Departments { get; set; } // прописываем каждый класс для связи

        public Context()
        {
            Database.EnsureDeleted(); // удаляет БД 
            Database.EnsureCreated(); // создает БД
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=postgres;Username=postgres;Password=User1234");
            /*Строка подключения содержит адрес сервера (параметр Host), порт (Port), 
             * название базы данных на сервере (Database),
             * имя пользователя в рамках сервера PostgreSQL (Username) и его пароль (Password).*/ 
        }

    }
}
