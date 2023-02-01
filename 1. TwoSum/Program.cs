using System;
using System.Linq;

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = from i in Enumerable.Range(0, nums.Length)
                     from j in Enumerable.Range(i + 1, nums.Length - i - 1)
                     where nums[i] + nums[j] == target
                     select new int[] { i, j };

        return result.FirstOrDefault() ?? throw new ArgumentException("No two sum solution");
    }
}

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = new Solution().TwoSum(nums, target);
        Console.WriteLine("Indices of the two numbers that add up to the target: [{0}, {1}]", result[0], result[1]);
        Console.ReadLine();
    }
}