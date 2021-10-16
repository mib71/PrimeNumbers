using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number you want to check: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(number) ? "The number is a Prime Number" : "The number is not a Prime Number");            
        }

        private static bool IsPrime(int n)
        {
            if (n == 2) return true;

            if (n >= 3)
            {
                if (n % 2 == 0 || n == 9) return false;
                var limit = (int)Math.Floor(Math.Sqrt(n));

                for (int i = 2; i < limit; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
