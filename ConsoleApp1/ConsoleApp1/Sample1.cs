using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sample1
    {
        private int myAge = 10;
        public void PrintAge()
        {
           /*concartination*/ Console.WriteLine("I am {0} years old", myAge);
            /*Inperpolation*/Console.WriteLine("I am"+ myAge + "year old");
        }
    }
}
