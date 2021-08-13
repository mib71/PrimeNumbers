using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number you want to check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int dividers = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    dividers++;
                }
            }

            if (dividers == 2)
            {
                Console.WriteLine("The number is a Prime Number");
            }
            else
            {
                Console.WriteLine("The number is not a Prime Number");
            }

            Console.ReadKey();
        }
    }
}
