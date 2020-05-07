using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace polymorp
{
    class Program
    {
        static void Main(string[] args)
        {

            PrinterWindows print;
            Console.WriteLine("Pilih printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet");

            Console.Write("\nNomor printer [1...3] : ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                print = new Epson();
            }
            else if (nomorprinter == 2)
            {
                print = new Canon();
            }
            else
            {
                print = new LaserJet();
            }

            print.show();
            print.print();
            Console.ReadKey();
        }
    }
}