using System;

namespace ch02_RectangleCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Rectangle Calculator App");

            string choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter length: ");
                string length = Console.ReadLine();
                Console.Write("Enter width: ");
                string width = Console.ReadLine();

                double l = Convert.ToDouble(length);
                double w = Convert.ToDouble(width);

                double area = l * w;
                double perimeter = 2 * l + 2 * w;

                Console.WriteLine("Area:\t" + area);
                Console.WriteLine("Perimeter:\t" + perimeter);

                Console.WriteLine("Contine?(y/n)");
                choice = Console.ReadLine();
            }
        }
    }
}
