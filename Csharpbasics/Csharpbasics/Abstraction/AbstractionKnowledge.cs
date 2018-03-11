using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Csharpbasics{
   public abstract class AbstractionKnowledge
    {/*
    * 1. This is a special type of class which is only used for inheritance 
    * 2. An object of an Abstract class CANNOT be created
    * 3. An abstract class can have Abstract methods
    * 4. Abstract Methods are those mothods whose implementation is defined my the derived class
    * 5. A derived class can only implement from one class */
       private int _numberone;
       private int _numbertwo;
       protected int numbersadded = 0;
       protected int numbersubtracted = 0;
        public void DisplayTotalSum()
       {
           Console.WriteLine(" The addistion of both is {0}", numbersadded);
       }
        public void DisplaySubSum()
        {
            Console.WriteLine(" The addistion of both is {0}", numbersubtracted);
        }
        public abstract void AddNumbers(int numA, int numB);
        public abstract void Sumnumbers(int sumA, int sumB);
    }
}
