using System;

namespace CSharpDayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NACHOS!!!!");

            Console.WriteLine("Enter an integer");
            int nbr = GetNbr();

            switch (nbr)
            {
                case 1:
                    Console.WriteLine("1 entered.");
                    break;
                case 2:
                    Console.WriteLine("2 entered.");
                    break;
                case 3:
                    Console.WriteLine("3 entered.");
                    break;
                default:
                    Console.WriteLine("This, while not technically wrong, was not planned for.");
                    break;
            }

            Console.WriteLine("for loop w/ index...");
            for (int i = 0; i < nbr; i++)
            {
                Console.WriteLine(i);
            }

            printThreeNumbers(5, 23, 13);
            printThreeNumbers();
            printThreeNumbers(5);
            printThreeNumbers(5, 10);
            //pass n1 and n3 but no n2
            printThreeNumbers(5, n3: 10);
            Console.WriteLine("This is the end, there is no more. Please leave.");


        }

        private static int GetNbr()
        {
                int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                return n;
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input");
                Console.WriteLine(e.ToString());
                return n;
            }
        }

        private static void printThreeNumbers(int n1 = 1, int n2 = 2, int n3 = 3)
        {
            Console.WriteLine("3 nbrs: " + n1 + ", " + n2 + ", " + n3);
        }

    }
      
}
