using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tutorial
{
    internal class Student
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }

        public Student() // a default constructor (a constructor that takes no parameters)
        {
            Id = -1;
            Firstname = "NO NAME";
            Age = -1;
            DateCreated = new DateTime(2023, 2, 1);
        }

        public Student(string firstname, int age) // a constructor using parameters
        {
            Firstname = firstname;
            Age = age;
        }

        public Student(int id, string firstname, int age)
        {
            Id = id;
            Firstname = firstname;
            Age = age;
        }


        public void IncrementAge()
        {
            Age = Age + 1;
        }

        public void ChangeFirstName(string Firstname)
        {
            this.Firstname = Firstname;
            //   property =  parameter
            // this. is used to call a propety or method in a class i.e. to distinguish the property Firstname and the parameter Firstname
        }

        public string CalcCreateDatePlus30Days()
        {
           return DateCreated.AddDays(30).ToString("MM/dd/yyyy");
        }


    }
}
