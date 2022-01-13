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

            strArray[0] = "Hello, ";
            strArray[1] = "Your age is ";
            strArray[2] = "You live in ";
            strArray[3] = "You enjoy eating ";
            strArray[4] = "Your faviorite film is ";

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What country do you live in?");
            string country = Console.ReadLine();

            Console.WriteLine("What do you enjoy eating?");
            string eating = Console.ReadLine();

            Console.WriteLine("What is your faviorite film?");
            string film = Console.ReadLine();

            Console.WriteLine("\n" + strArray[0] + name);
            Console.ReadLine();

            Console.WriteLine(strArray[1] + age);
            Console.ReadLine();

            Console.WriteLine(strArray[2] + country);
            Console.ReadLine();

            Console.WriteLine(strArray[3] + eating);
            Console.ReadLine();

            Console.WriteLine(strArray[4] + film);
            Console.ReadLine();

            int i = 0;

            while (true)
            {


                Console.WriteLine($"i = {i}");
                i++;

                if (i > 28)
                {
                    break;
                }
            }
            Console.ReadLine();

            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.WriteLine("C# For Loop: Iteration {0}", j);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Guess a name");

            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
            string findName = Console.ReadLine();

            if (names.Contains(findName))
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.ReadLine();

            var names1 = new List<string>() { "Apple", "Pear", "Peach", "Banana", "Apple", "Orange" };

            names1.ForEach(Console.WriteLine);

            Console.WriteLine("\n");

            IEnumerable<string> duplicates = names1.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);

            Console.WriteLine(String.Join(",", duplicates) + " has already appeared in the list");

            Console.ReadLine();
        }

    }
}

