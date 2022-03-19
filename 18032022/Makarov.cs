using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Makarov : IGun,IFireable
    {
        public string Name { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine { get; set; }

        public void Fire()
        {
            CurrentMagazine--;
        }
    }
}
