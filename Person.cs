using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramTraining
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; } // поле Int не допускает Null поэтому и в БД NOT NULL
        public string Name { get; set; } // поле String допускает Null поэтому и в БД NULL
        public string SurName { get; set; }
        //public int DepartmentId { get; set; } // необязательгое поле, что бы cod convension не допускал NULL
        public Department Department { get; set; } // нотификационное поле говорит о том, что это FORAIGN KEY по одноименному столбцу



    }
}
