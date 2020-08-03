using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentVoidMethod
{
    public class MyClass
    {
        //added 'void' and removed 'int'
        public void VMethod (int firstNumb, int secNumb)
        {
            int AddNumb = firstNumb + 100;
            Console.WriteLine(secNumb);
        }
    }
}
