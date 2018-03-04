using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class SmartMethod
    {
        public void Smart(int salary, int benefit)
        {
            int totalwages = salary + benefit;
            Console.WriteLine(totalwages);
            Console.ReadKey();
        }
    }
}
