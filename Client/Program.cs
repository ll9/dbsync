using Models;
using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        private static Random _random = new Random();
        private static string[] _people = new string[] { "Hans", "Peter", "Johannes" };
        private static int[] _ages = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                while (true)
                {
                    Console.WriteLine("Enter 'x' to cancel");
                    Console.WriteLine("Enter 'p' to create rand person");
                    var input = Console.ReadLine();

                    if (input == "x")
                    {
                        break;
                    }
                    else if (input == "p")
                    {
                        var randPerson = new SyncPerson(
                            _people[_random.Next(_people.Length)],
                            _ages[_random.Next(_ages.Length)],
                            "myproj");

                        Console.WriteLine(randPerson);
                    }
                }
            }
        }
    }
}
