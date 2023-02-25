/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:
-Starting with any positive integer, replace the number by the sum of the squares of its digits.
-Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
-Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class HappyNumber
{
    public static void Main()
    {
        HappyNumber happy = new HappyNumber();
        Console.WriteLine(happy.IsHappy(19)); // Output: true
        Console.ReadLine();
    }

public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1)
        {
            int sum = n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Select(x => x * x).Sum();
            if (seen.Contains(sum))
            {
                return false;
            }
            seen.Add(sum);
            n = sum;
        }
        return true;
    }
}


