using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P418_HW_30._09._23_Practical2
{
    internal class Bird : Animal
    {
        public int id;
        public string name;

        public Bird(string t) : base(t)
        {
            Console.WriteLine("bird constructor");
        }

        public void Sound()
        {
            Console.WriteLine("Bird Sound");
        }

    }
}
