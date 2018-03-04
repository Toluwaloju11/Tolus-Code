using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.InterfaceCode
{
    /* 1. This a special class used to achieve full Abstraction
     * 2. Methods cant have definations in an Interface (Eg u cant create a method with public). This is the job of the derived class
     * 3. The Interface keyword is used to create an Interface
     * More than one Interface can be implemented in the derived clas, as opposed to an Abstract class, of which 
     * only one can be in a derived class
     *
    */
    interface IParentInterface
    {
        void DisplayNumber(int aNum);
        void DisplayNumber(int bNum, int cNum); 
    }
}
