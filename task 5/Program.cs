// See https://aka.ms/new-console-template for more information
using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
             
                if (prime[p] == true)
                {
                   
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
        }
    }
}

