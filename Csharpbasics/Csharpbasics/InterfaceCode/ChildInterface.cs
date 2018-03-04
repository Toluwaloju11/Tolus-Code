using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.InterfaceCode
{
    public class ChildInterface : IParentInterface
    {
        private int _dnum;
        public void DisplayNumber(int aNum)
        {
            Console.WriteLine("Display {0} from child class", aNum);
        }

        public void DisplayNumber(int bNum, int cNum)
        {

            _dnum = bNum + cNum;
            Console.WriteLine("The total of {1} and {2} = {0}", _dnum, bNum, cNum);
        }
    }
}
