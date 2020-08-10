using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConstantVariables
{
   public class Program
    {
     
        public static void Main()
        {
            string niceTree = "Oak";
            Tree myTree = new Tree(niceTree);
            int age = myTree._age;

            //two local const variables 
            const string message = "Hello, World";
            Console.WriteLine(message);

            var txt = "It's such a beautiful day.";
            Console.WriteLine(txt);

        }
    }
    }
    
