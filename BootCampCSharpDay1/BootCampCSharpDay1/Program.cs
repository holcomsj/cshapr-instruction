using System;

namespace BootCampCSharpDay1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("C# Day 1");

            int a = 5;
            int b = 10;
            int sum = a + b;

            Console.WriteLine(sum);

            string choice = "y";

          /*  while (choice.Equals("y")) {
                Console.WriteLine("In a while loop...");
                Console.Write("Choice? ");
                choice = Console.ReadLine();
                Console.WriteLine("choice = " + choice);
            }*/

            if (sum > 10) {
                Console.WriteLine("Sum greater than 10");
            } else {
                Console.WriteLine("Sum less than 10");
            }

           /* Console.WriteLine("Enter a number");
            String nbrStr = Console.ReadLine();
            int nbr = Convert.ToInt32(nbrStr);
            Console.WriteLine("nbr = " + nbr);*/

            double d1 = 4.5;
            double d2 = 5.7;
            int sum2 = (int)(d1 + d2);
            double sum3 = d1 + d2;
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Random random = new Random();

            int r1 = random.Next();
            Console.WriteLine("r1 = " + r1);

            int r2 = random.Next(10);
            Console.WriteLine("r2 = " + r2);

            while (r2 != 7) {
                 r2 = random.Next(10);
                Console.WriteLine("r2 = " + r2);
            }

            double d3 = 75.883493298;
            Console.WriteLine(Math.Round(d3));
            Console.WriteLine(Math.Round(d3, 2));

            double price = 15.99;
            double pct = .03467;

            Console.WriteLine("Price formatted: " + price.ToString("C2"));
            Console.WriteLine("pct formatted: " + pct.ToString("P3"));

            Console.WriteLine("Bye");
        }
    }
}
