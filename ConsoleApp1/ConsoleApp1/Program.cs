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
            //Console.WriteLine("Hello there");
            //String val1 = "My name is";
            //String val2 = "Jesus";
            //bool var3 = false;
            //char val4 = 'A';
            ////Console.WriteLine("Values {0},{1}", val1, val2);
            //Console.WriteLine(val1+" "+val2);
            //Console.ReadKey();
            
            char input = (char) Console.Read();
            if ((input == 'a') || (input == 'b')|| (input == 'c'))
            {
                Console.WriteLine("{0} is not the correct Input", input);
            }
            //else if (input == 'c')
            //{
            //    Console.WriteLine("Input is : {0}", input);

            //}
            else
            {
                Console.WriteLine("{0} is not the correct Input", input);

            }
            Console.ReadKey();
        }
    }
}
