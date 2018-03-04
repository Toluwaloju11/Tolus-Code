using System;

namespace Csharpbasics
{
    public class person
    {
        public string _firstname = "Tolu";
        public string _lastname = "Abisogun";
        public string  Deji()
        {
            //var name = string.Format("{0} {1}", _firstname, _lastname);

            var name = string.Format("My full name is {0}{1}", _firstname, _lastname);
            //or
            //var name = $"{_firstname} {_lastname}";

            return name;

        }
    }
}