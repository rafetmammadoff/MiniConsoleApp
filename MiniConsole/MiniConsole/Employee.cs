using System;
using System.Collections.Generic;
using System.Text;

namespace MiniConsole
{
    class Employee : Human
    {
        public Employee(string name, string surname) : base(name, surname)
        {

        }
        public string Position;
        public override void ShowInfo()
        {
            Console.WriteLine($"Ad-{Name} - Soyad -{Surname } - Position {Position}");
        }
    }
}
