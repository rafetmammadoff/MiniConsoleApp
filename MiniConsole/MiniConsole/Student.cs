using System;
using System.Collections.Generic;
using System.Text;

namespace MiniConsole
{
    internal class Student : Human
    {
        public Student(string name,string surname) :base(name,surname)
        {
                
        }
        public int Grade;
        public string  GroupNo;
        public override void ShowInfo()
        {
            Console.WriteLine($"Ad-{Name} - Soyad -{Surname } - Grade {Grade} - Group No {GroupNo}");
        }
    }
}
