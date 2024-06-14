namespace LeetCode_Problems.Easy;

public class P_21_Merge_Two_Lists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //Null Check
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        ListNode curr = new ListNode();
        ListNode root = curr;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }

            curr = curr.next;
        }

        if (list2 != null)
            curr.next = list2;
        if (list1 != null)
            curr.next = list1;

        return root.next;
    }
}

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(ListNode next = null, int val = 0)
    {
        this.next = next;
        this.val = val;
    }
}