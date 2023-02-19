using System;

namespace Inheritance
{
    class Employee : Person
    {
        private string _job;

        //public Employee(string name) : base(name) { }// создаем конструктор как в базовом, т.е делаем перегрузку

        public Employee(string name, string job) : base(name)//достаточно одного конструктора
        {
            _job = job;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Должность: {_job}");
        }
    }
}
