//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.


int[] nums = new int[] { 1, 1, 2 };
nums = nums.Distinct().ToArray();
int newLength = nums.Length;
Console.WriteLine(newLength); // output: 2
Console.WriteLine(string.Join(",", nums)); // output: 1,2
Console.ReadLine();
