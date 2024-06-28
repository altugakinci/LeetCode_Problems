using LeetCode_Problems.Easy;

namespace LeetCode_Problems.Helpers;

public class Helpers
{
    public static void PrintLinkedList(ListNode node)
    {
        while (node != null)
        {
            Console.WriteLine(node.val);
            node = node.next;
        }
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
