using System;
using System.Collections.Generic;
using System.Text;

namespace MethodwParameters
{
    public class MyClass
        //used =0 for optional parameter 
    {
        public int MultTwoInt(int firstInt, int secInt = 0)
        {
            int multNumb = firstInt* 10;

            if (secInt != 0)
            {
                multNumb = multNumb * secInt;
            }
            return multNumb;

        }
    }
}
