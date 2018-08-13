/*
Deficient Numbers - Medium from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12

A number is considered deficient if the sum of its factors is less than twice that number. 

For Example: 
10 is a deficient number. 
Factors of 10 are 1, 2, 5, 10 
Sum is 1 + 2 + 5 + 10 = 18 < 2 * 10 

Tasks: 
(Easy) Write a program to verify whether a given number is deficient or not. 
(Medium) Write a program to find all the deficient numbers in a range. 
(Hard) Given a number, write a program to display its factors, their sum and then verify whether it's deficient or not. . 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeficientNumbers
{
    class Program
    {
        static int start = 1; // Insert a start number of range to verify
        static int finish = 199; // Insert a end number of range to verify

        static void Main(string[] args)
        {
            int i = 0;

            for (int number = start; number <= finish; number++)
            {
                i += SumFact(number);
            }

            Console.WriteLine($"\nThere are {i} deficient numbers in the range from {start} to {finish}.\n");
        }

        static int SumFact(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum < 2 * n) { Console.WriteLine($"{n} is deficient number."); return 1; }

            return 0;
        }
    }
}