//Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

using System;
using System.Collections.Generic;
using System.Linq;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public static void Main()
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(1);

        Solution solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(head));
        Console.ReadLine();
    }

    public bool IsPalindrome(ListNode head)
    {
        if (head == null) return true;

        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        var reversedList = list.AsEnumerable().Reverse().ToList();
        return list.SequenceEqual(reversedList);
    }

}




