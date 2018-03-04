using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    public class Constructor
    {
        //1. Constructors are auto called when a method is called in the main method. 
        //2. If there is more than one aaguement, then the one declared during object creation will be called.
        public Constructor()
        {
            Console.WriteLine("Contructor 1");
        }

        public Constructor(int age, string name, char bloodtype)
        {
           Console.WriteLine("Contructor 2");
        }
        public void Normalmathod()
        {
            Console.WriteLine("Normal method");
        }
    }
}
