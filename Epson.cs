using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorp
{
    class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer printing. . .");
        }
    }
}