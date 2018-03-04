using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    public class StaticMthod
        //Static variable cannnot be acced by the Object but can be accesed by the class name
        //Static methods can only accecc static variables or methods
    {
        //string Name;
        //string CarModel;
        //To initialise the above fields, a constructor is needed
        public StaticMthod() //Contructor
        {
            Console.WriteLine("Non static Constructor");
        }

        static double IntRate = 2.5;
        static double Loan = 500;

        static StaticMthod() //Contructor to initialise the above
        {
            //IntRate = 2.9;    
            Console.WriteLine("Static constructor");
        }

        //public void BuyCar (){ }
        //public void ServiceCar() { }
        public static double Enquiry() //You should be able to make an enquiry without being registered to the garage
        {
            Console.WriteLine(IntRate*Loan);
            Console.WriteLine("The above is the loan amount ");
            return IntRate*Loan;
        }




    }

   
}
