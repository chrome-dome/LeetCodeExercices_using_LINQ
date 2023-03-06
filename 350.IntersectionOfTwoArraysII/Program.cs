//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        var intersection = nums1.Intersect(nums2);
        foreach (var i in intersection)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine();
    }
}

