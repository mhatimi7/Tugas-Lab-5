using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorp
{
    class PrinterWindows
    {
        public virtual void show()
        {
            Console.WriteLine("\nPrinter display dimension");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer printing");
        }
    }
}