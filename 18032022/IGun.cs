using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal interface IGun
    {
        public string Name { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"{MagazineCapacity} - {CurrentMagazine}");
        }
    }
}
