using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOverloadMethod
{
  public class MyClass
    {
   public  void VMethod (int divInt)
        {
            int intMethod = divInt/ 2;
            Console.WriteLine(intMethod);
        }
    public void  VMethod (double divDouble)
        {
            double doubleMethod = divDouble / 1.5;
            Console.WriteLine(doubleMethod);
        }

       static void OutPar (out int x)
        {
            x = 100;
        }

    }
}
