using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMethods_Int_Decimal
{
   public class Integer
    {
        //First Method 
        public int AddInteger(int myInt)
        {
            int addNum = myInt + 2;
            return addNum;
        }

        //Second Method
        public int AddInteger(decimal myDec)
        {
            int subNum = Convert.ToInt32(myDec);
            int mySub = subNum - 1;
            return mySub;
        }
        //Third Method 
        public int AddInteger(string myString)
        {
            int multNum = Convert.ToInt32(myString);
            int myMult = multNum * 2;
            return myMult;
        }
    }
}
