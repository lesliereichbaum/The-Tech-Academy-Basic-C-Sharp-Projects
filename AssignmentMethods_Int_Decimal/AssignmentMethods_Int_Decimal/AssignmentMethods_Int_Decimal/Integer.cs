using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMethods_Int_Decimal
{
   public class Integer
    {

        public int AddInteger(int myInt)
        {
            int addNum = myInt + 2;
            return addNum;
        }
        public int AddInteger(decimal myInt)
        {
            int subNum = Convert.ToInt32(myInt);
            int mySub = subNum - 1;
            return mySub;

        }
    }
}
