/*
-Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
-You must implement a solution with a linear runtime complexity and use only constant extra space.
 */

int SingleNumber(int[] nums)
{
    return nums.Aggregate((a, b) => a ^ b);
}

int[] nums = { 2, 2, 1 };
int single = SingleNumber(nums);
Console.WriteLine(single); // Output: 1
Console.ReadLine();
