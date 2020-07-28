using System;
using System.Text;

namespace StringsFunctions.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Leslie";
            //string quote = "The man said, \"Hello\", Leslie. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Leslie";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Leslie";
            //name = "Brian";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Leslie");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
