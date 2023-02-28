//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.


using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        nums = nums.Where(x => x != 0).Concat(nums.Where(x => x == 0)).ToArray();

        Console.WriteLine(string.Join(",", nums));
        Console.ReadLine();
    }
}

