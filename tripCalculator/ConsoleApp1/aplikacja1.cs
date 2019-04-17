using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("-----------------");
            Console.WriteLine(Class1.ShowSystemInfo());
            Console.WriteLine("-trip calculator-");
            Class1.TripCalc();
            Console.WriteLine("----------Music------------");
            ClassLibrary1.Class1.MarioMusic();
            Console.WriteLine("-Pres any key-");
            Console.ReadKey();
        }
    }

}
