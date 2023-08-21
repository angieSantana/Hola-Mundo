
using System;

namespace Factorial_while_for
{
    class Program
    {
        static int factorial_for(int n)
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r = r*i;
            }
            return r;
        }

        static int factorial_while (int n)
        {
            int r = 1;
            int i = 1;
            while (i <= n)
            {
                r = r*i;
                i++;
            }
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("El factorial de 5 es: " + factorial_for(5));
            Console.WriteLine("El factorial de 5 es: " + factorial_while (5));
        }
    }
}