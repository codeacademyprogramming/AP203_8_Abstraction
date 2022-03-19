using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Human
    {
        public string Name { get; set; }    
        public string Surname { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}");
        }

    }
}
