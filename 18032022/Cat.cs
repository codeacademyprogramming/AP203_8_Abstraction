using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Cat:Animal
    {

        public override int Age { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }

        public override string GetInfo()
        {
            return $"Name: {this.Name} - Age: {this.Age}";
        }
    }
}
