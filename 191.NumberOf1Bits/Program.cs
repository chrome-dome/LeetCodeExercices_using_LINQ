//Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

using System;
using System.Linq;

class Program
{
    static int HammingWeight(uint n)
    {
        return Convert.ToString(n, 2)
        .ToCharArray()
        .Where(c => c == '1')
        .Count();
    }

static void Main()
    {
        uint n = 00000000000000000000000000001011;
        Console.WriteLine("Hamming weight of " + n + " is: " + HammingWeight(n));
        Console.ReadLine();
    }
}
