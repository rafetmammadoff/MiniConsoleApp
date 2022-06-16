using System;
using System.Collections.Generic;
using System.Text;

namespace MiniConsole
{
    class Baku : City
    {
        public  Human[] _humans = new Human[0];
        public Human[] Humans
        {
            get => _humans;

        }

        public void AddHuman(Human human)
        {
            Array.Resize(ref _humans, _humans.Length + 1);
            _humans[_humans.Length - 1] = human;
        }

        public Human[] SearchHuman(string text)
        {
            Human[] newHuman = new Human[0];
            for (int i = 0; i < _humans.Length; i++)
            {
                if ((_humans[i].Name+_humans[i].Surname).Contains(text))
                {
                    Array.Resize(ref newHuman, newHuman.Length + 1);
                    newHuman[newHuman.Length - 1] = _humans[i];
                }
            }
            return newHuman;
        }

        public Human[] GetEmployees()
        {
            Human[] employees = new Human[0];
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Employee)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = _humans[i];
                }
            }
            return employees;
        }
        public Human[] GetStudents()
        {
            Human[] students = new Human[0];
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Student)
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = _humans[i];
                }
            }
            return students;
        }
    }
}
