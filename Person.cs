using System;

namespace Inheritance
{
    class Person
    {
        protected string _name;

        public Person(string name) //создали конструктор
        {
            _name = name;// присвоили полю
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя{_name}");
        }

        
    }
}
