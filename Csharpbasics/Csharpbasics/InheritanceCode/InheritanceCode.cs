using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class InheritanceCode
    {
        public string Kayname = "Kay";//This can be called anywhere in the code
        private int Age = 30;//Cant be accesed in outside the class
        protected char Bloodtype = 'O';//Protected cant be accessed using an object of the class

        public void Profile()
        {
            Console.WriteLine("My name is {0} and I am {1} years old with a bloodtype of {2}", Kayname, Age,Bloodtype);
        }
    }
}
