using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void TripCalc()
        {
            Console.WriteLine("CALCULATE YOUR TRIP ");
            Console.WriteLine(" ");
            Console.Write("distance in km: ");
            string x = Console.ReadLine();
            decimal a = Convert.ToDecimal(x);

            Console.Write("Fuel per 100km: ");
            x = Console.ReadLine();
            decimal b = Convert.ToDecimal(x);

            Console.Write("petrol price: ");
            x = Console.ReadLine();
            decimal c = Convert.ToDecimal(x);
            decimal d = ((b * a) / 100) * c;

            Console.Write("distance: {0} km, cost: {1} PLN ", a, d);
            Console.ReadLine();
        }
        public static string ShowSystemInfo()
        {
            string info = "System info " +
            "System Version " + Environment.OSVersion + "\n" +
            "Version Microsoft .Net Framework " + Environment.Version + "\n" +
            "Computer name " + Environment.MachineName + "\n" +
            "System directory " + Environment.SystemDirectory + "\n";
            return (info);
           
        }
    }
        
    }
    


