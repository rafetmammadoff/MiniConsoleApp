using System;
using System.Collections.Generic;
using System.Text;

namespace MiniConsole
{
    public class Human
    {
        public Human(string name, string surname)
        {
            _name = name;
            _surName = surname;
        }
        private string _name;
        private string _surName;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (CheckNameAndSurname(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surName;
            }
            set
            {
                if (CheckNameAndSurname(value))
                {
                    _surName = value;
                }
            }
        }
        public int Age;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ad-{_name} - Soyad -{_surName }");
        }

        public static bool CheckNameAndSurname(string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
