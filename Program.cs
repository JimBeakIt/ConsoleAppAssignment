using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[5];

            strArray[0] = "feeling happy?";
            strArray[1] = "feeling sad?";
            strArray[2] = "feeling cross?";
            strArray[3] = "feeling excited?";
            strArray[4] = "feeling annoyed?";

            Console.WriteLine("Are you" + strArray[0]);
            string happy = Console.ReadLine();


        }
    }
}
