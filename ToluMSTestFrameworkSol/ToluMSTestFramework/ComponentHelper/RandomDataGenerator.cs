using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToluMSTestFramework.ComponentHelper
{
   
    public class RandomDataGenerator
    {
        Random r = new Random();
        
        public  string FirstNameTestData()
        {
            string firstName = $"FirstName{r.Next()}";
            return firstName;
        }
        public string LastNameTestData()
        {
            string lastName = $"LastName{r.Next()}";
            return lastName;
        }
        public string PhoneNumberTestData()
        {
            string phoneNumber = $"FirstName{r.Next()}";
            return phoneNumber;
        }
        public string EmailTestData()
        {
            string email = $"FirstName{r.Next()}";
            return email;
        }
        public string Password()
        {
            string password = "coldfire"                                           ;
            return password;
        }
    }
}
