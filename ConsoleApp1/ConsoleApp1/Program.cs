using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
            //Console.WriteLine("Please enter your Name");
            // String MyName = Console.ReadLine();

            // //if ((Name == "Andre") || (Name == "Dada"))
            // if (MyName.Equals("Andre") || MyName.Equals("Dada"))
            // {
            //     Console.WriteLine("Hi {0}, welcome to the programming course", MyName);
            // }
            // else if (MyName.Equals("John"))
            // {
            //     Console.WriteLine("Sorry {0}, you are not registered for this course", MyName);
            // }
            // else
            // {
            //     Console.WriteLine("Sorry {0}, you are not registered for this course", MyName);
            // }
            // Console.ReadKey();
            string yourname = null;
            int[] number = { 1, 101, 1001 };
            DateTime value = new DateTime();
            TextInfo textinfo = new CultureInfo("en - US", false).TextInfo;
            Console.WriteLine("Introduction Loading............");
            Console.WriteLine("What is your name ?");
            yourname = Console.ReadLine();
            Console.WriteLine("My name is " + textinfo.ToTitleCase(yourname) + ".");

            value = DateTime.Now;
            Console.WriteLine("Today’s date is" + value);
            for (int i = 0; i < number.Length; i++)
                Console.WriteLine(number[i]);
        }
    }
}
