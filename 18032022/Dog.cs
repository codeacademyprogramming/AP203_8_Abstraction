using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Dog : Animal
    {
        private int _age;
        public override int Age
        {
            get => _age;
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }


        public override string GetInfo()
        {
            return $"Name: {this.Name} - Age: {this.Age}";
        }

    }
}
