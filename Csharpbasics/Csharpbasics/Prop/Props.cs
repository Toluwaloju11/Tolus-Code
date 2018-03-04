using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    class Props
    {
        private string _hiddenVariable;

    //METHOD 1
        //public void SetHiddenVariable(string variablevalue)
        //{
        //    _hiddenVariable = variablevalue;
        //}

        //public string GetHiddenVariable()
        //{
        //    return _hiddenVariable;

        //}


    //Method 2
        public string ShowVariable
        {
            get { return _hiddenVariable;  }
            set { _hiddenVariable = value; }
        }
    }
}
