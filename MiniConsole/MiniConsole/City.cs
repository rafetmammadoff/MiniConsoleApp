using System;
using System.Collections.Generic;
using System.Text;

namespace MiniConsole
{
    interface City
    {
        Human[] Humans { get;}
        public void AddHuman(Human human);
        Human[] SearchHuman(string text);
    }
}
