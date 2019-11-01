using System;

namespace ch04_TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Table of Powers");

            string choice = "y";

            while (choice.Equals("y"))
            {
                Console.Write("Enter an Integer: ");
                int nbr = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");
                for (int i = 1; i < (nbr +1); i++)
                {
                    int squared = i * i;
                    int cubed = i * i * i; 
                    Console.WriteLine(i + "\t" + squared + "\t" + cubed);
                }

                Console.WriteLine("Continue?(y/n)");
                choice = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Bye");
        }
    }
}
