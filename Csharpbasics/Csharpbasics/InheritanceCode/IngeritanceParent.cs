using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.NewFolder1
{
   public class IngeritanceParent
    {

        //The public variable can be called using an instance of this class while privta can onle be called in this class
        //Encapsulation is displaying only what needs to be displayed
        public string ParentName = "Abisogun";
        private int Age = 35;
        protected char BloodType = 'O';

        public void PintName()
        {
            Console.WriteLine("My name is {0}",ParentName);
        }
        public void PintAge()
        {
            Console.WriteLine("I am {0} years old", Age);
        }

        public void PintBloodtype()
        {
            Console.WriteLine("My Bloodtype is {0}", BloodType);
        }
    }
}
