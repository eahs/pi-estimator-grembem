using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;
            double i = 0.0;
            double hit = 0.0;
            while (i < n)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                {
                    hit++;
                }

                i++;
            }
            // TODO: Calculate Pi
            pi = ((double)4.0*hit)/i;
            return pi;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}