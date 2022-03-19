using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class PetDog:Dog
    {
        public string OwnerFullName;

        public override void MakeSound()
        {
            Console.WriteLine("hau hau");
        }
    }
}
