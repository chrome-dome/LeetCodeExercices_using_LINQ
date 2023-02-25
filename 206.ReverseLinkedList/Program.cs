//Given the head of a singly linked list, reverse the list, and return the reversed list.

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

class Program
{
    public static ListNode ReverseList(ListNode head)
    {
        return head == null ? head : new ListNode(head.val) { next = ReverseList(head.next) };
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                }
            }
        };
        ListNode reversedHead = ReverseList(head);

        while (reversedHead != null)
        {
            Console.Write(reversedHead.val + " ");
            reversedHead = reversedHead.next;
        }
    }
}





