using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorp
{
    class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public override void print()
        {
            Console.WriteLine("LaserJet printer printing. . .");
        }
    }
}