using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class Child1
    {
        int Length = 4;
        int Breath = 7;

        public void GetArea()
        {
            int squareArea = Length*Breath;
            Console.WriteLine("The area of the square is : {0}", squareArea);
            Console.ReadKey();
        }
        // This method will not show a value in the main method as it's hiding the return
        public int GetDifference()
        {
            int getDofference = Breath - Length;
            return getDofference;

        }
    }
}
