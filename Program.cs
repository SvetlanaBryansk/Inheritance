using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andrey");
       

            person.DisplayInfo();

            Employee employee = new Employee("Sasha", "Cashier");

           

            employee.DisplayInfo();
        }
    }
}
