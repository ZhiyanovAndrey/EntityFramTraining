using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramTraining
{
    public class Department
    {
        public int DepartmentId { get; set; } 
        public string Name { get; set; }
        
        //public Person Person { get; set; } // необязательное поле для удобства чтения
        //public ICollection<Person> Persons { get; set; } // связь с таблицей Person по столбцу 
    }
}
