using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class WarrantyStudent:Student
    {
        public string PrevGroupNo { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"CurrentGroupNo: {GroupNo} - PrevGroupNo: {PrevGroupNo}");
        }
    }
}
