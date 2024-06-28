namespace LeetCode_Problems.Easy;

internal class P_83_Remove_Duplicates_from_Sorted_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null)
            return null;

        ListNode root = head;

        while (root.next != null)
        {
            if (root.val == root.next.val)
            {
                root.next = root.next.next;
            }
            else
            {
                root = root.next;
            }
        }

        return head;
    }
}


