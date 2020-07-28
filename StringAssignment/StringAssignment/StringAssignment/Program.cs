using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Leslie ";
            //string middleName = "Marie ";
            //string lastName = "Reichbaum";
            //string myname = string.Concat(firstName, middleName, lastName);
         

            //myname = myname.ToUpper();

            //Console.WriteLine(myname);

            StringBuilder sb = new StringBuilder();
            sb.Append("The Ministry of Truth, which concerned itself with news, entertainment, \n education and the fine arts.");
            sb.AppendLine("The Ministry of Peace, which is concerned itself with war.");
            sb.AppendLine("The Ministry of Love, which maintained law and order.");
            sb.AppendLine("-George Orwell's 1984");
            Console.WriteLine(sb);




        }
    }
}
