using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consoloapp.W2
{
    public class Employee
    {
        string name;
        int age;
        string position;
        public Employee(string name, int age, string position) {
            this.name= name;
            this.age = age;
            this.position = position;
        }

        public int Age {  get { return age; } set {  age = 20; } }
        public static void Main(string[] args)
        {
            var employee = new Employee("Kushal", 7, "student");
        }
    }
}
