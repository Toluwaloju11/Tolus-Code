using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class Arrays
    {
        private string firstname = "Tolu";
        private string lastname = "Abisogun";
        private int savings = 2000;
        private int mortgage = 9890;
        private string YOB = "1980";
        private string initial = "TAW";

        


        public string Profile()
        {
            var fullname = string.Format("My name is {0}{1}", firstname, lastname);

            var names = new string[3] { "Deji", "Arin", "Ali"};

            var pff = string.Join(",", names);
            return pff;

        }

        public string NiNumber()
        {
            var names = new string[3] {YOB, initial, lastname};
           return string.Format("{0}{1}{2}", lastname, YOB,initial);
           

        }
        public void VerString()
        {

            var text = @"Hello there
Your firstname is " + firstname 
+"Your lastname is " + lastname;

            Console.WriteLine(text);
        }
    }
}
