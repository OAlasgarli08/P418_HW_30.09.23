using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P418_HW_30._09._23_Practical2
{
    internal class Animal
    {
        public int id;
        public string name;

        public Animal(string text) 
        {
            Console.WriteLine("Animal constructor" + "-----------------" + text);
        }

        public void Sound() { Console.WriteLine("Animal sound"); }
    }
}
