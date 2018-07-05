using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter your Name");
            String MyName = Console.ReadLine();

            //if ((Name == "Andre") || (Name == "Dada"))
            if (MyName.Equals("Andre") || MyName.Equals("Dada"))
            {
                Console.WriteLine("Hi {0}, welcome to the programming course", MyName);
            }
            else if (MyName.Equals("John"))
            {
                Console.WriteLine("Sorry {0}, you are not registered for this course", MyName);
            }
            else
            {
                Console.WriteLine("Sorry {0}, you are not registered for this course", MyName);
            }
            Console.ReadKey();
        }
    }
}
