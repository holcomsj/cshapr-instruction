using System;

namespace ch03TravelTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");

            string choice = "y";

            while (choice.Equals("y"))
            {
                Console.Write("Enter Miles: ");
                string milesStr =  Console.ReadLine();
                double miles = Convert.ToDouble(milesStr);

                Console.Write("Enter miles per hour: ");
                string speedStr = Console.ReadLine();
                double speed = Convert.ToDouble(speedStr);

                double hours = miles / speed;
                int min = (int)(hours * 60);
                int hoursInt = min / 60;
                min %= 60;

                Console.WriteLine("Estimated travel time:\n" +
                    "Hours:\t" + hoursInt +
                    "\nMinutes:\t" + min);

                Console.WriteLine("Continue?(y/n)");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye");
        }
    }
}
