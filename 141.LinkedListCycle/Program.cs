/*
-Given head, the head of a linked list, determine if the linked list has a cycle in it.
-There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
-Return true if there is a cycle in the linked list. Otherwise, return false.
*/

using System;
using System.Runtime.Intrinsics.X86;

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
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = head.next;

        Solution solution = new Solution();
        bool result = solution.HasCycle(head);
        Console.WriteLine(result); // should output "True"
        Console.ReadLine();
    }

    public bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                return true;
            }
        }
        return false;
    }
}



//It is not possible to use LINQ in this example as it is used to operate on collections and this code is working with linked list, LINQ can not be used to traverse linked list.