/*
- You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
- Merge nums1 and nums2 into a single array sorted in non-decreasing order.
 */


void merge(int[] nums1, int m, int[] nums2, int n)
{
    var nums1SubList = nums1.Take(m).ToList();
    var nums2SubList = nums2.Take(n).ToList();
    var mergedList = nums1SubList.Concat(nums2SubList).OrderBy(x => x).ToArray();
    Array.Copy(mergedList, nums1, mergedList.Length);
}

int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
int[] nums2 = new int[] { 2, 5, 6 };
int m = 3, n = 3;

Console.WriteLine("Before merging: ");
Console.WriteLine("nums1: " + string.Join(" ", nums1));
Console.WriteLine("nums2: " + string.Join(" ", nums2));

merge(nums1, m, nums2, n);

Console.WriteLine("After merging: ");
Console.WriteLine("nums1: " + string.Join(" ", nums1));
Console.ReadLine();


