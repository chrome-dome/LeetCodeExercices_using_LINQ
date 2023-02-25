//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

using System;
using System.Linq;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        return nums.GroupBy(x => x).Any(g => g.Count() > 1);
    }

static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 2, 3, 1 };
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result); // output: true

        Console.ReadLine();
    }
}
