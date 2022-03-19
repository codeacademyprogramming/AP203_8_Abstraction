using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal interface IAnimal
    {
        public int Age { get; set; }
        public void MakeSound();
        public string GetInfo();
    }
}
