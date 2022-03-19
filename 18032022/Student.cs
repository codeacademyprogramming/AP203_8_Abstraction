using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Student:Human
    {
        public string GroupNo { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"GroupNo: {GroupNo}");
        }
    }
}
